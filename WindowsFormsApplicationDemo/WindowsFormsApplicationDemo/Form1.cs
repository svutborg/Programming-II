using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationDemo
{
    public partial class Form1 : Form
    {
        Point startPoint;
        Pen myPen = new Pen(Color.Black);
        Graphics g; 
        BindingList<Rectangle> rects = new BindingList<Rectangle>();
        Rectangle activeRect;
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
                        
            rectDataGridView.DataSource = rects;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint.X = e.X;
            startPoint.Y = e.Y;
            activeRect.X = e.X;
            activeRect.Y = e.Y;
            drawing = true;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                activeRect.Width = Math.Abs(e.X - activeRect.X);
                activeRect.Height = Math.Abs(e.Y - activeRect.Y);
                rects.Add(activeRect);
                drawing = false;

            }
        }

        private void updateRect()
        {
            activeRect.Width = Math.Abs(MousePosition.X - activeRect.X);
            activeRect.Height = Math.Abs(MousePosition.Y - activeRect.Y);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                g.Clear(canvas.BackColor);
                int difX = e.X - startPoint.X;
                int difY = e.Y - startPoint.Y;
                if (difX < 0)
                {
                    activeRect.X = e.X;
                    activeRect.Width = -difX;
                }
                else
                {
                    activeRect.Width = difX;
                }
                if (difY < 0)
                {
                    activeRect.Y = e.Y;
                    activeRect.Height = -difY;
                }
                else
                {
                    activeRect.Height = difY;
                }
                g.DrawRectangle(myPen, activeRect);
                if (rects.Count > 0)
                {
                    g.DrawRectangles(myPen, rects.ToArray());
                }
            }
        }
    }
}
