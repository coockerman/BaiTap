using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_Basic2
{
    internal class TriAngle : Polygon
    {
        private double a;
        private double b;
        private double c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public TriAngle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            if (IsCheck())
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                return 0;
            }
        }

        public void Display()
        {
            if(IsCheck())
            {
                Console.WriteLine("edge 1 = " + a);
                Console.WriteLine("edge 2 = " + b);
                Console.WriteLine("edge 3 = " + c);
                Console.WriteLine("Area TriAngle = " + Area());
                Console.WriteLine("Perimeter TriAngle = " + Perimeter());
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ko hop le");
            }
            
        }

        public bool IsCheck()
        {
            if (a <= 0 || b <= 0 || c <= 0 || (a + b) < c || (b+c) < a || (a+c) < b)
            {
                return false;
            }
            return true;
        }

        public double Perimeter()
        {
            if (IsCheck())
                return a + b + c;
            return 0;
        }
    }
}
