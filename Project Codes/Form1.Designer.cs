namespace Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.mailAdresi = new System.Windows.Forms.Label();
            this.kullaniciParola = new System.Windows.Forms.Label();
            this.parolaTekrari = new System.Windows.Forms.Label();
            this.sorular = new System.Windows.Forms.Label();
            this.guvenlikCevabi = new System.Windows.Forms.Label();
            this.kullaniciCinsiyet = new System.Windows.Forms.Label();
            this.girisAdi = new System.Windows.Forms.Label();
            this.girisParola = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.kullanici = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.parolasi = new System.Windows.Forms.TextBox();
            this.tekrari = new System.Windows.Forms.TextBox();
            this.guvenlikSorulari = new System.Windows.Forms.ComboBox();
            this.cevabi = new System.Windows.Forms.TextBox();
            this.girisKullanici = new System.Windows.Forms.TextBox();
            this.girisParolasi = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.kadin = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şifrelerHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifremiUnuttumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifremiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.ad.Location = new System.Drawing.Point(386, 91);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(41, 13);
            this.ad.TabIndex = 0;
            this.ad.Text = "label1";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.soyad.Location = new System.Drawing.Point(386, 114);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(41, 13);
            this.soyad.TabIndex = 1;
            this.soyad.Text = "label2";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.kullaniciAdi.Location = new System.Drawing.Point(386, 139);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(41, 13);
            this.kullaniciAdi.TabIndex = 2;
            this.kullaniciAdi.Text = "label3";
            // 
            // mailAdresi
            // 
            this.mailAdresi.AutoSize = true;
            this.mailAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailAdresi.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mailAdresi.Location = new System.Drawing.Point(386, 162);
            this.mailAdresi.Name = "mailAdresi";
            this.mailAdresi.Size = new System.Drawing.Size(41, 13);
            this.mailAdresi.TabIndex = 3;
            this.mailAdresi.Text = "label4";
            // 
            // kullaniciParola
            // 
            this.kullaniciParola.AutoSize = true;
            this.kullaniciParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciParola.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.kullaniciParola.Location = new System.Drawing.Point(386, 185);
            this.kullaniciParola.Name = "kullaniciParola";
            this.kullaniciParola.Size = new System.Drawing.Size(41, 13);
            this.kullaniciParola.TabIndex = 4;
            this.kullaniciParola.Text = "label5";
            // 
            // parolaTekrari
            // 
            this.parolaTekrari.AutoSize = true;
            this.parolaTekrari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolaTekrari.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.parolaTekrari.Location = new System.Drawing.Point(386, 207);
            this.parolaTekrari.Name = "parolaTekrari";
            this.parolaTekrari.Size = new System.Drawing.Size(41, 13);
            this.parolaTekrari.TabIndex = 5;
            this.parolaTekrari.Text = "label6";
            // 
            // sorular
            // 
            this.sorular.AutoSize = true;
            this.sorular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorular.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.sorular.Location = new System.Drawing.Point(386, 229);
            this.sorular.Name = "sorular";
            this.sorular.Size = new System.Drawing.Size(41, 13);
            this.sorular.TabIndex = 6;
            this.sorular.Text = "label7";
            // 
            // guvenlikCevabi
            // 
            this.guvenlikCevabi.AutoSize = true;
            this.guvenlikCevabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlikCevabi.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.guvenlikCevabi.Location = new System.Drawing.Point(386, 252);
            this.guvenlikCevabi.Name = "guvenlikCevabi";
            this.guvenlikCevabi.Size = new System.Drawing.Size(41, 13);
            this.guvenlikCevabi.TabIndex = 7;
            this.guvenlikCevabi.Text = "label8";
            // 
            // kullaniciCinsiyet
            // 
            this.kullaniciCinsiyet.AutoSize = true;
            this.kullaniciCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciCinsiyet.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.kullaniciCinsiyet.Location = new System.Drawing.Point(386, 275);
            this.kullaniciCinsiyet.Name = "kullaniciCinsiyet";
            this.kullaniciCinsiyet.Size = new System.Drawing.Size(41, 13);
            this.kullaniciCinsiyet.TabIndex = 8;
            this.kullaniciCinsiyet.Text = "label9";
            // 
            // girisAdi
            // 
            this.girisAdi.AutoSize = true;
            this.girisAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisAdi.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.girisAdi.Location = new System.Drawing.Point(404, 31);
            this.girisAdi.Name = "girisAdi";
            this.girisAdi.Size = new System.Drawing.Size(48, 13);
            this.girisAdi.TabIndex = 9;
            this.girisAdi.Text = "label10";
            // 
            // girisParola
            // 
            this.girisParola.AutoSize = true;
            this.girisParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisParola.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.girisParola.Location = new System.Drawing.Point(560, 32);
            this.girisParola.Name = "girisParola";
            this.girisParola.Size = new System.Drawing.Size(48, 13);
            this.girisParola.TabIndex = 10;
            this.girisParola.Text = "label11";
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(427, 88);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 20);
            this.isim.TabIndex = 11;
            // 
            // soyisim
            // 
            this.soyisim.Location = new System.Drawing.Point(427, 114);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(100, 20);
            this.soyisim.TabIndex = 12;
            // 
            // kullanici
            // 
            this.kullanici.Location = new System.Drawing.Point(427, 139);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(100, 20);
            this.kullanici.TabIndex = 13;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(427, 165);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 14;
            // 
            // parolasi
            // 
            this.parolasi.Location = new System.Drawing.Point(427, 185);
            this.parolasi.Name = "parolasi";
            this.parolasi.Size = new System.Drawing.Size(100, 20);
            this.parolasi.TabIndex = 15;
            // 
            // tekrari
            // 
            this.tekrari.Location = new System.Drawing.Point(423, 207);
            this.tekrari.Name = "tekrari";
            this.tekrari.Size = new System.Drawing.Size(100, 20);
            this.tekrari.TabIndex = 16;
            // 
            // guvenlikSorulari
            // 
            this.guvenlikSorulari.FormattingEnabled = true;
            this.guvenlikSorulari.Location = new System.Drawing.Point(428, 229);
            this.guvenlikSorulari.Name = "guvenlikSorulari";
            this.guvenlikSorulari.Size = new System.Drawing.Size(121, 21);
            this.guvenlikSorulari.TabIndex = 17;
            // 
            // cevabi
            // 
            this.cevabi.Location = new System.Drawing.Point(427, 256);
            this.cevabi.Name = "cevabi";
            this.cevabi.Size = new System.Drawing.Size(100, 20);
            this.cevabi.TabIndex = 18;
            // 
            // girisKullanici
            // 
            this.girisKullanici.Location = new System.Drawing.Point(454, 28);
            this.girisKullanici.Name = "girisKullanici";
            this.girisKullanici.Size = new System.Drawing.Size(100, 20);
            this.girisKullanici.TabIndex = 19;
            // 
            // girisParolasi
            // 
            this.girisParolasi.Location = new System.Drawing.Point(607, 28);
            this.girisParolasi.Name = "girisParolasi";
            this.girisParolasi.Size = new System.Drawing.Size(100, 20);
            this.girisParolasi.TabIndex = 20;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(428, 309);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(75, 23);
            this.btn_kayit.TabIndex = 22;
            this.btn_kayit.Text = "button1";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(713, 26);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 23;
            this.btn_giris.Text = "button2";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkek.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.erkek.Location = new System.Drawing.Point(428, 283);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(97, 17);
            this.erkek.TabIndex = 24;
            this.erkek.TabStop = true;
            this.erkek.Text = "radioButton1";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // kadin
            // 
            this.kadin.AutoSize = true;
            this.kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadin.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.kadin.Location = new System.Drawing.Point(520, 283);
            this.kadin.Name = "kadin";
            this.kadin.Size = new System.Drawing.Size(97, 17);
            this.kadin.TabIndex = 25;
            this.kadin.TabStop = true;
            this.kadin.Text = "radioButton2";
            this.kadin.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifrelerHakkındaToolStripMenuItem,
            this.personelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // şifrelerHakkındaToolStripMenuItem
            // 
            this.şifrelerHakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifremiUnuttumToolStripMenuItem,
            this.şifremiDeğiştirToolStripMenuItem});
            this.şifrelerHakkındaToolStripMenuItem.Name = "şifrelerHakkındaToolStripMenuItem";
            this.şifrelerHakkındaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.şifrelerHakkındaToolStripMenuItem.Text = "Şifreler Hakkında";
            // 
            // şifremiUnuttumToolStripMenuItem
            // 
            this.şifremiUnuttumToolStripMenuItem.Name = "şifremiUnuttumToolStripMenuItem";
            this.şifremiUnuttumToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.şifremiUnuttumToolStripMenuItem.Text = "Şifremi Unuttum";
            this.şifremiUnuttumToolStripMenuItem.Click += new System.EventHandler(this.şifremiUnuttumToolStripMenuItem_Click);
            // 
            // şifremiDeğiştirToolStripMenuItem
            // 
            this.şifremiDeğiştirToolStripMenuItem.Name = "şifremiDeğiştirToolStripMenuItem";
            this.şifremiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.şifremiDeğiştirToolStripMenuItem.Text = "Şifremi Değiştir";
            this.şifremiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifremiDeğiştirToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.girişToolStripMenuItem.Text = "Giriş";
            this.girişToolStripMenuItem.Click += new System.EventHandler(this.girişToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kadin);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.girisParolasi);
            this.Controls.Add(this.girisKullanici);
            this.Controls.Add(this.cevabi);
            this.Controls.Add(this.guvenlikSorulari);
            this.Controls.Add(this.tekrari);
            this.Controls.Add(this.parolasi);
            this.Controls.Add(this.email);
            this.Controls.Add(this.kullanici);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.girisParola);
            this.Controls.Add(this.girisAdi);
            this.Controls.Add(this.kullaniciCinsiyet);
            this.Controls.Add(this.guvenlikCevabi);
            this.Controls.Add(this.sorular);
            this.Controls.Add(this.parolaTekrari);
            this.Controls.Add(this.kullaniciParola);
            this.Controls.Add(this.mailAdresi);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.Label mailAdresi;
        private System.Windows.Forms.Label kullaniciParola;
        private System.Windows.Forms.Label parolaTekrari;
        private System.Windows.Forms.Label sorular;
        private System.Windows.Forms.Label guvenlikCevabi;
        private System.Windows.Forms.Label kullaniciCinsiyet;
        private System.Windows.Forms.Label girisAdi;
        private System.Windows.Forms.Label girisParola;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox soyisim;
        private System.Windows.Forms.TextBox kullanici;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox parolasi;
        private System.Windows.Forms.TextBox tekrari;
        private System.Windows.Forms.ComboBox guvenlikSorulari;
        private System.Windows.Forms.TextBox cevabi;
        private System.Windows.Forms.TextBox girisKullanici;
        private System.Windows.Forms.TextBox girisParolasi;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.RadioButton kadin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şifrelerHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifremiUnuttumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifremiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
    }
}

