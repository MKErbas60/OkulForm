namespace OkulApp
{
    partial class AnaForm
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
            this.CmdOgrenciKayit = new System.Windows.Forms.Button();
            this.CmdOgretmenKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdOgrenciKayit
            // 
            this.CmdOgrenciKayit.Location = new System.Drawing.Point(333, 102);
            this.CmdOgrenciKayit.Name = "CmdOgrenciKayit";
            this.CmdOgrenciKayit.Size = new System.Drawing.Size(197, 59);
            this.CmdOgrenciKayit.TabIndex = 0;
            this.CmdOgrenciKayit.Text = "Öğrenci Kayıt";
            this.CmdOgrenciKayit.UseVisualStyleBackColor = true;
            this.CmdOgrenciKayit.Click += new System.EventHandler(this.CmdOgrenciKayit_Click);
            // 
            // CmdOgretmenKayit
            // 
            this.CmdOgretmenKayit.Location = new System.Drawing.Point(333, 184);
            this.CmdOgretmenKayit.Name = "CmdOgretmenKayit";
            this.CmdOgretmenKayit.Size = new System.Drawing.Size(197, 59);
            this.CmdOgretmenKayit.TabIndex = 1;
            this.CmdOgretmenKayit.Text = "Öğretmen Kayıt";
            this.CmdOgretmenKayit.UseVisualStyleBackColor = true;
            this.CmdOgretmenKayit.Click += new System.EventHandler(this.CmdOgretmenKayit_Click);
            // 
            // AnaForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdOgretmenKayit);
            this.Controls.Add(this.CmdOgrenciKayit);
            this.Name = "AnaForn";
            this.Text = "AnaForn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdOgrenciKayit;
        private System.Windows.Forms.Button CmdOgretmenKayit;
    }
}