using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public struct EndPoints
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public EndPoints(Point startPoint, Point endPoint)
        {
            Start = startPoint;
            End = endPoint;
        }
    }
    public partial class Form1 : Form
    {
        BindingList<EndPoints> Points = new BindingList<EndPoints>();
        Graphics G;
        Graphics H;
        Pen myPen = new Pen(Color.Black);
        Point StartPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();

            H = panel1.CreateGraphics();
            G = panel1.CreateGraphics();
            dataGridView1.DataSource = Points;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            Point P1 = new Point(R.Next(0, panel1.Width), R.Next(0, panel1.Height));
            Point P2 = new Point(R.Next(0, panel1.Width), R.Next(0, panel1.Height));
            Points.Add(new EndPoints(P1, P2));
            panel1_Paint(null, null);          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            G.Clear(Color.White);
            foreach (EndPoints p in Points)
            {
                G.DrawLine(myPen, p.Start, p.End);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            panel1_Paint(null, null);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Points.Add(new EndPoints(StartPoint, new Point(e.X, e.Y)));
            panel1_Paint(null, null);
            StartPoint = Point.Empty;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(!StartPoint.IsEmpty)
            {
                panel1_Paint(null, null);
                G.DrawLine(myPen, StartPoint, new Point(e.X, e.Y));
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
