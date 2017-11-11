namespace SayiTahminEtme
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.btnTut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTahminEt
            // 
            resources.ApplyResources(this.btnTahminEt, "btnTahminEt");
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // btnTut
            // 
            resources.ApplyResources(this.btnTut, "btnTut");
            this.btnTut.Name = "btnTut";
            this.btnTut.UseVisualStyleBackColor = true;
            this.btnTut.Click += new System.EventHandler(this.btnTut_Click);
            // 
            // frmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTut);
            this.Controls.Add(this.btnTahminEt);
            this.Name = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Button btnTut;
    }
}