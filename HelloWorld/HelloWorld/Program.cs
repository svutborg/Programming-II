using System;

namespace HelloWorld
{
    class Program
    {
        static void Say(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Say("Hello World!");
            Console.Read();
        }
    }
}
