using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using Unilab2018.Helpers;

namespace Unilab2018.Objects
{
    class GameObject
    {
        private int x, y;
        public int X
        {
            get => x;
            set
            {
                if (value == x + 1) Direction = Types.Direction.Right;
                else if (value == x - 1) Direction = Types.Direction.Left;
                x = value;
            }
        }
        public int Y
        {
            get => y;
            set
            {
                if (value == y + 1) Direction = Types.Direction.Down;
                else if (value == y - 1) Direction = Types.Direction.Up;
                y = value;
            }
        }
        public Types.Direction Direction { get; set; }
        [JsonIgnore]
        public virtual bool IsAlive { get; set; } = true;
        [JsonIgnore]
        public virtual bool CanMove { get; } = true;
        public Brush Color { get; set; } = Brushes.Red;
        public int HP { get; set; }
        public int MaxHP { get; set; }

        [JsonIgnore]
        public int Pedometer { get; set; } // 歩数計

        public int DesiredPedometer { get; set; } // 歩数の目標値

        [JsonIgnore]
        public Bitmap[] Bitmaps { get; private set; } = new Bitmap[Enum.GetNames(typeof(Types.Direction)).Length];

        /// <summary>
        /// Initialize GameObject
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <param name="sizes">size</param>
        public GameObject(int x, int y)
        {
            X = x;
            Y = y;
            Direction = Types.Direction.None;
        }

        public void Die() => IsAlive = false;

        public bool Intersect(GameObject obj) => X == obj.X && Y == obj.Y;

        public virtual void Draw(Graphics graphics, float width, float height)
        {
            if (!IsAlive) return;
            graphics.FillRectangle(Color, X * width, Y * height, width, height);
            switch (Direction)
            {
                case Types.Direction.Right:
                    graphics.FillRectangle(Brushes.Black, (4 * X + 3) * width / 4, Y * height, width / 4, height);
                    break;
                case Types.Direction.Left:
                    graphics.FillRectangle(Brushes.Black, X * width, Y * height, width / 4, height);
                    break;
                case Types.Direction.Up:
                    graphics.FillRectangle(Brushes.Black, X * width, Y * height, width, height / 4);
                    break;
                case Types.Direction.Down:
                    graphics.FillRectangle(Brushes.Black, X * width, (4 * Y + 3) * height / 4, width, height / 4);
                    break;
                default:
                    break;
            }
        }

        public Bitmap GetBitmap(string name)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("Unilab2018.Images." + name);
            Bitmap bmp = new Bitmap(stream);
            return bmp;
        }

        public void Move()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    break;

                case Types.Direction.Up:
                    Y--;
                    break;

                case Types.Direction.Down:
                    Y++;
                    break;

                case Types.Direction.Right:
                    X++;
                    break;

                case Types.Direction.Left:
                    X--;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    break;

                case Types.Direction.Up:
                    Direction = Types.Direction.Right;
                    break;

                case Types.Direction.Down:
                    Direction = Types.Direction.Left;
                    break;

                case Types.Direction.Right:
                    Direction = Types.Direction.Down;
                    break;

                case Types.Direction.Left:
                    Direction = Types.Direction.Up;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    break;

                case Types.Direction.Up:
                    Direction = Types.Direction.Left;
                    break;

                case Types.Direction.Down:
                    Direction = Types.Direction.Right;
                    break;

                case Types.Direction.Right:
                    Direction = Types.Direction.Up;
                    break;

                case Types.Direction.Left:
                    Direction = Types.Direction.Down;
                    break;
            }
        }

        #region 一人称視点で見た時の前後左右の座標
        public int ForwardX()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    return X;
                case Types.Direction.Up:
                    return X;
                case Types.Direction.Down:
                    return X;
                case Types.Direction.Right:
                    return X + 1;
                case Types.Direction.Left:
                    return X - 1;
            }
        }

        public int ForwardY()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    return Y;
                case Types.Direction.Up:
                    return Y - 1;
                case Types.Direction.Down:
                    return Y + 1;
                case Types.Direction.Right:
                    return Y;
                case Types.Direction.Left:
                    return Y;
            }
        }

        public int BackX()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    return X;
                case Types.Direction.Up:
                    return X;
                case Types.Direction.Down:
                    return X;
                case Types.Direction.Right:
                    return X - 1;
                case Types.Direction.Left:
                    return X + 1;
            }
        }

        public int BackY()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    return Y;
                case Types.Direction.Up:
                    return Y + 1;
                case Types.Direction.Down:
                    return Y - 1;
                case Types.Direction.Right:
                    return Y;
                case Types.Direction.Left:
                    return Y;
            }
        }

        public int RightX()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    return X;
                case Types.Direction.Up:
                    return X + 1;
                case Types.Direction.Down:
                    return X - 1;
                case Types.Direction.Right:
                    return X;
                case Types.Direction.Left:
                    return X;
            }
        }

        public int RightY()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    return Y;
                case Types.Direction.Up:
                    return Y;
                case Types.Direction.Down:
                    return Y;
                case Types.Direction.Right:
                    return Y + 1;
                case Types.Direction.Left:
                    return Y - 1;
            }
        }

        public int LeftX()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    return X;
                case Types.Direction.Up:
                    return X - 1;
                case Types.Direction.Down:
                    return X + 1;
                case Types.Direction.Right:
                    return X;
                case Types.Direction.Left:
                    return X;
            }
        }

        public int LeftY()
        {
            switch (Direction)
            {
                default:
                case Types.Direction.None:
                    return Y;
                case Types.Direction.Up:
                    return Y;
                case Types.Direction.Down:
                    return Y;
                case Types.Direction.Right:
                    return Y - 1;
                case Types.Direction.Left:
                    return Y + 1;
            }
        }
#endregion
    }
}