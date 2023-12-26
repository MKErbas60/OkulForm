namespace OkulApp
{
    partial class frmOgrKayit
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
            this.ogrBilgi = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ogrBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrBilgi
            // 
            this.ogrBilgi.Controls.Add(this.txtSoyad);
            this.ogrBilgi.Controls.Add(this.txtNumara);
            this.ogrBilgi.Controls.Add(this.txtAd);
            this.ogrBilgi.Controls.Add(this.no);
            this.ogrBilgi.Controls.Add(this.soyad);
            this.ogrBilgi.Controls.Add(this.ad);
            this.ogrBilgi.Location = new System.Drawing.Point(21, 23);
            this.ogrBilgi.Name = "ogrBilgi";
            this.ogrBilgi.Size = new System.Drawing.Size(345, 153);
            this.ogrBilgi.TabIndex = 7;
            this.ogrBilgi.TabStop = false;
            this.ogrBilgi.Text = "Öğrenci Bilgileri";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(154, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(111, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(154, 95);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(111, 20);
            this.txtNumara.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(154, 28);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(111, 20);
            this.txtAd.TabIndex = 0;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(31, 95);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(23, 13);
            this.no.TabIndex = 2;
            this.no.Text = "NO";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(31, 67);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(44, 13);
            this.soyad.TabIndex = 1;
            this.soyad.Text = "SOYAD";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(31, 36);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(22, 13);
            this.ad.TabIndex = 0;
            this.ad.Text = "AD";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(175, 196);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 33);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 254);
            this.Controls.Add(this.ogrBilgi);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmOgrKayit";
            this.Text = "frmOgrKayit";
            this.ogrBilgi.ResumeLayout(false);
            this.ogrBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ogrBilgi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Button btnKaydet;
    }
}