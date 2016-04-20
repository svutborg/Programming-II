using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadFile("test");
        }
        static void ReadFile(string fileName)
        {
            // Exceptions could be thrown in the code below
            try
            {
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                // Exception handler for FileNotFoundException
                // We just inform the user that there is no such file
                Console.WriteLine($"The file '{fileName}' is not found.");
            }
            catch (IOException ioe)
            {
                // Exception handler for other input/output exceptions
                // We just print the stack trace on the console
                Console.WriteLine($"This message is the stack trace:\n{ioe.StackTrace}");
            }
            TextReader reader = null;
try
{
    reader = new StreamReader(fileName);
    string line = reader.ReadLine();
    Console.WriteLine(line);
}
finally
{
    // Always close "reader" (if it was opened)
    if (reader != null)
    {
        reader.Close();
    }
}
        }
    }
}