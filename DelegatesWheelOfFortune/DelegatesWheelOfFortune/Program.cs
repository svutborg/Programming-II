using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWheelOfFortune
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Hello ");
            Methods met = new Methods();
            while(true)
            {
                Console.WriteLine("type in two integer numbers:");
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Result was: {met.RandomMethod(num1, num2)}");
                    Console.WriteLine($"Method used: {met.ReturnActiveMethod()}");
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Invalid entry");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Not a number");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Number was to large");
                }
            }
        }
    }
}
