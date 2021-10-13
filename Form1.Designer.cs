namespace AplikasiSelamatDatang
{
    partial class frmSelamatDatang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelamatDatang));
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.btnKeterangan1 = new System.Windows.Forms.Button();
            this.btnKeterangan2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeterangan
            // 
            resources.ApplyResources(this.lblKeterangan, "lblKeterangan");
            this.lblKeterangan.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Click += new System.EventHandler(this.Form1_DoubleClick);
            // 
            // btnKeterangan1
            // 
            resources.ApplyResources(this.btnKeterangan1, "btnKeterangan1");
            this.btnKeterangan1.Name = "btnKeterangan1";
            this.btnKeterangan1.UseVisualStyleBackColor = true;
            this.btnKeterangan1.Click += new System.EventHandler(this.btnKeterangan1_Click);
            // 
            // btnKeterangan2
            // 
            resources.ApplyResources(this.btnKeterangan2, "btnKeterangan2");
            this.btnKeterangan2.Name = "btnKeterangan2";
            this.btnKeterangan2.UseVisualStyleBackColor = true;
            this.btnKeterangan2.Click += new System.EventHandler(this.btnKeterangan2_Click);
            // 
            // frmSelamatDatang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKeterangan2);
            this.Controls.Add(this.btnKeterangan1);
            this.Controls.Add(this.lblKeterangan);
            this.Name = "frmSelamatDatang";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Button btnKeterangan1;
        private System.Windows.Forms.Button btnKeterangan2;
    }
}

