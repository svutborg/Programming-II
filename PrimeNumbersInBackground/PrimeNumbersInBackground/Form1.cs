using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbersInBackground
{
    public partial class Form1 : Form
    {
        //delegate void PrimeDelegate();
        //delegate void AddderDelegate(int i);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PrimeDelegate PD = new PrimeDelegate(CalcPrimes);
            //ThreadStart TS = new ThreadStart(PD);
            //Thread T = new Thread(TS);
            Thread T = new Thread(CalcPrimes);
            T.Name = "PrimeNumberThread";
            T.IsBackground = true;
            T.Start();
        }

        void LineAdder(int num)
        {
            listBox1.Items.Add(num);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        void CalcPrimes(object param)
        {
            //AddderDelegate AddLine = new AddderDelegate(LineAdder);
            int number = 2;
            while (true)
            {
                bool IsPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        IsPrime = false;
                    }
                }
                if (IsPrime)
                {
                    try
                    {
                        //this.Invoke(AddLine, number);
                        this.Invoke((MethodInvoker)delegate {
                            listBox1.Items.Add(number);
                            listBox1.TopIndex = listBox1.Items.Count - 1;
                        });
                    }
                    catch(ObjectDisposedException)
                    {
                        MessageBox.Show("Thread aborting");
                        Thread.CurrentThread.Abort();
                    }
                }
                number++;
            }
        }
    }
}
