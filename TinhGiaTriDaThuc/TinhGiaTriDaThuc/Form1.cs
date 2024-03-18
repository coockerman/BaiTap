using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhGiaTriDaThuc
{
    public partial class Form1 : Form
    {
        int bac = 0;
        int X = 0;
        int sttHeSo = 0;
        List<int> listHeSo = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void NhapBac(object sender, EventArgs e)
        {
            bac = int.Parse(inputBac.Text.ToString());
            textBac.Text = "Đa thức bậc: " + bac;
        }

        private void NhapX(object sender, EventArgs e)
        {
            X = int.Parse(inputX.Text.ToString());
            textX.Text = "X = " + X;
        }

        private void NhapHeSo(object sender, EventArgs e)
        {
            if (bac == 0) return;
            sttHeSo++;
            if (sttHeSo > bac) return;

            textHeSo.Text = "Hệ số thứ: " + (sttHeSo);
            int t = int.Parse(inputHeSo.Text.ToString());
            inputHeSo.Text = "";


            listHeSo.Add(t);
            HienThi();
        }
        private void HienThi()
        {
            string t = "";
            for(int i = 0; i < listHeSo.Count; i++)
            {
                t = "";
                t += "a" + i + "=" + listHeSo[i] + " \n  ";
            }
            box.Text += t;
        }

        private void NhapDang(object sender, EventArgs e)
        {
            string t = "P(x)=";
            for (int i = 0; i < listHeSo.Count; i++)
            {
                t += listHeSo[i] + "x^" + (listHeSo.Count - i - 1);
                if(i < listHeSo.Count - 1)
                {
                    if (listHeSo[i+1] > 0)
                    {
                        t += "+";
                    }
                }
            }
            textDang.Text = t;
        }

        private void TinhResult(object sender, EventArgs e)
        {
            int t = 0;
            for (int i = 0; i < listHeSo.Count; i++)
            {
                double b = Math.Pow(X, (listHeSo.Count - i-1));
                int a = (int)b;
                t += listHeSo[i] * a;
            }
            textResult.Text = "P(x)=" + t;
        }
    }
}
