using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Draw
{
    class Rect
    {
        private int width;
        private int height;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get { return width; } set { width = value; CalcArea(value, height); } }
        public int Height { get { return height; } set { height = value; CalcArea(width, value); } }
        public int Area { get; private set; }
        public int Circumference { get; private set; }

        private void CalcArea(int width = 0, int height = 0)
        {
            Area = width * height;
        }

        private void CalcCirc(int width, int height)
        {
            Circumference = 2 * width * 2 * height;
        }

        public Rect(): this(0,0,0,0)
        {

        }

        public Rect(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public void DrawRectangle(Pen pen, Panel canvas)
        {
            Graphics g = canvas.CreateGraphics();
            g.DrawRectangle(pen, new Rectangle(X, Y, Width, Height));
            g.Dispose();
            pen.Dispose();
        }
    }
}
