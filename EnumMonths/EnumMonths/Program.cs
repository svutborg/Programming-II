using System;

namespace EnumMonths
{
    class Program
    {
        enum Months { January, February, Martch, April, May, June,
            July, August, September, October, November, December};

        static void Main(string[] args)
        {
            foreach(string m in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine(m);
            }
            Console.Read();
        }
    }
}
