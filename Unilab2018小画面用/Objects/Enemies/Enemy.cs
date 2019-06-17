using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unilab2018.Helpers;

namespace Unilab2018.Objects.Enemies
{
    class Enemy : GameObject
    {
        public Enemy(int x, int y) : base(x, y) => Color = Brushes.Blue;
    }
}
