using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cong(object sender, EventArgs e)
        {
            ComboBoxTT.SelectedIndex = 0;
        }

        private void Tru(object sender, EventArgs e)
        {
            ComboBoxTT.SelectedIndex = 1;
        }

        private void Nhan(object sender, EventArgs e)
        {
            ComboBoxTT.SelectedIndex = 2;
        }

        private void Chia(object sender, EventArgs e)
        {
            ComboBoxTT.SelectedIndex = 3;

        }
        private void TinhToan(int select)
        {
            if (so1.Text == "" || so2.Text == "")
            {
                MessageBox.Show("Điền đầy đủ giá trị");
                return;
            }

            double a, b, c = 0;
            string dau = "";
            double.TryParse(so1.Text, out a);
            double.TryParse(so2.Text, out b);
            switch (select)
            {
                case 0:
                    c = a + b;
                    dau = " + ";
                    break;
                case 1:
                    c = a - b;
                    dau = " - ";
                    break;
                case 2:
                    c = a * b;
                    dau = " * ";
                    break;
                case 3:
                    c = a / b;
                    dau = " / ";
                    break;
            }
            result.Text = so1.Text + dau + so2.Text + " = " + c.ToString();
        }

        private void deletee(object sender, EventArgs e)
        {
            so1.Clear();
            so2.Clear();
            result.Clear();
        }

        private void ComboTinhToan(object sender, EventArgs e)
        {
            if(ComboBoxTT.SelectedIndex == 0)
            {
                TinhToan(0);
            }else if(ComboBoxTT.SelectedIndex == 1)
            {
                TinhToan(1);
            }
            else if (ComboBoxTT.SelectedIndex == 2)
            {
                TinhToan(2);
            }
            else if (ComboBoxTT.SelectedIndex == 3)
            {
                TinhToan(3);
            }
        }

        private void End(object sender, EventArgs e)
        {
            this.Close();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
