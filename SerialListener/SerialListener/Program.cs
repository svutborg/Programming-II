using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SerialListener
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            SerialPort SP = null;
            Console.WriteLine("Specify which comport you want to connect to:");
            
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine($"{i++,2} {s}");
            }
            int PortNo = int.Parse(Console.ReadLine());
            try
            {
                SP = new SerialPort(SerialPort.GetPortNames()[PortNo]);
                SP.Open();
                while(true)
                {
                    Console.Write(SP.ReadExisting());
                }
            }
            finally
            {
                if (SP.IsOpen)
                {
                    SP.Close();
                }
            }

            Console.Read();
        }
    }
}
