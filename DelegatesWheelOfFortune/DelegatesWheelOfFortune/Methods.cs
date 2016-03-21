using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWheelOfFortune
{
    class Methods
    {
        private delegate int RandomMethodDelegate(int a, int b);
        List<RandomMethodDelegate> MathMethods = new List<RandomMethodDelegate>();
        RandomMethodDelegate ActiveMethod ;
        Random R;

        public Methods()
        {
            MathMethods.Add(new RandomMethodDelegate(Sum));
            MathMethods.Add(new RandomMethodDelegate(Sub));
            MathMethods.Add(new RandomMethodDelegate(Mul));
            MathMethods.Add(new RandomMethodDelegate(Div));
            MathMethods.Add(new RandomMethodDelegate(Mod));
            R = new Random();
        }

        public string ReturnActiveMethod()
        {
            return ActiveMethod.Method.Name;
        }

        public int RandomMethod(int a, int b)
        {
            ActiveMethod = MathMethods[R.Next(0, 4)];
            return ActiveMethod(a, b);
        }

        private int Sum(int x, int y)
        {
            return x + y;
        }
        private int Sub(int x, int y)
        {
            return x - y;
        }
        private int Mul(int x, int y)
        {
            return x * y;
        }
        private int Div(int x, int y)
        {
            return x / y;
        }
        private int Mod(int x, int y)
        {
            return x % y;
        }
    }
}
