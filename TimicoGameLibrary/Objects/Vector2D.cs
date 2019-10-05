using System;
using System.Collections.Generic;
using System.Text;

namespace TimicoGameLibrary.Objects
{
    public class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
