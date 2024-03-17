using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maytinhcamtay1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnChia(object sender, EventArgs e)
        {
            if (so1 == null || so2 == null) return;
            double a, b, c;
            double.TryParse(so1.Text, out a);
            double.TryParse(so2.Text, out b);
            c = a / b;
            result.Text = c.ToString();
        }

        private void btnNhan(object sender, EventArgs e)
        {
            if (so1 == null || so2 == null) return;
            double a, b, c;
            double.TryParse(so1.Text, out a);
            double.TryParse(so2.Text, out b);
            c = a * b;
            result.Text = c.ToString();
        }

        private void btnTru(object sender, EventArgs e)
        {
            if (so1 == null || so2 == null) return;
            double a, b, c;
            double.TryParse(so1.Text, out a);
            double.TryParse(so2.Text, out b);
            c = a - b;
            result.Text = c.ToString();
        }

        private void btnCong(object sender, EventArgs e)
        {
            if (so1 == null || so2 == null) return;
            double a, b, c;
            double.TryParse(so1.Text, out a);
            double.TryParse(so2.Text, out b);
            c = a + b;
            result.Text = c.ToString();
        }

        private void btnXoa(object sender, EventArgs e)
        {
            so1.Text = "";
            so2.Text = "";
            result.Text = "";
        }
        private string TinhToan(int select)
        {
            if (so1 == null || so2 == null) return "";
            double a, b, c;
            string dau;
            double.TryParse(so1.Text, out a);
            double.TryParse(so2.Text, out b);
            switch (select)
            {
                case 0:
                    c = a + b;
                    dau = " + ";
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            } 
                
            return "";
        }
        private void btnEnd(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }

    }
}
