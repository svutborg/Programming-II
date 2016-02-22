using System;

namespace CircleObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            Console.WriteLine(C1.Area);

            Console.WriteLine($"Number of objects {Circle.CircleCounter}");

            C1.Radius = 4;
            Console.WriteLine(C1.Area);

            Circle C2 = new Circle();
            Console.WriteLine($"Number of objects {Circle.CircleCounter}");

            Console.Read();
        }
    }
}
