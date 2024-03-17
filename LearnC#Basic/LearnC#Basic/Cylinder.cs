using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_Basic
{
    internal class Cylinder : Circle
    {
        private float h;

        public Cylinder(int x, int y, double radius, float height) : base(x, y, radius)
        {
            this.h = height;
        }
        protected override bool isCheck()
        {
            if (base.isCheck() && h > 0)
            {
                return true;
            }
            return false;
        }
        public override void Display()
        {
            if (this.isCheck())
            {
                base.Display();
                Console.WriteLine("Chiều cao: " + h);
                Console.WriteLine("Dien tich xung quanh: " + DienTichXungQuanhCylinder());
                Console.WriteLine("Dien tich toan phan: " + DienTichToanPhanCylinder());
                Console.WriteLine("The tich: " + TheTichCylinder());
            }
            else
            {
                Console.WriteLine("Hình không hợp lệ");
            }

        }

        private double DienTichXungQuanhCylinder()
        {
            if (this.isCheck())
                return Math.Round(ParimeterCircle() * h, 2);
            else
                return 0;
        }
        private double DienTichToanPhanCylinder()
        {
            if (this.isCheck())
                return Math.Round(DienTichXungQuanhCylinder() + 2 * AreaCircle());
            else
                return 0;
        }
        private double TheTichCylinder()
        {
            if (this.isCheck())
                return Math.Round(AreaCircle() * h, 2);
            else
                return 0;
        }
    }
}
