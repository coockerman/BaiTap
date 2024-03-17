using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_Basic2
{
    internal class Rectangle : Polygon
    {
        private double length;
        private double width;

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Area()
        {
            if (IsCheck())
                return length * width;
            return 0;
        }

        public void Display()
        {
            if(IsCheck())
            {
                Console.WriteLine("Length = " + length);
                Console.WriteLine("Width = " + width);
                Console.WriteLine("Area Rectangle = " + Area());
                Console.WriteLine("Perimeter Rectangle = " + Perimeter());
                Console.WriteLine();
            }else
            {
                Console.WriteLine("Ko hop le");
            }
            
        }

        public bool IsCheck()
        {
            if (length <= 0 || width <= 0) return false;
            return true;
        }

        public double Perimeter()
        {
            if (IsCheck())
                return (length + width) * 2;
            return 0;
        }

        
    }
}
