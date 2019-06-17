using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using Unilab2018.Objects;
using Unilab2018.Objects.Enemies;
using Unilab2018.Objects.FieldItems;
using Unilab2018.Objects.Player;
using Unilab2018.Objects.Goal;
using Unilab2018.Fields;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using Unilab2018.Helpers;

namespace Unilab2018.Forms
{    public partial class GameForm : Form
    {
        #region field
        private readonly int _fps;
        private Graphics _graphicsBack, _graphicsFore;
        private readonly HashSet<Keys> _pressedKeys;
        private Field _field;
        private Random _rand;

        public float CellWidth => (float)backPictureBox.Width / _field.Width;
        public float CellHeight => (float)backPictureBox.Height / _field.Height;
        #endregion

        #region code
        public List<string> code;
        public int depth;
        public Stack<IEnumerator> exeCodeStack;
        public bool canMoveNextCode;  // 同フレーム内で次の行も実行していいかどうか. for・if・end の行を実行した時に true にして使う.
        public bool canMoveEnemy; // コード実行時のフレーム処理で2フレームに1回だけエネミーが動くようにする
        public int desiredMP; //　コマンドライン行数の目標値 
        public int TeleporterPairId; // テレポート時のペアID
        private Teleporter TeleportDestination; // テレポート先のテレポートマット
        public Dictionary<string, List<string>> codeDictionary; // ステージごとのコードいれる
        public Dictionary<string, List<string>> codeListBoxItemsDictionary; // ステージごとのコードリストボックスのアイテムを入れる
        public Dictionary<string, int> depthDictionary; // ステージごとのコードのdepthを入れる
        public bool endlessFlag; // 「ずっと」コマンドの中にいて、動作コマンド（前に進む、左を向く、右を向く、回復）が行われていない状態であるかどうか
        public Dictionary<string, bool> isGoaledDictionary; // ステージごとにゴールしているかどうかを入れる
        public bool isAllGoaledFlag; // 全てのステージをクリアしたかどうか
        #endregion

        public GameForm()
        {
            InitializeComponent();

            this.Size = new Size(1300, 830);
            this.StartPosition = FormStartPosition.CenterScreen;

            startPagePictureBox.Size = new Size(1300, 830);
            allGoaledPictureBox.Size = new Size(1300, 830);

            _fps = 10;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            typeof(PictureBox).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
                BindingFlags.Instance | BindingFlags.NonPublic, null, backPictureBox, new object[] { true });

            // Set foreground graphics
            backPictureBox.Image = new Bitmap(backPictureBox.Width, backPictureBox.Height);
            _graphicsFore = Graphics.FromImage(backPictureBox.Image);
            _graphicsFore.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            _graphicsFore.Clear(Color.Transparent);

            // Set background graphics
            backPictureBox.BackgroundImage = new Bitmap(backPictureBox.Width, backPictureBox.Height);
            _graphicsBack = Graphics.FromImage(backPictureBox.BackgroundImage);
            _graphicsBack.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            _graphicsBack.Clear(Color.FromArgb(255, 121, 207, 110));

            _pressedKeys = new HashSet<Keys>();
            globalTimer.Interval = (int)(1000 / (double)_fps);
            codeTimer.Interval = 333;
            _rand = new Random();

            exeCodeStack = new Stack<IEnumerator>();

            codeDictionary = new Dictionary<string, List<string>>();
            codeListBoxItemsDictionary = new Dictionary<string, List<string>>();
            depthDictionary = new Dictionary<string, int>();
            isGoaledDictionary = new Dictionary<string, bool>();
            for (int i = 1; i <= 17; i++)
            {
                codeDictionary[$"stage{i}"] = new List<string>();
                codeListBoxItemsDictionary[$"stage{i}"] = new List<string>();
                depthDictionary[$"stage{i}"] = 0;
                isGoaledDictionary[$"stage{i}"] = false;
            }

            ifComboBox.SelectedIndex = 0;
            forComboBox.SelectedIndex = 0;

            endlessFlag = false;
            isAllGoaledFlag = false;

            startPagePictureBox.Visible = true;

            var all_anc = AnchorStyles.Right | AnchorStyles.Left;
            for (int i = 0; i < 17; i++)
            {
                var b = this.Controls[$"stage{i + 1}Btn"];
                tableLayoutPanel1.Controls.Add(b, i%9, i/9);
                b.Anchor = all_anc;
            }
            

            _initialize("stage1");
        }

