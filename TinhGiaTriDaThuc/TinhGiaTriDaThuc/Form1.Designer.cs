namespace TinhGiaTriDaThuc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBac = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textHeSo = new System.Windows.Forms.Label();
            this.inputHeSo = new System.Windows.Forms.TextBox();
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputBac = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.textDang = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính giá trị của đa thức bậc n";
            // 
            // textBac
            // 
            this.textBac.AutoSize = true;
            this.textBac.Location = new System.Drawing.Point(22, 32);
            this.textBac.Name = "textBac";
            this.textBac.Size = new System.Drawing.Size(95, 20);
            this.textBac.TabIndex = 1;
            this.textBac.Text = "Đa thức bậc";
            // 
            // textX
            // 
            this.textX.AutoSize = true;
            this.textX.Location = new System.Drawing.Point(22, 125);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(33, 20);
            this.textX.TabIndex = 2;
            this.textX.Text = "X =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhập bậc của đa thức";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NhapBac);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textHeSo);
            this.groupBox1.Controls.Add(this.inputHeSo);
            this.groupBox1.Controls.Add(this.inputX);
            this.groupBox1.Controls.Add(this.inputBac);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.box);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBac);
            this.groupBox1.Controls.Add(this.textX);
            this.groupBox1.Location = new System.Drawing.Point(32, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textHeSo
            // 
            this.textHeSo.AutoSize = true;
            this.textHeSo.Location = new System.Drawing.Point(22, 214);
            this.textHeSo.Name = "textHeSo";
            this.textHeSo.Size = new System.Drawing.Size(86, 20);
            this.textHeSo.TabIndex = 10;
            this.textHeSo.Text = "Hệ số thứ: ";
            // 
            // inputHeSo
            // 
            this.inputHeSo.Location = new System.Drawing.Point(256, 252);
            this.inputHeSo.Multiline = true;
            this.inputHeSo.Name = "inputHeSo";
            this.inputHeSo.Size = new System.Drawing.Size(100, 32);
            this.inputHeSo.TabIndex = 9;
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(256, 159);
            this.inputX.Multiline = true;
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(100, 32);
            this.inputX.TabIndex = 8;
            // 
            // inputBac
            // 
            this.inputBac.Location = new System.Drawing.Point(256, 69);
            this.inputBac.Multiline = true;
            this.inputBac.Name = "inputBac";
            this.inputBac.Size = new System.Drawing.Size(100, 32);
            this.inputBac.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Nhập các hệ số";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NhapHeSo);
            // 
            // box
            // 
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.box.Location = new System.Drawing.Point(419, 32);
            this.box.Multiline = true;
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(553, 270);
            this.box.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nhập X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NhapX);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textResult);
            this.groupBox2.Controls.Add(this.textDang);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(37, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 227);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textResult.Location = new System.Drawing.Point(302, 132);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(540, 46);
            this.textResult.TabIndex = 3;
            // 
            // textDang
            // 
            this.textDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textDang.Location = new System.Drawing.Point(302, 54);
            this.textDang.Multiline = true;
            this.textDang.Name = "textDang";
            this.textDang.Size = new System.Drawing.Size(540, 46);
            this.textDang.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "Kết quả";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.TinhResult);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 38);
            this.button4.TabIndex = 0;
            this.button4.Text = "Dạng của đa thức";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NhapDang);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 699);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textBac;
        private System.Windows.Forms.Label textX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textDang;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label textHeSo;
        private System.Windows.Forms.TextBox inputHeSo;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputBac;
    }
}

