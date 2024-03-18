using System;

namespace TinhGiaTriDaThuc
{
    partial class InputBox
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
            this.InputText = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.AutoSize = true;
            this.InputText.Location = new System.Drawing.Point(33, 26);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(46, 20);
            this.InputText.TabIndex = 0;
            this.InputText.Text = "Input";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(28, 69);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(420, 43);
            this.textBoxInput.TabIndex = 1;
            // 
            // XacNhan
            // 
            this.XacNhan.Location = new System.Drawing.Point(475, 69);
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Size = new System.Drawing.Size(85, 41);
            this.XacNhan.TabIndex = 2;
            this.XacNhan.Text = "Đồng ý";
            this.XacNhan.UseVisualStyleBackColor = true;
            this.XacNhan.Click += new System.EventHandler(this.XacNhann);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 156);
            this.Controls.Add(this.XacNhan);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.InputText);
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label InputText;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button XacNhan;
    }
}