namespace Proje
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txt_kullanici = new System.Windows.Forms.Label();
            this.txt_personel = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.kullaniciParola = new System.Windows.Forms.TextBox();
            this.kullaniciCevap = new System.Windows.Forms.TextBox();
            this.kullaniciYeni = new System.Windows.Forms.TextBox();
            this.personelNo = new System.Windows.Forms.TextBox();
            this.personelParola = new System.Windows.Forms.TextBox();
            this.kullaniciGuvenlik = new System.Windows.Forms.ComboBox();
            this.personelGuvenlik = new System.Windows.Forms.ComboBox();
            this.kullaniciTamam = new System.Windows.Forms.Button();
            this.personelTamam = new System.Windows.Forms.Button();
            this.personelCevap = new System.Windows.Forms.TextBox();
            this.personelYeni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.AutoSize = true;
            this.txt_kullanici.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kullanici.Location = new System.Drawing.Point(145, 38);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(44, 16);
            this.txt_kullanici.TabIndex = 0;
            this.txt_kullanici.Text = "label1";
            // 
            // txt_personel
            // 
            this.txt_personel.AutoSize = true;
            this.txt_personel.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personel.Location = new System.Drawing.Point(497, 38);
            this.txt_personel.Name = "txt_personel";
            this.txt_personel.Size = new System.Drawing.Size(45, 16);
            this.txt_personel.TabIndex = 1;
            this.txt_personel.Text = "label2";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(135, 72);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.kullaniciAdi.TabIndex = 2;
            // 
            // kullaniciParola
            // 
            this.kullaniciParola.Location = new System.Drawing.Point(135, 109);
            this.kullaniciParola.Name = "kullaniciParola";
            this.kullaniciParola.Size = new System.Drawing.Size(100, 20);
            this.kullaniciParola.TabIndex = 3;
            // 
            // kullaniciCevap
            // 
            this.kullaniciCevap.Location = new System.Drawing.Point(135, 169);
            this.kullaniciCevap.Name = "kullaniciCevap";
            this.kullaniciCevap.Size = new System.Drawing.Size(100, 20);
            this.kullaniciCevap.TabIndex = 4;
            // 
            // kullaniciYeni
            // 
            this.kullaniciYeni.Location = new System.Drawing.Point(135, 195);
            this.kullaniciYeni.Name = "kullaniciYeni";
            this.kullaniciYeni.Size = new System.Drawing.Size(100, 20);
            this.kullaniciYeni.TabIndex = 5;
            // 
            // personelNo
            // 
            this.personelNo.Location = new System.Drawing.Point(468, 72);
            this.personelNo.Name = "personelNo";
            this.personelNo.Size = new System.Drawing.Size(100, 20);
            this.personelNo.TabIndex = 6;
            // 
            // personelParola
            // 
            this.personelParola.Location = new System.Drawing.Point(468, 109);
            this.personelParola.Name = "personelParola";
            this.personelParola.Size = new System.Drawing.Size(100, 20);
            this.personelParola.TabIndex = 7;
            // 
            // kullaniciGuvenlik
            // 
            this.kullaniciGuvenlik.FormattingEnabled = true;
            this.kullaniciGuvenlik.Location = new System.Drawing.Point(135, 136);
            this.kullaniciGuvenlik.Name = "kullaniciGuvenlik";
            this.kullaniciGuvenlik.Size = new System.Drawing.Size(121, 21);
            this.kullaniciGuvenlik.TabIndex = 8;
            // 
            // personelGuvenlik
            // 
            this.personelGuvenlik.FormattingEnabled = true;
            this.personelGuvenlik.Location = new System.Drawing.Point(468, 136);
            this.personelGuvenlik.Name = "personelGuvenlik";
            this.personelGuvenlik.Size = new System.Drawing.Size(121, 21);
            this.personelGuvenlik.TabIndex = 9;
            // 
            // kullaniciTamam
            // 
            this.kullaniciTamam.BackColor = System.Drawing.Color.Salmon;
            this.kullaniciTamam.Location = new System.Drawing.Point(135, 235);
            this.kullaniciTamam.Name = "kullaniciTamam";
            this.kullaniciTamam.Size = new System.Drawing.Size(75, 23);
            this.kullaniciTamam.TabIndex = 10;
            this.kullaniciTamam.Text = "button1";
            this.kullaniciTamam.UseVisualStyleBackColor = false;
            this.kullaniciTamam.Click += new System.EventHandler(this.kullaniciTamam_Click);
            // 
            // personelTamam
            // 
            this.personelTamam.BackColor = System.Drawing.Color.SeaGreen;
            this.personelTamam.Location = new System.Drawing.Point(468, 235);
            this.personelTamam.Name = "personelTamam";
            this.personelTamam.Size = new System.Drawing.Size(75, 23);
            this.personelTamam.TabIndex = 11;
            this.personelTamam.Text = "button2";
            this.personelTamam.UseVisualStyleBackColor = false;
            this.personelTamam.Click += new System.EventHandler(this.personelTamam_Click);
            // 
            // personelCevap
            // 
            this.personelCevap.Location = new System.Drawing.Point(468, 169);
            this.personelCevap.Name = "personelCevap";
            this.personelCevap.Size = new System.Drawing.Size(100, 20);
            this.personelCevap.TabIndex = 12;
            // 
            // personelYeni
            // 
            this.personelYeni.Location = new System.Drawing.Point(468, 195);
            this.personelYeni.Name = "personelYeni";
            this.personelYeni.Size = new System.Drawing.Size(100, 20);
            this.personelYeni.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personelYeni);
            this.Controls.Add(this.personelCevap);
            this.Controls.Add(this.personelTamam);
            this.Controls.Add(this.kullaniciTamam);
            this.Controls.Add(this.personelGuvenlik);
            this.Controls.Add(this.kullaniciGuvenlik);
            this.Controls.Add(this.personelParola);
            this.Controls.Add(this.personelNo);
            this.Controls.Add(this.kullaniciYeni);
            this.Controls.Add(this.kullaniciCevap);
            this.Controls.Add(this.kullaniciParola);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.txt_personel);
            this.Controls.Add(this.txt_kullanici);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_kullanici;
        private System.Windows.Forms.Label txt_personel;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox kullaniciParola;
        private System.Windows.Forms.TextBox kullaniciCevap;
        private System.Windows.Forms.TextBox kullaniciYeni;
        private System.Windows.Forms.TextBox personelNo;
        private System.Windows.Forms.TextBox personelParola;
        private System.Windows.Forms.ComboBox kullaniciGuvenlik;
        private System.Windows.Forms.ComboBox personelGuvenlik;
        private System.Windows.Forms.Button kullaniciTamam;
        private System.Windows.Forms.Button personelTamam;
        private System.Windows.Forms.TextBox personelCevap;
        private System.Windows.Forms.TextBox personelYeni;
    }
}