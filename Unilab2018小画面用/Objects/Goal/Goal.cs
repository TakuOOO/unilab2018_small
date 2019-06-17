using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unilab2018.Helpers;

namespace Unilab2018.Objects.Goal
{
    class Goal : GameObject
    {
        public override bool CanMove { get; } = false;
        public Goal(int x, int y) : base(x, y)
        {
            for (int i = 0; i < Bitmaps.Length; i++)
            {
                Bitmaps[i] = GetBitmap("Goal.jpg");
            }
        }

        public override void Draw(Graphics graphics, float width, float height)
        {
            if (!IsAlive) return;
            graphics.DrawImage(Bitmaps[(int)Direction], X * width, Y * height, width, height);
        }
    }
}