        #region ステージ初期化
        /// <summary>
        /// ステージ初期化の処理を書く。
        /// </summary>
        private void _initialize(string fieldName)
        {
            // Read field from "{fieldName}.json"
            _field = ReadFieldJson($"{fieldName}");

            #region Old stages
            #region Make stage1 field
            //_field = new Field { Width = 25, Height = 25, StageName = "stage1", Enemies = new List<Enemy>(), Walls = new List<Wall>(), Swamps = new List<Swamp>() };

            ////// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //_field.Walls.Remove(_field.Walls.Find(w => w.X == _field.Width / 2 - 1 && w.Y == _field.Height / 2 + 2));
            //_field.Walls.Remove(_field.Walls.Find(w => w.X == _field.Width / 2     && w.Y == _field.Height / 2 + 2));
            //_field.Walls.Remove(_field.Walls.Find(w => w.X == _field.Width / 2 + 1 && w.Y == _field.Height / 2 + 2));
            //_field.Walls.Remove(_field.Walls.Find(w => w.X == _field.Width / 2 + 1 && w.Y == _field.Height / 2 + 1));
            //_field.Walls.Remove(_field.Walls.Find(w => w.X == _field.Width / 2 + 1 && w.Y == _field.Height / 2    ));

            //// Make Palyer
            //_field.Player = new Player(_field.Width / 2 - 1, _field.Height / 2 + 2);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width / 2 + 1, _field.Height / 2);
            #endregion

            #region Make stage2 field
            //_field = new Field { Width = 25, Height = 25, StageName = "stage2", Enemies = new List<Enemy>(), Walls = new List<Wall>(), Swamps = new List<Swamp>() };
            // // Make Walls
            // for (int i = 0; i < _field.Width; i++)
            // {
            //     for (int j = 0; j < _field.Height; j++)
            //     {
            //         if (!(Math.Abs(j - _field.Height / 2 - 1) < 2 && Math.Abs(i - _field.Width / 2 - 1) < 5))
            //         {
            //             _field.Walls.Add(new Wall(i, j));
            //         }
            //         else if (Math.Abs(i - _field.Width / 2 - 1) == 0 || Math.Abs(i - _field.Width / 2 - 1) == 2)
            //         {
            //             _field.Swamps.Add(new Swamp(i, j));
            //         }
            //     }
            // }

            // // Make Palyer
            // _field.Player = new Player(_field.Width / 2 - 3, _field.Height / 2 + 1);

            // // Make Goal
            // _field.Goal = new Goal(_field.Width / 2 + 5, _field.Height / 2 + 1);
            #endregion

            #region Make stage3 field
            //_field = new Field { Width = 25, Height = 25, StageName = "stage3", Enemies = new List<Enemy>(), Walls = new List<Wall>(), Swamps = new List<Swamp>() };
            //// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        if (!(Math.Abs(j - _field.Height / 2 - 1) < 2 && i > 0 && i < _field.Width - 1))
            //        {
            //            _field.Walls.Add(new Wall(i, j));
            //        }
            //    }
            //}

            //// Make Palyer
            //_field.Player = new Player(1, _field.Height / 2 + 1);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width - 2, _field.Height / 2 + 1);
            #endregion

            #region Make stage4 field 
            //_field = new Field { Width = 25, Height = 25, StageName = "stage4", Enemies = new List<Enemy>(), Walls = new List<Wall>(), Swamps = new List<Swamp>() };

            //// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //for (int i = 1; i < _field.Width - 1; i++)
            //{
            //    for (int j = _field.Height - 3; j < _field.Height - 1; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = _field.Width - 3; i < _field.Width - 1; i++)
            //{
            //    for (int j = 6; j < _field.Height - 1; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = 11; i < _field.Width - 1; i++)
            //{
            //    for (int j = 6; j < 8; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = 11; i < 13; i++)
            //{
            //    for (int j = 8; j < 13; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}

            //// Make Palyer
            //_field.Player = new Player(1, _field.Height - 2);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width / 2, _field.Height / 2);
            #endregion

            #region Make stage5 field
            //_field = new Field { Width = 25, Height = 25, StageName = "stage5", Enemies = new List<Enemy>(), Walls = new List<Wall>(), Swamps = new List<Swamp>() };

            //// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //for (int i = 1; i < _field.Width - 1; i++)
            //{
            //    for (int j = _field.Height - 3; j < _field.Height - 1; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = _field.Width - 3; i < _field.Width - 1; i++)
            //{
            //    for (int j = 6; j < _field.Height - 1; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = 11; i < _field.Width - 1; i++)
            //{
            //    for (int j = 6; j < 8; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = 11; i < 13; i++)
            //{
            //    for (int j = 8; j < 13; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}

            //// Make Palyer
            //_field.Player = new Player(1, _field.Height - 2);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width / 2, _field.Height / 2);
            #endregion

            #region Make stage6 field
            //_field = new Field { Width = 25, Height = 25, StageName = "stage6", Enemies = new List<Enemy>(), Walls = new List<Wall>(), Swamps = new List<Swamp>() };

            ////// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //for (int i = 1; i < _field.Width - 1; i++)
            //{
            //    for (int j = _field.Height - 3; j < _field.Height - 1; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = _field.Width - 3; i < _field.Width - 1; i++)
            //{
            //    for (int j = 6; j < _field.Height - 1; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = 11; i < _field.Width - 1; i++)
            //{
            //    for (int j = 6; j < 8; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}
            //for (int i = 11; i < 13; i++)
            //{
            //    for (int j = 8; j < 13; j++)
            //    {
            //        _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == j));
            //    }
            //}

            //// Make Swamp
            //AddSwamp(_field.Width / 2 - 4, _field.Height - 2);
            //AddSwamp(_field.Width / 2 + 4, _field.Height - 2);
            //AddSwamp(_field.Width - 2, _field.Height / 2);
            //AddSwamp(_field.Width - 2, _field.Height / 2  + 5);
            //AddSwamp(_field.Width - 5, 6);
            //AddSwamp(_field.Width - 10, 6);
            //AddSwamp(_field.Width - 14, 10);

            //// Make Palyer
            //_field.Player = new Player(1, _field.Height - 2);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width / 2, _field.Height / 2);
            #endregion
            #endregion

            #region New stages
            #region Make stage1 field
            //_field = new Field
            //{
            //    Width = 21,
            //    Height = 15,
            //    StageName = "stage1",
            //    Enemies = new List<Enemy>(),
            //    Walls = new List<Wall>(),
            //    Swamps = new List<Swamp>(),
            //    Teleporters = new List<Teleporter>(),
            //};

            ////// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //_field.Walls.Remove(_field.Walls.Find(w => w.X == _field.Width / 2 - 1 && w.Y == _field.Height / 2));
            //_field.Walls.Remove(_field.Walls.Find(w => w.X == _field.Width / 2     && w.Y == _field.Height / 2));
            //_field.Walls.Remove(_field.Walls.Find(w => w.X == _field.Width / 2     && w.Y == _field.Height / 2 - 1));

            //// Make Palyer
            //_field.Player = new Player(_field.Width / 2 - 1, _field.Height / 2);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width / 2, _field.Height / 2 - 1);
            #endregion

            #region Make stage2 field
            //_field = new Field
            //{
            //    Width = 21,
            //    Height = 15,
            //    StageName = "stage2",
            //    Enemies = new List<Enemy>(),
            //    Walls = new List<Wall>(),
            //    Swamps = new List<Swamp>(),
            //    Teleporters = new List<Teleporter>(),
            //};

            ////// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //for (int i = 1; i < _field.Width - 1; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == _field.Height / 2));
            //}

            //// Make Palyer
            //_field.Player = new Player(1, _field.Height / 2);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width - 2, _field.Height / 2);
            #endregion

            #region Make stage3 field
            //_field = new Field
            //{
            //    Width = 21,
            //    Height = 15,
            //    StageName = "stage3",
            //    Enemies = new List<Enemy>(),
            //    Walls = new List<Wall>(),
            //    Swamps = new List<Swamp>(),
            //    Teleporters = new List<Teleporter>(),
            //};

            ////// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //for (int i = 1; i < _field.Width - 1; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == _field.Height / 2));
            //}

            //// Make Swamps
            //for (int i = 0; i < _field.Width / 4; i++)
            //{
            //    AddSwamp(i * 4, _field.Height / 2);
            //}

            //// Make Palyer
            //_field.Player = new Player(1, _field.Height / 2);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width - 2, _field.Height / 2);
            #endregion

            #region Make stage4 field
            //_field = new Field
            //{
            //    Width = 21,
            //    Height = 15,
            //    StageName = "stage4",
            //    Enemies = new List<Enemy>(),
            //    Walls = new List<Wall>(),
            //    Swamps = new List<Swamp>(),
            //    Teleporters = new List<Teleporter>(),
            //};

            ////// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //for (int i = 1; i < _field.Width - 1; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == _field.Height / 2));
            //}

            //// Make Swamps            
            //AddSwamp(6, _field.Height / 2);
            //AddSwamp(7, _field.Height / 2);
            //AddSwamp(8, _field.Height / 2);
            //AddSwamp(9, _field.Height / 2);
            //AddSwamp(13, _field.Height / 2);
            //AddSwamp(14, _field.Height / 2);

            //// Make Palyer
            //_field.Player = new Player(1, _field.Height / 2);

            //// Make Goal
            //_field.Goal = new Goal(_field.Width - 2, _field.Height / 2);
            #endregion

            #region Make stage5 field
            //_field = new Field
            //{
            //    Width = 21,
            //    Height = 15,
            //    StageName = "stage5",
            //    Enemies = new List<Enemy>(),
            //    Walls = new List<Wall>(),
            //    Swamps = new List<Swamp>(),
            //    Teleporters = new List<Teleporter>(),
            //};

            ////// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //for (int i = 6; i < 15; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == 3));
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == 11));
            //}
            //for (int i = 6; i < 11; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == 7));
            //}
            //for (int i = 4; i < 7; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == 6 && w.Y == i));
            //}
            //for (int i = 4; i < 11; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == 14 && w.Y == i));
            //}

            //// Make Palyer
            //_field.Player = new Player(6, 11);

            //// Make Goal
            //_field.Goal = new Goal(10, 7);
            #endregion

            #region Make stage6 field
            //_field = new Field
            //{
            //    Width = 21,
            //    Height = 15,
            //    StageName = "stage6",
            //    Enemies = new List<Enemy>(),
            //    Walls = new List<Wall>(),
            //    Swamps = new List<Swamp>(),
            //    Teleporters = new List<Teleporter>(),
            //};

            ////// Make Walls
            //for (int i = 0; i < _field.Width; i++)
            //{
            //    for (int j = 0; j < _field.Height; j++)
            //    {
            //        _field.Walls.Add(new Wall(i, j));
            //    }
            //}

            //// Wallを消す
            //for (int i = 6; i < 15; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == 3));
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == i && w.Y == 11));
            //}
            //for (int i = 3; i < 12; i++)
            //{
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == 6 && w.Y == i));
            //    _field.Walls.Remove(_field.Walls.Find(w => w.X == 14 && w.Y == i));
            //}
            //_field.Walls.Add(new Wall(6, 10));
            //_field.Walls.Add(new Wall(13, 11));
            //_field.Walls.Add(new Wall(14, 4));
            //_field.Walls.Add(new Wall(7, 3));

            //// Make Teleporter
            //AddTeleporter(12, 11, 1, false, Types.Direction.None);
            //AddTeleporter(14, 11, 1, true,  Types.Direction.Up);
            //AddTeleporter(14, 5,  2, false, Types.Direction.None);
            //AddTeleporter(14, 3,  2, true,  Types.Direction.Left);
            //AddTeleporter(8,  3,  3, false, Types.Direction.None);
            //AddTeleporter(6,  3,  3, true,  Types.Direction.Down);

            //// Make Palyer
            //_field.Player = new Player(6, 11);

            //// Make Goal
            //_field.Goal = new Goal(6, 9);
            #endregion
            #endregion

            code = codeDictionary[fieldName];
            codeListBox.Items.Clear();
            foreach (var item in codeListBoxItemsDictionary[fieldName])
            {
                codeListBox.Items.Add(item);
            }
            depth = depthDictionary[fieldName];

            // プレイヤーの位置・HP・歩数を初期化
            // 現在ステージを表示
            _initializePlayer();

            // コード実行を中止
            exeCodeStack.Clear();

            _graphicsBack.Clear(Color.FromArgb(255, 121, 207, 110));  

            foreach (var obj in _field.GameObjectList())
            {
                if (obj != null && !obj.CanMove) obj.Draw(_graphicsBack, CellWidth, CellHeight);
            }

            // Save current field to "bin\Debug\{fieldName}.json"
            SaveFieldJson(_field, fieldName);

            // タイマースタート
            globalTimer.Start();
            codeTimer.Start();
        }
        #endregion

        #region プレイヤー位置・HP・歩数を初期化　現在ステージ名を表示
        private void _initializePlayer()
        {
            #region old inisialization
            //switch(_field.StageName)
            //{
            //    default:
            //    case "test":
            //        _field.Player.X = _field.Width / 2;
            //        _field.Player.Y = _field.Height - 2;
            //        break;

            //    case "stage1":
            //        _field.Player.X = _field.Width / 2 - 1;
            //        _field.Player.Y = _field.Height / 2 + 2;
            //        break;

            //    case "stage2":
            //        _field.Player.X = _field.Width / 2 - 3;
            //        _field.Player.Y = _field.Height / 2 + 1;
            //        break;

            //    case "stage3":
            //        _field.Player.X = 1;
            //        _field.Player.Y = _field.Height / 2 + 1;
            //        break;

            //    case "stage4":
            //        _field.Player.X = 1;
            //        _field.Player.Y = _field.Height - 2;
            //        break;
            //    case "stage5":
            //        _field.Player.X = 1;
            //        _field.Player.Y = _field.Height - 2;
            //        break;
            //    case "stage6":
            //        _field.Player.X = 1;
            //        _field.Player.Y = _field.Height - 2;
            //        break;
            //}
            //_field.Player.HP = 10;
            //_field.Player.MaxHP = 10;
            //_field.Player.Pedometer = 0;
            #endregion

            #region new inisialization
            
            // デフォルトのHP
            // stage10     MaxHP : 1
            // stage11・14 MaxHP : 10
            _field.Player.MaxHP = 5;

            switch (_field.StageName)
            {
                default:
                case "stage1":
                    _field.Player.X = 9;
                    _field.Player.Y = 7;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 5;
                    _field.Player.DesiredPedometer = 5;
                    currentStageTextBox.Text = "ステージ1";
                    break;

                case "stage2":
                    _field.Player.X = 9;
                    _field.Player.Y = 8;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 5;
                    _field.Player.DesiredPedometer = 5;
                    currentStageTextBox.Text = "ステージ2";
                    break;

                case "stage3":
                    _field.Player.X = 1;
                    _field.Player.Y = _field.Height / 2;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 5;
                    _field.Player.DesiredPedometer = 20;
                    currentStageTextBox.Text = "ステージ3";
                    break;

                case "stage4":
                    _field.Player.X = 8;
                    _field.Player.Y = _field.Height / 2;
                    _field.Player.Direction = Types.Direction.Right;
                    _field.Player.MaxHP = 2;
                    desiredMP = 5;
                    _field.Player.DesiredPedometer = 5;
                    currentStageTextBox.Text = "ステージ4";
                    break;
                case "stage5":
                    _field.Player.X = 6;
                    _field.Player.Y = 11;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 40;
                    currentStageTextBox.Text = "ステージ5";
                    break;
                case "stage6":
                    _field.Player.X = 6;
                    _field.Player.Y = 11;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 5;
                    _field.Player.DesiredPedometer = 30;
                    currentStageTextBox.Text = "ステージ6";
                    break;
                case "stage7":
                    _field.Player.X = 5;
                    _field.Player.Y = 8;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 15;
                    currentStageTextBox.Text = "ステージ7";
                    break;
                case "stage8":
                    _field.Player.X = 6;
                    _field.Player.Y = 11;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 40;
                    currentStageTextBox.Text = "ステージ8";
                    break;
                case "stage9":
                    _field.Player.X = 5;
                    _field.Player.Y = 12;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 35;
                    currentStageTextBox.Text = "ステージ9";
                    break;
                case "stage10":
                    _field.Player.X = 4;
                    _field.Player.Y = _field.Height / 2;
                    _field.Player.Direction = Types.Direction.Up;
                    _field.Player.MaxHP = 1;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 40;
                    currentStageTextBox.Text = "ステージ10";
                    break;
                case "stage11":
                    _field.Player.X = 4;
                    _field.Player.Y = _field.Height / 2;
                    _field.Player.Direction = Types.Direction.Up;
                    _field.Player.MaxHP = 10;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 40;
                    currentStageTextBox.Text = "ステージ11";
                    break;
                case "stage12":
                    _field.Player.X = 7;
                    _field.Player.Y = _field.Height - 7;
                    _field.Player.Direction = Types.Direction.Up;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 35;
                    currentStageTextBox.Text = "ステージ12";
                    break;
                case "stage13":
                    _field.Player.X = 3;
                    _field.Player.Y = _field.Height - 3;
                    _field.Player.Direction = Types.Direction.Up;
                    _field.Player.MaxHP = 10;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 25;
                    currentStageTextBox.Text = "ステージ13";
                    break;
                case "stage14":
                    _field.Player.X = 3;
                    _field.Player.Y = 10;
                    _field.Player.Direction = Types.Direction.Right;
                    _field.Player.MaxHP = 16;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 45;
                    currentStageTextBox.Text = "ステージ14";
                    break;
                case "stage15":
                    _field.Player.X = 6;
                    _field.Player.Y = 10;
                    _field.Player.Direction = Types.Direction.Right;
                    _field.Player.MaxHP = 11;
                    desiredMP = 15;
                    _field.Player.DesiredPedometer = 30;
                    currentStageTextBox.Text = "ステージ15";
                    break;
                case "stage16":
                    _field.Player.X = 7;
                    _field.Player.Y = 10;
                    _field.Player.Direction = Types.Direction.Right;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 20;
                    currentStageTextBox.Text = "ステージ16";
                    break;
                case "stage17":
                    _field.Player.X = 3;
                    _field.Player.Y = 10;
                    _field.Player.Direction = Types.Direction.Down;
                    _field.Player.MaxHP = 10;
                    desiredMP = 10;
                    _field.Player.DesiredPedometer = 35;
                    currentStageTextBox.Text = "ステージ17";
                    break;
                    #region 没ステージ
                    //case "毒沼直線途中回復":
                    //    _field.Player.X = 1;
                    //    _field.Player.Y = _field.Height / 2;
                    //    _field.Player.Direction = Types.Direction.Right;
                    //    break;
                    //case "左右らせん毒沼通った方が近い":
                    //    _field.Player.X = 5;
                    //    _field.Player.Y = _field.Height - 3;
                    //    _field.Player.Direction = Types.Direction.Up;
                    //    break;
                    //case "左手法":
                    //    _field.Player.X = 3;
                    //    _field.Player.Y = _field.Height - 3;
                    //    _field.Player.Direction = Types.Direction.Right;
                    //    break;
                    //case "2017ステージ8と同じ":
                    //    _field.Player.X = 1;
                    //    _field.Player.Y = _field.Height - 2;
                    //    _field.Player.Direction = Types.Direction.Right;
                    //    break;
                    #endregion
            }
            _field.Player.Pedometer = 0;
            _field.Player.HP = _field.Player.MaxHP;
            #endregion
        }
            #endregion

        #region 毎フレーム処理
        private void globalTimer_Tick(object sender, EventArgs e)
        {
            _update();
            _draw();

            goalPictureBox.Visible = false;

            // ゴールに着いたらタイマーを止める
            if (_field.Player.Intersect(_field.Goal))
            {
                globalTimer.Stop();
                _pressedKeys.Clear();
                exeCodeStack.Clear();
                endlessFlag = false;
                isGoaledDictionary[_field.StageName] = true;
                MPTextBox.Text = $"行数: {codeListBox.Items.Count}　　目標: {desiredMP}";
                PedometerTextBox.Text = $"時間: {_field.Player.Pedometer}　　目標: {_field.Player.DesiredPedometer}";
                goalPictureBox.Visible = true;

                if (!isAllGoaledFlag)
                {
                    isAllGoaledFlag = true;
                    foreach (bool goaled in isGoaledDictionary.Values)
                    {
                        if (!goaled) isAllGoaledFlag = false;
                    }
                    if (isAllGoaledFlag)
                    {
                        allGoaledPictureBox.Visible = true;
                        ChangeCode();
                        _initialize(_field.StageName);
                        allGoaledPictureBox.Focus();
                    }
                } 
            }
        }

        /// <summary>
        /// フレームごとに実行する処理(ロジック部分)を書く。
        /// </summary>
        private void _update()
        {
            // Initialize Player
            foreach (var enemy in _field.Enemies)
            {
                if (enemy.Intersect(_field.Player))
                {
                    exeCodeStack.Clear();
                    endlessFlag = false;
                    _initializePlayer();
                }
            }

            // Key actions(Move Player)
            foreach (var key in _pressedKeys)
            {
                switch (key)
                {
                    //case Keys.Right:
                    //    if (!IsWall(_field.Player.X + 1, _field.Player.Y))
                    //    {
                    //        _field.Player.Pedometer++;
                    //        _field.Player.X++;
                    //    }
                    //    break;

                    //case Keys.Left:
                    //    if (!IsWall(_field.Player.X - 1, _field.Player.Y))
                    //    {
                    //        _field.Player.Pedometer++;
                    //        _field.Player.X--;
                    //    }
                    //    break;

                    //case Keys.Up:
                    //    if (!IsWall(_field.Player.X, _field.Player.Y - 1))
                    //    {
                    //        _field.Player.Pedometer++;
                    //        _field.Player.Y--;
                    //    }
                    //    break;

                    //case Keys.Down:
                    //    if (!IsWall(_field.Player.X, _field.Player.Y + 1))
                    //    {
                    //        _field.Player.Pedometer++;
                    //        _field.Player.Y++;
                    //    }
                    //    break;

                    case Keys.Enter:
                        startPagePictureBox.Visible = false;
                        allGoaledPictureBox.Visible = false;
                        break;

                    default:

                        break;
                }
            }
        }

        /// <summary>
        /// フレームごとに実行する処理(描画部分)を書く。
        /// </summary>
        private void _draw()
        {
            _graphicsFore.Clear(Color.Transparent);
            foreach (var obj in _field.GameObjectList())
            {
                if (obj != null && obj.CanMove) obj.Draw(_graphicsFore, CellWidth, CellHeight);
            }
            Refresh();
            HPTextBox.Text = $"HP: {_field.Player.HP}/{_field.Player.MaxHP}";
            if (isGoaledDictionary[_field.StageName])
            {
                MPTextBox.Text = $"行数: {codeListBox.Items.Count}　　目標: {desiredMP}";
                PedometerTextBox.Text = $"時間: {_field.Player.Pedometer}　　目標: {_field.Player.DesiredPedometer}";
            }
            else
            {
                MPTextBox.Text = $"行数: {codeListBox.Items.Count}　　目標: ?";
                PedometerTextBox.Text = $"時間: {_field.Player.Pedometer}　　目標: ?";
            }
        }

        /// <summary>
        /// コード実行時の毎フレーム処理
        /// </summary>
        private void codeTimer_Tick(object sender, EventArgs e)
        {
            if (canMoveEnemy)
            {
                // Move Enemies
                foreach (var enemy in _field.Enemies)
                {
                    switch (_rand.Next(2))
                    {
                        case 0:
                            if (!IsWall(enemy.X, enemy.Y + 1)) enemy.Y++;
                            break;

                        case 1:
                            if (!IsWall(enemy.X, enemy.Y - 1)) enemy.Y--;
                            break;

                        default:
                            break;
                    }
                }
                canMoveEnemy = false;
            }
            else
            {
                canMoveEnemy = true;
            }

            if (IsTeleporter(_field.Player.X, _field.Player.Y) )
            {
                TeleporterPairId = _field.Teleporters.Find(t => t.X == _field.Player.X && t.Y == _field.Player.Y).PairId;
                TeleportDestination = _field.Teleporters.Find(t => t.PairId == TeleporterPairId && (t.X != _field.Player.X || t.Y != _field.Player.Y));
                _field.Player.X = TeleportDestination.X;
                _field.Player.Y = TeleportDestination.Y;
                _field.Player.Direction = TeleportDestination.Direction;
                _field.Player.Pedometer++;
            }
            else if (!_field.Player.Intersect(_field.Goal))
            {
                canMoveNextCode = true;
                while (exeCodeStack.Count > 0 && canMoveNextCode) exeCodeStack.Peek().MoveNext();
            }

            if (IsSwamp(_field.Player.X, _field.Player.Y)) _field.Player.HP--;
            if (_field.Player.HP <= 0)
            {
                exeCodeStack.Clear();
                endlessFlag = false;
                _initializePlayer();
            }
        }
        #endregion

        #region Key and Button event
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            _pressedKeys.Add(e.KeyCode);
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            _pressedKeys.Remove(e.KeyCode);
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            code.Add("move");
            codeListBox.Items.Add(new String(' ', depth * 4) + "前に進む");
        }

        private void cureBtn_Click(object sender, EventArgs e)
        {
            code.Add("cure");
            codeListBox.Items.Add(new String(' ', depth * 4) + "回復");
        }

        private void turnLeftBtn_Click(object sender, EventArgs e)
        {
            code.Add("turnLeft");
            codeListBox.Items.Add(new String(' ', depth * 4) + "左を向く");
        }

        private void turnRightBtn_Click(object sender, EventArgs e)
        {
            code.Add("turnRight");
            codeListBox.Items.Add(new String(' ', depth * 4) + "右を向く");
        }        

        private void ifBtn_Click(object sender, EventArgs e)
        {
            code.Add("if");
            code.Add(ifComboBox.SelectedIndex.ToString());
            codeListBox.Items.Add(new String(' ', depth * 4) + "もし　" + ifComboBox.Text);
            depth++;
        }

        private void forBtn_Click(object sender, EventArgs e)
        {
            code.Add("for");
            code.Add(forNumericUpDown.Value.ToString());
            codeListBox.Items.Add(new String(' ', depth * 4) + forNumericUpDown.Value.ToString() + "回　繰り返す");
            depth++;
        }

        private void endlessBtn_Click(object sender, EventArgs e)
        {
            code.Add("endless");
            codeListBox.Items.Add(new String(' ', depth * 4) + "ずっと");
            depth++;
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            if (depth > 0)
            {
                depth--;
                code.Add("end");
                codeListBox.Items.Add(new String(' ', depth * 4) + "ここまで");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (exeCodeStack.Count() > 0)
            {
                exeCodeStack.Clear();
                endlessFlag = false;
            }

            if (code.Count > 1)
            {
                string c2 = code[code.Count - 2];
                string c1 = code[code.Count - 1];
                if (c2 == "if" || c2 == "for" || c2 == "until")
                {
                    code.RemoveAt(code.Count - 1);
                    code.RemoveAt(code.Count - 1);
                    codeListBox.Items.RemoveAt(codeListBox.Items.Count - 1);
                    depth--;
                }
                else if (c2 == "elseIf")
                {
                    code.RemoveAt(code.Count - 1);
                    code.RemoveAt(code.Count - 1);
                    codeListBox.Items.RemoveAt(codeListBox.Items.Count - 1);
                }
                else if (c1 == "endless")
                {
                    code.RemoveAt(code.Count - 1);
                    codeListBox.Items.RemoveAt(codeListBox.Items.Count - 1);
                    depth--;
                }
                else if (c1 == "end")
                {
                    code.RemoveAt(code.Count - 1);
                    codeListBox.Items.RemoveAt(codeListBox.Items.Count - 1);
                    depth++;
                }
                else
                {
                    code.RemoveAt(code.Count - 1);
                    codeListBox.Items.RemoveAt(codeListBox.Items.Count - 1);
                }
            }
            else if (code.Count > 0)
            {
                if (code[0] == "endless")
                {
                    code.RemoveAt(code.Count - 1);
                    codeListBox.Items.RemoveAt(codeListBox.Items.Count - 1);
                    depth--;
                }
                else
                {
                    code.RemoveAt(code.Count - 1);
                    codeListBox.Items.RemoveAt(codeListBox.Items.Count - 1);
                }
            }
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            code.Clear();
            codeListBox.Items.Clear();
            depth = 0;
        }

        private void resetPlayerBtn_Click(object sender, EventArgs e)
        {
            exeCodeStack.Clear();
            endlessFlag = false;
            _initializePlayer();
            globalTimer.Start();
        }

        private void exeBtn_Click(object sender, EventArgs e)
        {
            switch (CheckCode(code))
            {
                case "true":
                    exeCodeStack.Push(ExeCode(code));
                    break;

                case "else":
                    MessageBox.Show("「そうではなく」の位置を変えよう！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "end":
                    MessageBox.Show("「ここまで」を付けよう！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    break;
            }
        }

        private void stage1Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage1");
        }

        private void stage2Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage2");
        }

        private void stage3Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage3");
        }

        private void stage4Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage4");
        }
        private void stage5Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage5");
        }
        private void stage6Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage6");
        }
        private void stage7Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage7");
        }
        private void stage8Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage8");
        }
        private void stage9Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage9");
        }
        private void stage10Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage10");
        }
        private void stage11Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage11");
        }
        private void stage12Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage12");
        }
        private void stage13Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage13");
        }

        private void stage14Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage14");
        }

        private void stage15Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage15");
        }

        private void stage16Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage16");
        }

        private void stage17Btn_Click(object sender, EventArgs e)
        {
            ChangeCode();
            _initialize("stage17");
        }

        private void ChangeCode()
        {
            codeDictionary[_field.StageName] = new List<string>(code);
            codeListBoxItemsDictionary[_field.StageName] = new List<string>();
            foreach (var item in codeListBox.Items)
            {
                codeListBoxItemsDictionary[_field.StageName].Add(item.ToString());
            }
            depthDictionary[_field.StageName] = depth;
        }

        #region 没のボタン
        //private void startBtn_Click(object sender, EventArgs e)
        //{
        //    globalTimer.Start();
        //    exeCodeStack.Clear();
        //    codeTimer.Start();
        //}

        //private void stopBtn_Click(object sender, EventArgs e)
        //{
        //    globalTimer.Stop();
        //    codeTimer.Stop();
        //    exeCodeStack.Clear();
        //}

        //private void upBtn_Click(object sender, EventArgs e)
        //{
        //    if (MP <= 0)
        //    {
        //        NoMPMessage();
        //    }
        //    else
        //    {
        //        code.Add("up");
        //        codeListBox.Items.Add(new String(' ', depth * 4) + "上に移動");
        //        MP--;
        //    }
        //}

        //private void rightBtn_Click(object sender, EventArgs e)
        //{
        //    if (MP <= 0)
        //    {
        //        NoMPMessage();
        //    }
        //    else
        //    {
        //        code.Add("right");
        //        codeListBox.Items.Add(new String(' ', depth * 4) + "右に移動");
        //        MP--;
        //    }
        //}

        //private void downBtn_Click(object sender, EventArgs e)
        //{
        //    if (MP <= 0)
        //    {
        //        NoMPMessage();
        //    }
        //    else
        //    {
        //        code.Add("down");
        //        codeListBox.Items.Add(new String(' ', depth * 4) + "下に移動");
        //        MP--;
        //    }
        //}

        //private void leftBtn_Click(object sender, EventArgs e)
        //{
        //    if (MP <= 0)
        //    {
        //        NoMPMessage();
        //    }
        //    else
        //    {
        //        code.Add("left");
        //        codeListBox.Items.Add(new String(' ', depth * 4) + "左に移動");
        //        MP--;
        //    }
        //}
        //private void elseIfBtn_Click(object sender, EventArgs e)
        //{
        //    if (MP <= 0)
        //    {
        //        NoMPMessage();
        //    }
        //    else
        //    {
        //        if (depth > 0)
        //        {
        //            depth--;
        //            code.Add("elseIf");
        //            code.Add(elseIfComboBox.SelectedIndex.ToString());
        //            codeListBox.Items.Add(new String(' ', depth * 4) + "そうでなく　もし　" + elseIfComboBox.Text);
        //            depth++;
        //            MP--;
        //        }
        //    }
        //}

        //private void elseBtn_Click(object sender, EventArgs e)
        //{
        //    if (MP <= 0)
        //    {
        //        NoMPMessage();
        //    }
        //    else
        //    {
        //        if (depth > 0)
        //        {
        //            depth--;
        //            code.Add("elseIf");
        //            code.Add("true");
        //            codeListBox.Items.Add(new String(' ', depth * 4) + "そうでなければ");
        //            depth++;
        //            MP--;
        //        }
        //    }
        //}
        //private void untilBtn_Click(object sender, EventArgs e)
        //{
        //    if (MP <= 0)
        //    {
        //        NoMPMessage();
        //    }
        //    else
        //    {
        //        code.Add("until");
        //        code.Add(untilComboBox.SelectedIndex.ToString());
        //        codeListBox.Items.Add(new String(' ', depth * 4) + untilComboBox.Text + "　まで");
        //        depth++;
        //        MP--;
        //    }
        //}
        #endregion
        #endregion

        #region サイズ変更
        private void backPictureBox_SizeChanged(object sender, EventArgs e)
        {

            // Set foreground graphics
            backPictureBox.Image = new Bitmap(backPictureBox.Width, backPictureBox.Height);
            _graphicsFore = Graphics.FromImage(backPictureBox.Image);

            // Set background graphics
            backPictureBox.BackgroundImage = new Bitmap(backPictureBox.Width, backPictureBox.Height);
            _graphicsBack = Graphics.FromImage(backPictureBox.BackgroundImage);
            if (_field.GameObjectList().Count() > 0)
            {
                foreach (var obj in _field.GameObjectList())
                {
                    if (obj == null) continue;
                    if (!obj.CanMove) obj.Draw(_graphicsBack, CellWidth, CellHeight);
                }
            }
        }
        #endregion

        #region 追加メソッド・判別用メソッド
        private void AddEnemy(int x, int y) => _field.Enemies.Add(new Enemy(x, y));

        private void AddSwamp(int x, int y) => _field.Swamps.Add(new Swamp(x, y));

        private void AddTeleporter(int x, int y, int pairId, bool isDestination, Types.Direction direction) => _field.Teleporters.Add(new Teleporter(x, y, pairId, isDestination, direction));

        private bool IsWall(int x, int y) => _field.Walls.Where(w => w.X == x && w.Y == y).Count() > 0;

        private bool IsEnemy(int x, int y) => _field.Enemies.Where(w => w.X == x && w.Y == y).Count() > 0;

        private bool IsSwamp(int x, int y) => _field.Swamps.Where(w => w.X == x && w.Y == y).Count() > 0;

        private bool IsTeleporter(int x, int y) => _field.Teleporters.Where(w => w.X == x && w.Y == y && !w.IsDestination).Count() > 0;

        private bool IsRoad(int x, int y)
        {
            return _field.Walls.Where(w => w.X == x && w.Y == y).Count() + 
                   _field.Teleporters.Where(w => w.X == x && w.Y == y).Count() +
                   _field.Swamps.Where(w => w.X == x && w.Y == y).Count() == 0;
        }
        #endregion

        #region JSON methods

        private void SaveFieldJson(Field field, string fileName)
        {
            var filePath = Environment.CurrentDirectory + @"\" + fileName + ".json";
            var enc = Encoding.GetEncoding("utf-8");

            var output = JsonConvert.SerializeObject(field, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            File.WriteAllText(filePath, output, enc);
        }

        private Field ReadFieldJson(string name)
        {
            //現在のコードを実行しているAssemblyを取得
            var myAssembly = Assembly.GetExecutingAssembly();
            var sr = new StreamReader(
                myAssembly.GetManifestResourceStream("Unilab2018.Fields." + name + ".json"),
                    Encoding.GetEncoding("utf-8"));
            var input = sr.ReadToEnd();
            sr.Close();

            var deserialized = JsonConvert.DeserializeObject<Field>(
                input, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            return deserialized;
        }
        #endregion

        #region スクリプト実行
        // コードを実行
        // 何を実行するかcodeに入れておく
        // 例： code = {"move", "if", "1", "for", "10", "move", "end", "end"}
        // if文は { "if", "条件文の種類" } で表す
        // 例： {"if", "1"}
        // for文は {"for", "ループ回数"} で表す
        // 例： {"for", "10"}
        // "if"と"for"は"end"で閉じておく
        private IEnumerator<string> ExeCode(List<string> code)
        {
            // 全体で使う変数
            int i; // 現在実行しているコードのindex
            string c; // i番目のコード
            
            // if用の変数
            string ifType; // 条件文の種類

            // for用の変数
            int loopNum; // ループ回数

            // until用の変数
            string untilType; // 条件文の種類

            // for・until用の変数
            List<string> subCode; // for文の内側のコード

            i = 0;
            while (i < code.Count)
            {
                canMoveNextCode = false;
                c = code[i];
                switch (c)
                {
                    case "right":
                        if (!IsWall(_field.Player.X + 1, _field.Player.Y))
                            _field.Player.X++;
                        break;

                    case "left":
                        if (!IsWall(_field.Player.X - 1, _field.Player.Y)) _field.Player.X--;
                        break;

                    case "up":
                        if (!IsWall(_field.Player.X, _field.Player.Y - 1)) _field.Player.Y--;
                        break;

                    case "down":
                        if (!IsWall(_field.Player.X, _field.Player.Y + 1)) _field.Player.Y++;
                        break;

                    case "move":
                        if (IsWall(_field.Player.ForwardX(), _field.Player.ForwardY()))
                        {
                            exeCodeStack.Clear();
                            endlessFlag = false;
                            MessageBox.Show("前は花だよ！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            _field.Player.Pedometer++;
                            _field.Player.Move();
                            endlessFlag = false;
                        }
                        break;

                    case "cure":
                        _field.Player.HP++;
                        if (_field.Player.HP > _field.Player.MaxHP) _field.Player.HP = _field.Player.MaxHP;
                        _field.Player.Pedometer++;
                        endlessFlag = false;
                        break;

                    case "turnRight":
                        _field.Player.Pedometer++;
                        _field.Player.TurnRight();
                        endlessFlag = false;
                        break;

                    case "turnLeft":
                        _field.Player.Pedometer++;
                        _field.Player.TurnLeft();
                        endlessFlag = false;
                        break;

                    case "if":
                        i++;
                        ifType = code[i];
                        if (!IfCheck(ifType))
                        {
                            i = skipSubCode(code, i, true);
                        }
                        canMoveNextCode = true;
                        break;

                    case "elseIf":
                        i = skipSubCode(code, i, false);
                        canMoveNextCode = true;
                        break;

                    case "for":
                        i++;
                        loopNum = int.Parse(code[i]);
                        subCode = GetSubCode(code, i);
                        i += subCode.Count();
                        for (int _ = 0; _ < loopNum; _++)
                        {
                            exeCodeStack.Push(ExeCode(subCode));
                        }
                        canMoveNextCode = true;
                        break;

                    case "until":
                        i++;
                        untilType = code[i];
                        if (UntilCheck(untilType))
                        {
                            i = skipSubCode(code, i, false);
                        }
                        else
                        {
                            subCode = GetSubCode(code, i);
                            exeCodeStack.Push(ExeCode(subCode));
                            i -= 2;
                        }
                        canMoveNextCode = true;
                        break;

                    case "endless":
                        if (endlessFlag)
                        {
                            exeCodeStack.Clear();
                            endlessFlag = false;
                            MessageBox.Show("無限ループになってしまうよ！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            endlessFlag = true;
                        }
                        subCode = GetSubCode(code, i);
                        exeCodeStack.Push(ExeCode(subCode));
                        i--;
                        canMoveNextCode = true;
                        break;

                    case "end":
                        canMoveNextCode = true;
                        break;

                    default:
                        break;
                }
                i++;
                yield return null;
            }
            exeCodeStack.Pop();
            yield break;
        }

        // if文・until文の中の最後のコードのindexを返す
        // stopAtElse == true なら, 条件文 == true の else があった時に, その条件文の index を返す
        private int skipSubCode(List<string> code, int i, bool stopAtElse)
        {
            string c;
            string ifType; // if文の条件文の種類. if文の場合に使う.
            int subDepth;

            subDepth = 0;
            while (true)
            {
                i++;
                c = code[i];
                if (c == "elseIf" && subDepth == 0 && stopAtElse)
                {
                    i++;
                    ifType = code[i];
                    if (IfCheck(ifType)) break;
                }
                if (c == "end")
                {
                    if (subDepth == 0)
                    {
                        break;
                    }
                    else
                    {
                        subDepth--;
                    }
                }
                if (c == "if" || c == "for" || c == "until" || c == "endless")
                {
                    subDepth++;
                }
            }

            return i;
        }

        // for文・until文の内側のコードを返す
        private List<string> GetSubCode(List<string> code, int i)
        {
            int j; // 現在いるコードのindex
            int starti; // 内側の最初のコードのindex
            int endi; // 内側の最後のコードのindex
            int subDepth; // 現在いるコードの深さ
            string cj; // j番目のコード

            subDepth = 0;
            starti = i + 1;
            j = i;

            while (true)
            {
                j++;
                cj = code[j];
                if (cj == "end")
                {
                    if (subDepth == 0)
                    {
                        endi = j;
                        break;
                    }
                    else
                    {
                        subDepth--;
                    }
                }
                if (cj == "if" || cj == "for" || cj == "until" || cj == "endless")
                {
                    subDepth++;
                }
            }
            return code.GetRange(starti, endi - starti);
        }

        // ifの条件文がtrueかどうかを返す
        private bool IfCheck(string ifType)
        {
            switch (ifType)
            {
                #region 道
                case "0":
                    if (IsRoad(_field.Player.ForwardX(), _field.Player.ForwardY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "1":
                    if (IsRoad(_field.Player.BackX(), _field.Player.BackY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "2":
                    if (IsRoad(_field.Player.RightX(), _field.Player.RightY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "3":
                    if (IsRoad(_field.Player.LeftX(), _field.Player.LeftY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                #endregion

                #region HP
                case "4":
                    if (_field.Player.HP == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "5":
                    if (_field.Player.HP == 4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "6":
                    if (_field.Player.HP == 7)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                #endregion

                #region 壁
                case "7":
                    if (IsWall(_field.Player.ForwardX(), _field.Player.ForwardY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "8":
                    if (IsWall(_field.Player.BackX(), _field.Player.BackY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "9":
                    if (IsWall(_field.Player.RightX(), _field.Player.RightY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "10":
                    if (IsWall(_field.Player.LeftX(), _field.Player.LeftY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                #endregion

                #region 沼
                case "11":
                    if (IsSwamp(_field.Player.ForwardX(), _field.Player.ForwardY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "12":
                    if (IsSwamp(_field.Player.BackX(), _field.Player.BackY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "13":
                    if (IsSwamp(_field.Player.RightX(), _field.Player.RightY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "14":
                    if (IsSwamp(_field.Player.LeftX(), _field.Player.LeftY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                #endregion

                #region テレポート
                case "15":
                    if (IsTeleporter(_field.Player.ForwardX(), _field.Player.ForwardY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "16":
                    if (IsTeleporter(_field.Player.BackX(), _field.Player.BackY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "17":
                    if (IsTeleporter(_field.Player.RightX(), _field.Player.RightY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "18":
                    if (IsTeleporter(_field.Player.LeftX(), _field.Player.LeftY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                #endregion

                case "true":
                    return true;

                default:
                    return false;
            }
        }

        // untilの条件文がtrueかどうかを返す
        private bool UntilCheck(string untilType)
        {
            switch (untilType)
            {
                case "0":
                    if (!IsEnemy(_field.Player.ForwardX(), _field.Player.ForwardY()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "1":
                    if (!IsEnemy(_field.Player.X, _field.Player.Y - 1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "2":
                    if (!IsEnemy(_field.Player.X, _field.Player.Y + 1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "3":
                    if (!IsEnemy(_field.Player.X + 1, _field.Player.Y))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "4":
                    if (!IsEnemy(_field.Player.X - 1, _field.Player.Y))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void editCustomSatgeBtn_Click(object sender, EventArgs e)
        {
            var csForm = new CustomStageForm();
            csForm.Show();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void ifComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void startPagePictureBox_Click(object sender, EventArgs e)
        {

        }

        // コードをチェック
        // ・コードに含まれる for・if・endless の合計数と end の合計数が一致するかを判定
        // ・else が if - end 間にあるかを判定
        private string CheckCode(List<string> code)
        {
            int subDepth = 0;
            Stack<string> statementTypeStack = new Stack<string>();
            statementTypeStack.Push("None");

            foreach (string c in code)
            {
                if (c == "for")
                {
                    subDepth++;
                    statementTypeStack.Push("for");
                }
                if (c == "if")
                {
                    subDepth++;
                    statementTypeStack.Push("if");
                }
                if (c == "endless")
                {
                    subDepth++;
                    statementTypeStack.Push("endless");
                }
                if (c == "until")
                {
                    subDepth++;
                    statementTypeStack.Push("until");
                }
                if (c == "end")
                {
                    subDepth--;
                    statementTypeStack.Pop();
                }
                if (c == "elseIf" )
                {
                    if (statementTypeStack.Peek() != "if") return "else";
                }
            }
            if (subDepth == 0)
            {
                return "true";
            }
            else
            {
                return "end";
            }
        }
        #endregion

        
    }
}
