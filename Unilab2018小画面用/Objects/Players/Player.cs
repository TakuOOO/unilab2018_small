using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unilab2018.Helpers;
using static Unilab2018.Helpers.Types;

namespace Unilab2018.Objects.Player
{
    class Player : GameObject
    {
        public Player(int x, int y) : base(x, y)
        {
            Bitmaps[(int)Direction.None] = GetBitmap("Player_None.jpg");
            Bitmaps[(int)Direction.Up] = GetBitmap("Player_Up.jpg");
            Bitmaps[(int)Direction.Down] = GetBitmap("Player_Down.jpg");
            Bitmaps[(int)Direction.Right] = GetBitmap("Player_Right.jpg");
            Bitmaps[(int)Direction.Left] = GetBitmap("Player_Left.jpg");
        }

        public override void Draw(Graphics graphics, float width, float height)
        {
            if (!IsAlive) return;
            graphics.DrawImage(Bitmaps[(int)Direction], X * width, Y * height, width, height);
        }
    }
}
