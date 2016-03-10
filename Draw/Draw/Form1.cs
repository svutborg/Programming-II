using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class mainForm : Form
    {
        BindingList<Rect> Rects = new BindingList<Rect>();
        
        public mainForm()
        {
            InitializeComponent();
            Rects.Add(new Rect(1, 2, 3, 4));
            shapeDataGridView.DataSource = Rects;
            shapeDataGridView.Columns["X"].Visible = false;
            shapeDataGridView.Columns["Y"].Visible = false;
        }


    }
}
