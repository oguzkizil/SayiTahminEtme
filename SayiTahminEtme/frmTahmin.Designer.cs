namespace SayiTahminEtme
{
    partial class frmTahmin
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDene = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.lstBoxSonuc = new System.Windows.Forms.ListBox();
            this.btnPes = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(69, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(212, 34);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDene
            // 
            this.btnDene.Location = new System.Drawing.Point(286, 94);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(75, 23);
            this.btnDene.TabIndex = 1;
            this.btnDene.Text = "Dene";
            this.btnDene.UseVisualStyleBackColor = true;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(193, 99);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 2;
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Location = new System.Drawing.Point(22, 99);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(45, 13);
            this.lblTahmin.TabIndex = 3;
            this.lblTahmin.Text = "Tahmin:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(133, 49);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 13);
            this.lblDurum.TabIndex = 4;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(69, 96);
            this.txtTahmin.MaxLength = 4;
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 20);
            this.txtTahmin.TabIndex = 5;
            this.txtTahmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahmin_KeyPress);
            // 
            // lstBoxSonuc
            // 
            this.lstBoxSonuc.FormattingEnabled = true;
            this.lstBoxSonuc.Location = new System.Drawing.Point(12, 132);
            this.lstBoxSonuc.Name = "lstBoxSonuc";
            this.lstBoxSonuc.Size = new System.Drawing.Size(269, 134);
            this.lstBoxSonuc.TabIndex = 6;
            // 
            // btnPes
            // 
            this.btnPes.Location = new System.Drawing.Point(287, 202);
            this.btnPes.Name = "btnPes";
            this.btnPes.Size = new System.Drawing.Size(75, 23);
            this.btnPes.TabIndex = 7;
            this.btnPes.Text = "pes :(";
            this.btnPes.UseVisualStyleBackColor = true;
            this.btnPes.Click += new System.EventHandler(this.btnPes_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(287, 243);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmTahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 284);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPes);
            this.Controls.Add(this.lstBoxSonuc);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.btnBasla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTahmin";
            this.Text = "Kulanıcı Tahmin Eder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDene;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.ListBox lstBoxSonuc;
        private System.Windows.Forms.Button btnPes;
        private System.Windows.Forms.Button btnReset;
    }
}

