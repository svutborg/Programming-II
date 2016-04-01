using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWheelOfFortune
{
    class Program
    {
        private delegate int MathDelegate(int a, int b);

        static void Main(string[] args)
        {
            int num1, num2;
            Random R = new Random();
            List<MathDelegate> MathMethods = new List<MathDelegate>();
            MathMethods.Add(new MathDelegate(Add));
            MathMethods.Add(new MathDelegate(Sub));
            MathMethods.Add(new MathDelegate(Mul));
            MathMethods.Add(new MathDelegate(Div));
            MathMethods.Add(new MathDelegate(Mod));

            while(true)
            {
                Console.WriteLine("Enter two numbers:");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(MathMethods[R.Next(0,MathMethods.Count-1)](num1, num2));
            }
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Sub(int x, int y)
        {
            return x - y;
        }

        private static int Mul(int x, int y)
        {
            return x * y;
        }

        private static int Div(int x, int y)
        {
            return x / y;
        }

        private static int Mod(int x, int y)
        {
            return x % y;
        }
    }
}
