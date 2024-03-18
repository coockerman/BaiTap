using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaySo7MayMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QuaySoMM(object sender, EventArgs e)
        {
            int a, b, c, tien = 0;
            string ketqua;
            Random rnd = new Random();

            a = rnd.Next(10);
            b = rnd.Next(10);
            c = rnd.Next(10);
            Oso1.Text = a.ToString();
            Oso2.Text = b.ToString();
            Oso3.Text = c.ToString();
            
            if(a == 7)
                tien += 100;
            if (b == 7)
                tien += 50;
            if (c == 7)
                tien += 10;

            if(tien > 0)
            {
                ketqua = "Tổng số tiền bạn nhận được là: " + tien.ToString() + " dong";
                MessageBox.Show(ketqua, "Ket qua");
            }
            
            
        }

        private void Oso2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnSupport(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
