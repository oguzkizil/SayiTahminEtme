namespace SayiTahminEtme
{
    partial class frmTut
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
            this.lblSayi = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lstBoxSonuc = new System.Windows.Forms.ListBox();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnOnay = new System.Windows.Forms.Button();
            this.txtYY = new System.Windows.Forms.TextBox();
            this.txtSD = new System.Windows.Forms.TextBox();
            this.lblYY = new System.Windows.Forms.Label();
            this.lblSD = new System.Windows.Forms.Label();
            this.btnOlasilik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(13, 13);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(158, 13);
            this.lblSayi.TabIndex = 0;
            this.lblSayi.Text = "Sayınızı burada saklayabilirsiniz: ";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(177, 10);
            this.txtSayi.MaxLength = 4;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(61, 20);
            this.txtSayi.TabIndex = 1;
            // 
            // lstBoxSonuc
            // 
            this.lstBoxSonuc.FormattingEnabled = true;
            this.lstBoxSonuc.Location = new System.Drawing.Point(16, 128);
            this.lstBoxSonuc.Name = "lstBoxSonuc";
            this.lstBoxSonuc.Size = new System.Drawing.Size(357, 121);
            this.lstBoxSonuc.TabIndex = 2;
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Location = new System.Drawing.Point(16, 83);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(58, 13);
            this.lblTahmin.TabIndex = 3;
            this.lblTahmin.Text = "Tahminim: ";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(80, 80);
            this.txtTahmin.MaxLength = 4;
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.ReadOnly = true;
            this.txtTahmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTahmin.Size = new System.Drawing.Size(61, 20);
            this.txtTahmin.TabIndex = 4;
            this.txtTahmin.Text = "0123";
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(298, 78);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 23);
            this.btnOnay.TabIndex = 5;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // txtYY
            // 
            this.txtYY.Location = new System.Drawing.Point(249, 80);
            this.txtYY.Name = "txtYY";
            this.txtYY.Size = new System.Drawing.Size(38, 20);
            this.txtYY.TabIndex = 6;
            // 
            // txtSD
            // 
            this.txtSD.Location = new System.Drawing.Point(186, 80);
            this.txtSD.Name = "txtSD";
            this.txtSD.Size = new System.Drawing.Size(38, 20);
            this.txtSD.TabIndex = 7;
            // 
            // lblYY
            // 
            this.lblYY.AutoSize = true;
            this.lblYY.Location = new System.Drawing.Point(233, 83);
            this.lblYY.Name = "lblYY";
            this.lblYY.Size = new System.Drawing.Size(10, 13);
            this.lblYY.TabIndex = 8;
            this.lblYY.Text = "-";
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(167, 83);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(13, 13);
            this.lblSD.TabIndex = 9;
            this.lblSD.Text = "+";
            // 
            // btnOlasilik
            // 
            this.btnOlasilik.Location = new System.Drawing.Point(249, 8);
            this.btnOlasilik.Name = "btnOlasilik";
            this.btnOlasilik.Size = new System.Drawing.Size(124, 23);
            this.btnOlasilik.TabIndex = 10;
            this.btnOlasilik.Text = "Olasılık Tablosu";
            this.btnOlasilik.UseVisualStyleBackColor = true;
            this.btnOlasilik.Click += new System.EventHandler(this.btnOlasilik_Click);
            // 
            // frmTut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 261);
            this.Controls.Add(this.btnOlasilik);
            this.Controls.Add(this.lblSD);
            this.Controls.Add(this.lblYY);
            this.Controls.Add(this.txtSD);
            this.Controls.Add(this.txtYY);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.lstBoxSonuc);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lblSayi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTut";
            this.Text = "Sayı Tut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.ListBox lstBoxSonuc;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.TextBox txtYY;
        private System.Windows.Forms.TextBox txtSD;
        private System.Windows.Forms.Label lblYY;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.Button btnOlasilik;
    }
}