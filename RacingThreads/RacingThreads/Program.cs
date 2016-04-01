using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacingThreads
{
    class Program
    {
        private delegate void ThreadDelegate();

        static void Main(string[] args)
        {
            ThreadDelegate TD = new ThreadDelegate(ThreadMethod);
            ThreadStart TS = new ThreadStart(TD);
            for(int i = 0; i < 10; i++)
            {
                Thread T = new Thread(TS);
                T.Name = string.Format("T{0}", i);
                T.IsBackground = true;
                T.Start();
            }

            while (!(Console.ReadKey().Key == ConsoleKey.Escape)) ;

        }

        static void ThreadMethod()
        {
            int ID = int.Parse(Thread.CurrentThread.Name.Substring(1));
            string tabs = "";
            for (int i = 0; i < ID; i++)
            {
                tabs += "   ";
            }
            while(true)
            {
                Console.WriteLine(string.Format("{0}{1}",tabs,Thread.CurrentThread.Name));
            }
        }
    }
}
