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
        delegate void ThreadDelegate();
        static void Main(string[] args)
        {

            //ThreadDelegate TD = new ThreadDelegate(ThreadMethod);
            //ThreadStart TS = new ThreadStart(TD);

            for (int i = 0; i < 4; i++)
            {
                Thread T = new Thread(ThreadMethod);
                T.Name = String.Format($"T{i}");
                T.IsBackground = true;
                T.Start(100*i);
                if (i==2)
                {
                    T.Priority = ThreadPriority.Lowest;
                }
                else
                {
                    T.Priority = ThreadPriority.AboveNormal;
                }
            }
            
            while(true)
            {
                if(Equals(ConsoleKey.Escape, Console.ReadKey().Key))
                {
                    
                    break;
                }
            }
        }
        static void OtherMethod(string mes)
        {
            Console.WriteLine(mes);
        }

        static void ThreadMethod(object arg)
        {
            int num = (int)arg;
            string name = Thread.CurrentThread.Name;
            int ThreadNumber = int.Parse(name.Substring(1, 1));
            string indent = "";
            for(int i=0;i<ThreadNumber;i++)
            {
                indent += "\t";
            }
            while (true)
            {
                if (num % 100 == 0)
                {
                    Console.WriteLine($"{indent} {name} {num}");
                }
                num++;
                if (num > 10000)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }
    }
}
