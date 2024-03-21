using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NhapSanPham
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }



        private void NhapSP(object sender, EventArgs e)
        {
            if(txtMaSP.Text != "" && txtName.Text != "" && txtFrom.Text !="" && txtYear.Text !="")
            {
                string masp = txtMaSP.Text;
                string namesp = txtName.Text;
                string fromsp = txtFrom.Text;
                string yearsp = txtYear.Text;
                Product product = new Product(masp, namesp, fromsp, yearsp);
                products.Add(product);
                HienThi();
                HienThiBefore();
            }
            else
            {
                MessageBox.Show("Điền đủ thông tin");
            }
            
        }
        private void HienThi()
        {
            listViewAll.Items.Clear();
            listViewBefore.Items.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(products[i].MaSP);
                lvi.SubItems.Add(products[i].NameSP);
                lvi.SubItems.Add(products[i].FromSP);
                lvi.SubItems.Add(products[i].YearSP);

                listViewAll.Items.Add(lvi);
                listViewAll.CheckBoxes = true;
                
            }
        }
        private void HienThiBefore()
        {
            listViewBefore.Items.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(products[i].MaSP);
                lvi.SubItems.Add(products[i].NameSP);
                lvi.SubItems.Add(products[i].FromSP);
                lvi.SubItems.Add(products[i].YearSP);
                
                int t = 0;
                int.TryParse(products[i].YearSP.ToString(), out t);
                if (t < 2000)
                {
                    listViewBefore.Items.Add(lvi);
                    listViewBefore.CheckBoxes = true;
                
                }
            }
        }
        private void ChonSanPham(object sender, EventArgs e)
        {
            for(int i = 0; i < products.Count;i++)
            {
                listViewAll.Items[i].Checked = true;
            }
            
        }

        
        private void Defeat(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }
    }
}
