namespace maytinhcamtay1
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
            this.xoa = new System.Windows.Forms.Button();
            this.cong = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(234, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình máy tính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // so1
            // 
            this.so1.Location = new System.Drawing.Point(262, 120);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(217, 26);
            this.so1.TabIndex = 4;
            // 
            // so2
            // 
            this.so2.Location = new System.Drawing.Point(262, 172);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(217, 26);
            this.so2.TabIndex = 5;
            this.so2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(262, 224);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(217, 26);
            this.result.TabIndex = 6;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(262, 281);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(79, 33);
            this.xoa.TabIndex = 7;
            this.xoa.Text = "Xoá";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.btnXoa);
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(562, 120);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(75, 31);
            this.cong.TabIndex = 8;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.btnCong);
            // 
            // tru
            // 
            this.tru.Location = new System.Drawing.Point(562, 160);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(75, 31);
            this.tru.TabIndex = 9;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.btnTru);
            // 
            // nhan
            // 
            this.nhan.Location = new System.Drawing.Point(562, 201);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(75, 31);
            this.nhan.TabIndex = 10;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.btnNhan);
            // 
            // chia
            // 
            this.chia.Location = new System.Drawing.Point(562, 248);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(75, 31);
            this.chia.TabIndex = 11;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.btnChia);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(544, 360);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(119, 44);
            this.end.TabIndex = 12;
            this.end.Text = "Kết thúc";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.btnEnd);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.end);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.result);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox so1;
        private System.Windows.Forms.TextBox so2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Button end;
    }
}

