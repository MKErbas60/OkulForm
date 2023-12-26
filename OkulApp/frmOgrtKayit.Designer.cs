namespace OkulApp
{
    partial class frmOgrtKayit
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
            this.ogretBilgi = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.TC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ogretBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogretBilgi
            // 
            this.ogretBilgi.Controls.Add(this.txtSoyad);
            this.ogretBilgi.Controls.Add(this.txtTC);
            this.ogretBilgi.Controls.Add(this.txtAd);
            this.ogretBilgi.Controls.Add(this.TC);
            this.ogretBilgi.Controls.Add(this.label2);
            this.ogretBilgi.Controls.Add(this.label1);
            this.ogretBilgi.Location = new System.Drawing.Point(21, 12);
            this.ogretBilgi.Name = "ogretBilgi";
            this.ogretBilgi.Size = new System.Drawing.Size(316, 153);
            this.ogretBilgi.TabIndex = 9;
            this.ogretBilgi.TabStop = false;
            this.ogretBilgi.Text = "Öğretmen Bilgileri";
            this.ogretBilgi.Enter += new System.EventHandler(this.ogrBilgi_Enter);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(149, 55);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(111, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(149, 90);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(111, 20);
            this.txtTC.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(149, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(111, 20);
            this.txtAd.TabIndex = 0;
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.TC.Location = new System.Drawing.Point(26, 90);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(21, 13);
            this.TC.TabIndex = 2;
            this.TC.Text = "TC";
            this.TC.Click += new System.EventHandler(this.TC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(170, 182);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 33);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmOgrtKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 239);
            this.Controls.Add(this.ogretBilgi);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmOgrtKayit";
            this.Text = "frmOgrtKayit";
            this.ogretBilgi.ResumeLayout(false);
            this.ogretBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ogretBilgi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
    }
}