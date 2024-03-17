using System;
//class 1 name point
//class 2 ke thua point name circle
//class 3 ke thua circle name hinh tru

namespace LearnC_Basic
{
    internal class Circle : Point
    {
        private double r;
        public Circle(int x, int y, double radius) : base(x, y)
        {
            this.r = radius;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Bán kính: " + r);
        }
        protected virtual bool isCheck()
        {
            return r > 0;
        }
        protected virtual double AreaCircle()
        {
            return Math.Round( r * r * Math.PI, 2);
        }
        protected virtual double ParimeterCircle()
        {
            return Math.Round( r * 2 * Math.PI, 2);
        }
    }
}
