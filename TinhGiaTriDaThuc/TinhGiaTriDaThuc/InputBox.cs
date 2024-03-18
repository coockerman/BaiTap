using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhGiaTriDaThuc
{
    public partial class InputBox : Form
    {
        public DialogResult MyDialogResult { get; set; }
        public InputBox()
        {
            InitializeComponent();
        }

        // Cập nhật hàm XacNhann để gán giá trị cho MyDialogResult khi form đóng
        private void XacNhann(object sender, EventArgs e)
        {
            TextBox a = new TextBox();
            a.Show();
            this.DialogResult = MyDialogResult;
        }

        
    }

}
