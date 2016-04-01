using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace PrimeNumberThreading
{
    public partial class Form1 : Form
    {
        delegate void PrimeDelegate();
        delegate void ListboxAddDelegate(int x);

        public Form1()
        {
            InitializeComponent();
        }

        private void FindPrimeNumbers()
        {
            int num = 2;
            ListboxAddDelegate LBAdd = new ListboxAddDelegate(AddToListbox);

            while(true)
            {
                bool IsPrime = true;
                for(int i = 2; i < num; i++)
                {
                    if(num%i == 0)
                    {
                        IsPrime = false;
                    }
                }
                if (IsPrime)
                {
                    this.Invoke(LBAdd, num);
                }
                num++;
            }
        }

        private void AddToListbox(int item)
        {
            listBox1.Items.Add(item);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrimeDelegate PD = new PrimeDelegate(FindPrimeNumbers);
            ThreadStart TS = new ThreadStart(PD);
            Thread T = new Thread(TS);
            T.IsBackground = true;
            T.Start();
        }

    }
}
