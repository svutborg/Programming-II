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
        private delegate void pnThread();
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart TS = new ThreadStart(primenumbers);
            th = new Thread(TS);
            th.Start();
        }
        
        private void primeThread()
        {
            pnThread pn = new pnThread(primenumbers);
            this.Invoke(pn);
        }

        private void primenumbers()
        {
            int i, number = 2;
            bool prime;
            listBox1.Items.Clear();
            while (number < 10000)
            {
                prime = true;
                for (i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    listBox1.Items.Add(number);
                }
                number++;
            }
        }
    }
}
