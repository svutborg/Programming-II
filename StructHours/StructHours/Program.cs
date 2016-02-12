using System;

namespace StructHours
{
    struct Hours
    {
        int hours;
        int minutes;
        int seconds;

        public Hours(int hh, int mm, int ss)
        {
            hours = hh + mm/60;
            minutes = mm%60 + ss/60;
            seconds = ss%60;
        }

        public override string ToString()
        {
            return string.Format("{0,2:00}:{1,2:00}:{2,2:00}", hours, minutes, seconds);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hours time = new Hours(40, 62, 26);

            Console.WriteLine(time.ToString());
            Console.Read();
        }
    }
}
