using System;

namespace window2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.so1 = new System.Windows.Forms.TextBox();
            this.so2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.cong = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.ComboBoxTT = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KetThuc = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(387, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình máy tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(9, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // so1
            // 
            this.so1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.so1.Location = new System.Drawing.Point(220, 61);
            this.so1.Margin = new System.Windows.Forms.Padding(5);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(395, 48);
            this.so1.TabIndex = 4;
            // 
            // so2
            // 
            this.so2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.so2.Location = new System.Drawing.Point(219, 164);
            this.so2.Margin = new System.Windows.Forms.Padding(5);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(395, 48);
            this.so2.TabIndex = 5;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.result.Location = new System.Drawing.Point(219, 266);
            this.result.Margin = new System.Windows.Forms.Padding(5);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(395, 48);
            this.result.TabIndex = 6;
            // 
            // cong
            // 
            this.cong.BackColor = System.Drawing.Color.Wheat;
            this.cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cong.Location = new System.Drawing.Point(31, 36);
            this.cong.Margin = new System.Windows.Forms.Padding(5);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(131, 46);
            this.cong.TabIndex = 7;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = false;
            this.cong.Click += new System.EventHandler(this.Cong);
            // 
            // tru
            // 
            this.tru.BackColor = System.Drawing.Color.Wheat;
            this.tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tru.Location = new System.Drawing.Point(31, 110);
            this.tru.Margin = new System.Windows.Forms.Padding(5);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(131, 46);
            this.tru.TabIndex = 8;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = false;
            this.tru.Click += new System.EventHandler(this.Tru);
            // 
            // nhan
            // 
            this.nhan.BackColor = System.Drawing.Color.Wheat;
            this.nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.nhan.Location = new System.Drawing.Point(31, 189);
            this.nhan.Margin = new System.Windows.Forms.Padding(5);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(131, 46);
            this.nhan.TabIndex = 9;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = false;
            this.nhan.Click += new System.EventHandler(this.Nhan);
            // 
            // chia
            // 
            this.chia.BackColor = System.Drawing.Color.Wheat;
            this.chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chia.Location = new System.Drawing.Point(31, 268);
            this.chia.Margin = new System.Windows.Forms.Padding(5);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(131, 46);
            this.chia.TabIndex = 10;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = false;
            this.chia.Click += new System.EventHandler(this.Chia);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.xoa.Location = new System.Drawing.Point(158, 506);
            this.xoa.Margin = new System.Windows.Forms.Padding(5);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(141, 59);
            this.xoa.TabIndex = 11;
            this.xoa.Text = "Xoá";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.deletee);
            // 
            // ComboBoxTT
            // 
            this.ComboBoxTT.FormattingEnabled = true;
            this.ComboBoxTT.Items.AddRange(new object[] {
            "Cộng",
            "Trừ",
            "Nhân",
            "Chia"});
            this.ComboBoxTT.Location = new System.Drawing.Point(798, 122);
            this.ComboBoxTT.Name = "ComboBoxTT";
            this.ComboBoxTT.Size = new System.Drawing.Size(160, 37);
            this.ComboBoxTT.TabIndex = 12;
            this.ComboBoxTT.Text = "Phép tính";
            this.ComboBoxTT.SelectedIndexChanged += new System.EventHandler(this.ComboTinhToan);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cong);
            this.groupBox1.Controls.Add(this.tru);
            this.groupBox1.Controls.Add(this.nhan);
            this.groupBox1.Controls.Add(this.chia);
            this.groupBox1.Location = new System.Drawing.Point(1041, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 352);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.so2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Controls.Add(this.so1);
            this.groupBox2.Location = new System.Drawing.Point(89, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 373);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // KetThuc
            // 
            this.KetThuc.BackColor = System.Drawing.Color.IndianRed;
            this.KetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.KetThuc.Location = new System.Drawing.Point(1049, 569);
            this.KetThuc.Margin = new System.Windows.Forms.Padding(5);
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.Size = new System.Drawing.Size(161, 59);
            this.KetThuc.TabIndex = 15;
            this.KetThuc.Text = "Kết thúc";
            this.KetThuc.UseVisualStyleBackColor = false;
            this.KetThuc.Click += new System.EventHandler(this.End);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cộng",
            "Trừ",
            "Nhân",
            "Chia"});
            this.checkedListBox1.Location = new System.Drawing.Point(775, 356);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(221, 132);
            this.checkedListBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1245, 652);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.KetThuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboBoxTT);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox so1;
        private System.Windows.Forms.TextBox so2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.ComboBox ComboBoxTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button KetThuc;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

