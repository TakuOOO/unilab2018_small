using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unilab2018.Fields;
using Unilab2018.Objects;
using Unilab2018.Objects.Enemies;
using Unilab2018.Objects.FieldItems;
using Unilab2018.Objects.Goal;
using Unilab2018.Objects.Player;
using Unilab2018.Helpers;

namespace Unilab2018.Forms
{
    public partial class CustomStageForm : Form
    {
        private readonly int _fps;
        private Graphics _graphicsBack, _graphicsFore;
        private readonly HashSet<Keys> _pressedKeys;
        private Field _field;
        private Point _targetCell;
        public float CellWidth => (float)backPictureBox.Width / _field.Width;
        public float CellHeight => (float)backPictureBox.Height / _field.Height;
        private bool _writeFlag;
        class lastChangedCell
        {
            public int x { get; }
            public int y { get; }
            public string type { get; }
            public lastChangedCell(int x, int y, string type)
            {
                this.x = x;
                this.y = y;
                this.type = type;
            }
        }
        private lastChangedCell _lcc;

        public CustomStageForm()
        {
            InitializeComponent();

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
            _graphicsBack.Clear(Color.White);

            _pressedKeys = new HashSet<Keys>();
            _targetCell = new Point(-1, -1);
            _writeFlag = false;

            globalTimer.Interval = (int)(1000 / (double)_fps);

            clearStage();
            globalTimer.Start();

        }

        private void clearStage()
        {
            _field = new Field { Width = 21, Height = 15, StageName = "stage1", Enemies = new List<Enemy>(), Walls = new List<Wall>(), Swamps = new List<Swamp>() };

            // Make Walls
            for (int i = 0; i < _field.Width; i++)
            {
                for (int j = 0; j < _field.Height; j++)
                {
                    //if (i * j == 0 || i == _field.Width - 1 || j == _field.Height - 1) _field.Walls.Add(new Wall(i, j, 1));
                    _field.Walls.Add(new Wall(i, j, 1));
                }
            }
        }
        private void UpdateLabel(string labelId, string labelText)
        {
            var label = Controls.Find(labelId, true).FirstOrDefault();
            if (label != null) label.Text = labelText;
        }

        #region Tick Method
        private void globalTimer_Tick(object sender, EventArgs e)
        {
            _draw();
        }
        private void _draw()
        {
            UpdateLabel("xlabel", $"x : {_targetCell.X}");
            UpdateLabel("ylabel", $"y : {_targetCell.Y}");

            _graphicsFore.Clear(Color.Transparent);
            foreach (var obj in _field.GameObjectList())
            {
                if (obj != null) obj.Draw(_graphicsFore, CellWidth, CellHeight);
            }
            Refresh();
        }
        #endregion

        #region JSON Methods

        private void SaveFieldJson(Field field, string fileName)
        {
            var filePath = Environment.CurrentDirectory + @"\" + fileName + ".json";
            var enc = Encoding.GetEncoding("utf-8");

            var output = JsonConvert.SerializeObject(field, Formatting.Indented,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

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

        #region Button Event
        private void newStageBtn_Click(object sender, EventArgs e)
        {
            clearStage();
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Stage Files|*.json";
            openFileDialog1.Title = "Select a Stage File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property. 
                var sr = new StreamReader(openFileDialog1.OpenFile(), Encoding.GetEncoding("utf-8"));
                var input = sr.ReadToEnd();
                sr.Close();
                _field = JsonConvert.DeserializeObject<Field>(
                input, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            }
        }

        private void saveStageBtn_Click(object sender, EventArgs e)
        {
            var folder = Environment.CurrentDirectory;
            var enc = Encoding.GetEncoding("utf-8");

            var output = JsonConvert.SerializeObject(_field, Formatting.Indented,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "custom_stage.json";
            sfd.InitialDirectory = folder;
            sfd.Filter = "JSONファイル(*.json)|*.json";
            sfd.FilterIndex = 1;
            sfd.Title = "保存先のファイルを選択してください";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, output, enc);
            }
        }
        #endregion

        #region Mouse Event
        private void backPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            var cp = backPictureBox.PointToClient(Cursor.Position);
            _targetCell = new Point((int)(cp.X / CellWidth), (int)(cp.Y / CellHeight));
            UpdateLabel("xlabel", $"x : {_targetCell.X}");
            UpdateLabel("ylabel", $"y : {_targetCell.Y}");

            if (_writeFlag) setObject();
        }



        private void objectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void removeObject(int x, int y)
        {
            if (_field.Player != null && _field.Player.X == _targetCell.X && _field.Player.Y == _targetCell.Y) _field.Player = null;
            if (_field.Goal != null && _field.Goal.X == _targetCell.X && _field.Goal.Y == _targetCell.Y) _field.Goal = null;
            _field.Enemies.RemoveAll(item => item.X == _targetCell.X && item.Y == _targetCell.Y);
            _field.Swamps.RemoveAll(item => item.X == _targetCell.X && item.Y == _targetCell.Y);
            _field.Teleporters.RemoveAll(item => item.X == _targetCell.X && item.Y == _targetCell.Y);
            _field.Walls.RemoveAll(item => item.X == _targetCell.X && item.Y == _targetCell.Y);
        }

        private void setObject()
        {
            var item = objectListBox.SelectedItem;
            if (item == null) return;
            var objName = item.ToString();
            var x = _targetCell.X;
            var y = _targetCell.Y;

            var lcc = new lastChangedCell(x, y, objName);
            if (_lcc != null && _lcc == lcc) return;

            _lcc = lcc;

            removeObject(x, y);
            switch (objName)
            {
                case "プレイヤー":
                    _field.Player = new Player(x, y);
                    break;
                case "ゴール":
                    _field.Goal = new Goal(x, y);
                    break;
                case "敵":
                    _field.Enemies.Add(new Enemy(x, y));
                    break;
                case "毒沼":
                    _field.Swamps.Add(new Swamp(x, y));
                    break;
                case "テレポート元":
                    _field.Teleporters.Add(new Teleporter(x, y, _field.Teleporters.Where(w => !w.IsDestination).Count() + 1, false, Types.Direction.None));
                    break;
                case "テレポート先　上":
                    _field.Teleporters.Add(new Teleporter(x, y, _field.Teleporters.Where(w => w.IsDestination).Count() + 1, true, Types.Direction.Up));
                    break;
                case "テレポート先　下":
                    _field.Teleporters.Add(new Teleporter(x, y, _field.Teleporters.Where(w => w.IsDestination).Count() + 1, true, Types.Direction.Down));
                    break;
                case "テレポート先　右":
                    _field.Teleporters.Add(new Teleporter(x, y, _field.Teleporters.Where(w => w.IsDestination).Count() + 1, true, Types.Direction.Right));
                    break;
                case "テレポート先　左":
                    _field.Teleporters.Add(new Teleporter(x, y, _field.Teleporters.Where(w => w.IsDestination).Count() + 1, true, Types.Direction.Left));
                    break;
                case "壁":
                    _field.Walls.Add(new Wall(x, y, 0));
                    break;
                case "白バラ":
                    _field.Walls.Add(new Wall(x, y, 1));
                    break;
                case "赤バラ":
                    _field.Walls.Add(new Wall(x, y, 2));
                    break;
                default:
                    break;
            }
        }

        private void backPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _writeFlag = true;
        }

        private void backPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _writeFlag = false;
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            setObject();
        }

        private void CustomStageForm_Load(object sender, EventArgs e)
        {

        }

        private void backPictureBox_MouseLeave(object sender, EventArgs e)
        {
            _writeFlag = false;
        }
        #endregion


    }
}
