using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObject
{
    class Circle
    {
        int radius;
        double circumference;
        double area;

        static public int CircleCounter
        {
            get; private set;
        }

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                circumference = 2 * Math.PI * radius;
                area = Math.PI * radius * radius;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

        public Circle()
        {
            radius = 0;
            circumference = 0;
            area = 0;
            CircleCounter++;
        }

        public Circle(int r)
        {
            radius = r;
            circumference = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;
            CircleCounter++;
        }
    }
}
