namespace OOP_CinemaApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFilmOlustur = new System.Windows.Forms.Button();
            this.btnSalonOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listSalonlar = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listFilmler = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nupBiletSayisi = new System.Windows.Forms.NumericUpDown();
            this.chkIndırımli = new System.Windows.Forms.CheckBox();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnBiletİptal = new System.Windows.Forms.Button();
            this.lblIndFiyat = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblBosKoltukSayisi = new System.Windows.Forms.Label();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblHasilat = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblTuru = new System.Windows.Forms.Label();
            this.lblGosterimYili = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblOyuncuAdi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lstOyuncular = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerileriYenile = new System.Windows.Forms.Button();
            this.lblToplamHasilat = new System.Windows.Forms.Label();
            this.lblToplamBosKoltukSayisi = new System.Windows.Forms.Label();
            this.lblSatKoltukSayisi = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBiletSayisi)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilmOlustur
            // 
            this.btnFilmOlustur.Location = new System.Drawing.Point(118, 12);
            this.btnFilmOlustur.Name = "btnFilmOlustur";
            this.btnFilmOlustur.Size = new System.Drawing.Size(100, 50);
            this.btnFilmOlustur.TabIndex = 0;
            this.btnFilmOlustur.Text = "Film Oluştur";
            this.btnFilmOlustur.UseVisualStyleBackColor = true;
            // 
            // btnSalonOlustur
            // 
            this.btnSalonOlustur.Location = new System.Drawing.Point(12, 12);
            this.btnSalonOlustur.Name = "btnSalonOlustur";
            this.btnSalonOlustur.Size = new System.Drawing.Size(100, 50);
            this.btnSalonOlustur.TabIndex = 1;
            this.btnSalonOlustur.Text = "Salon Oluştur";
            this.btnSalonOlustur.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSalonlar);
            this.groupBox1.Location = new System.Drawing.Point(266, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salonlar";
            // 
            // listSalonlar
            // 
            this.listSalonlar.FormattingEnabled = true;
            this.listSalonlar.ItemHeight = 15;
            this.listSalonlar.Location = new System.Drawing.Point(6, 22);
            this.listSalonlar.Name = "listSalonlar";
            this.listSalonlar.Size = new System.Drawing.Size(236, 334);
            this.listSalonlar.TabIndex = 0;
            this.listSalonlar.SelectedIndexChanged += new System.EventHandler(this.listSalonlar_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listFilmler);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 370);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filmler";
            // 
            // listFilmler
            // 
            this.listFilmler.FormattingEnabled = true;
            this.listFilmler.ItemHeight = 15;
            this.listFilmler.Location = new System.Drawing.Point(6, 22);
            this.listFilmler.Name = "listFilmler";
            this.listFilmler.Size = new System.Drawing.Size(236, 334);
            this.listFilmler.TabIndex = 0;
            this.listFilmler.SelectedIndexChanged += new System.EventHandler(this.listFilmler_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(520, 194);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 362);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nupBiletSayisi);
            this.tabPage1.Controls.Add(this.chkIndırımli);
            this.tabPage1.Controls.Add(this.btnBiletSat);
            this.tabPage1.Controls.Add(this.lblBakiye);
            this.tabPage1.Controls.Add(this.btnBiletİptal);
            this.tabPage1.Controls.Add(this.lblIndFiyat);
            this.tabPage1.Controls.Add(this.lblFiyat);
            this.tabPage1.Controls.Add(this.lblBosKoltukSayisi);
            this.tabPage1.Controls.Add(this.lblKoltukSayisi);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "ticket";
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bilet İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nupBiletSayisi
            // 
            this.nupBiletSayisi.Location = new System.Drawing.Point(130, 231);
            this.nupBiletSayisi.Name = "nupBiletSayisi";
            this.nupBiletSayisi.Size = new System.Drawing.Size(120, 23);
            this.nupBiletSayisi.TabIndex = 8;
            // 
            // chkIndırımli
            // 
            this.chkIndırımli.AutoSize = true;
            this.chkIndırımli.Location = new System.Drawing.Point(44, 232);
            this.chkIndırımli.Name = "chkIndırımli";
            this.chkIndırımli.Size = new System.Drawing.Size(70, 19);
            this.chkIndırımli.TabIndex = 7;
            this.chkIndırımli.Text = "İndirimli";
            this.chkIndırımli.UseVisualStyleBackColor = true;
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.AccessibleDescription = "";
            this.btnBiletSat.Location = new System.Drawing.Point(44, 274);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(100, 50);
            this.btnBiletSat.TabIndex = 5;
            this.btnBiletSat.Text = "Bilet Sat";
            this.btnBiletSat.UseVisualStyleBackColor = true;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(150, 133);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(13, 15);
            this.lblBakiye.TabIndex = 1;
            this.lblBakiye.Text = "0";
            // 
            // btnBiletİptal
            // 
            this.btnBiletİptal.Location = new System.Drawing.Point(150, 274);
            this.btnBiletİptal.Name = "btnBiletİptal";
            this.btnBiletİptal.Size = new System.Drawing.Size(100, 50);
            this.btnBiletİptal.TabIndex = 4;
            this.btnBiletİptal.Text = "Bilet İptal";
            this.btnBiletİptal.UseVisualStyleBackColor = true;
            this.btnBiletİptal.Click += new System.EventHandler(this.btnBiletİptal_Click);
            // 
            // lblIndFiyat
            // 
            this.lblIndFiyat.AutoSize = true;
            this.lblIndFiyat.Location = new System.Drawing.Point(150, 106);
            this.lblIndFiyat.Name = "lblIndFiyat";
            this.lblIndFiyat.Size = new System.Drawing.Size(13, 15);
            this.lblIndFiyat.TabIndex = 2;
            this.lblIndFiyat.Text = "0";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(150, 80);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(13, 15);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "0";
            // 
            // lblBosKoltukSayisi
            // 
            this.lblBosKoltukSayisi.AutoSize = true;
            this.lblBosKoltukSayisi.Location = new System.Drawing.Point(150, 53);
            this.lblBosKoltukSayisi.Name = "lblBosKoltukSayisi";
            this.lblBosKoltukSayisi.Size = new System.Drawing.Size(13, 15);
            this.lblBosKoltukSayisi.TabIndex = 4;
            this.lblBosKoltukSayisi.Text = "0";
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.AutoSize = true;
            this.lblKoltukSayisi.Location = new System.Drawing.Point(150, 24);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(13, 15);
            this.lblKoltukSayisi.TabIndex = 5;
            this.lblKoltukSayisi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bakiye:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "İndirimli Bilet Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bilet Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Boş Koltuk Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk Sayısı:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblHasilat);
            this.tabPage2.Controls.Add(this.lblBaslik);
            this.tabPage2.Controls.Add(this.lblTuru);
            this.tabPage2.Controls.Add(this.lblGosterimYili);
            this.tabPage2.Controls.Add(this.lblFilmAdi);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.ImageKey = "film";
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(431, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Film Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblHasilat
            // 
            this.lblHasilat.AutoSize = true;
            this.lblHasilat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHasilat.Location = new System.Drawing.Point(153, 128);
            this.lblHasilat.Name = "lblHasilat";
            this.lblHasilat.Size = new System.Drawing.Size(14, 15);
            this.lblHasilat.TabIndex = 11;
            this.lblHasilat.Text = "0";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(153, 101);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(13, 15);
            this.lblBaslik.TabIndex = 12;
            this.lblBaslik.Text = "0";
            // 
            // lblTuru
            // 
            this.lblTuru.AutoSize = true;
            this.lblTuru.Location = new System.Drawing.Point(153, 75);
            this.lblTuru.Name = "lblTuru";
            this.lblTuru.Size = new System.Drawing.Size(13, 15);
            this.lblTuru.TabIndex = 13;
            this.lblTuru.Text = "0";
            // 
            // lblGosterimYili
            // 
            this.lblGosterimYili.AutoSize = true;
            this.lblGosterimYili.Location = new System.Drawing.Point(153, 48);
            this.lblGosterimYili.Name = "lblGosterimYili";
            this.lblGosterimYili.Size = new System.Drawing.Size(13, 15);
            this.lblGosterimYili.TabIndex = 14;
            this.lblGosterimYili.Text = "0";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(153, 19);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(13, 15);
            this.lblFilmAdi.TabIndex = 15;
            this.lblFilmAdi.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(83, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Hasılat:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Başlık:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Türü:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Gösterim YIlı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(75, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Film Adı:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblYas);
            this.tabPage3.Controls.Add(this.lblDogumTarihi);
            this.tabPage3.Controls.Add(this.lblOyuncuAdi);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.lstOyuncular);
            this.tabPage3.ImageKey = "actor";
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(431, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Oyuncu Listesi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(331, 76);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(13, 15);
            this.lblYas.TabIndex = 19;
            this.lblYas.Text = "0";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(331, 49);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(13, 15);
            this.lblDogumTarihi.TabIndex = 20;
            this.lblDogumTarihi.Text = "0";
            // 
            // lblOyuncuAdi
            // 
            this.lblOyuncuAdi.AutoSize = true;
            this.lblOyuncuAdi.Location = new System.Drawing.Point(331, 20);
            this.lblOyuncuAdi.Name = "lblOyuncuAdi";
            this.lblOyuncuAdi.Size = new System.Drawing.Size(13, 15);
            this.lblOyuncuAdi.TabIndex = 21;
            this.lblOyuncuAdi.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Yaş:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Doğum Tarihi:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(227, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "Oyuncu Adı:";
            // 
            // lstOyuncular
            // 
            this.lstOyuncular.FormattingEnabled = true;
            this.lstOyuncular.ItemHeight = 15;
            this.lstOyuncular.Location = new System.Drawing.Point(6, 6);
            this.lstOyuncular.Name = "lstOyuncular";
            this.lstOyuncular.Size = new System.Drawing.Size(208, 319);
            this.lstOyuncular.TabIndex = 1;
            this.lstOyuncular.SelectedIndexChanged += new System.EventHandler(this.lstOyuncular_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "actor");
            this.imageList1.Images.SetKeyName(1, "film");
            this.imageList1.Images.SetKeyName(2, "ticket");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerileriYenile);
            this.groupBox3.Controls.Add(this.lblToplamHasilat);
            this.groupBox3.Controls.Add(this.lblToplamBosKoltukSayisi);
            this.groupBox3.Controls.Add(this.lblSatKoltukSayisi);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(524, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 176);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sinema Salonu Toplam Verileri:";
            // 
            // btnVerileriYenile
            // 
            this.btnVerileriYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnVerileriYenile.Image")));
            this.btnVerileriYenile.Location = new System.Drawing.Point(365, 22);
            this.btnVerileriYenile.Name = "btnVerileriYenile";
            this.btnVerileriYenile.Size = new System.Drawing.Size(60, 60);
            this.btnVerileriYenile.TabIndex = 12;
            this.btnVerileriYenile.UseVisualStyleBackColor = true;
            this.btnVerileriYenile.Click += new System.EventHandler(this.btnVerileriYenile_Click);
            // 
            // lblToplamHasilat
            // 
            this.lblToplamHasilat.AutoSize = true;
            this.lblToplamHasilat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamHasilat.Location = new System.Drawing.Point(207, 91);
            this.lblToplamHasilat.Name = "lblToplamHasilat";
            this.lblToplamHasilat.Size = new System.Drawing.Size(19, 21);
            this.lblToplamHasilat.TabIndex = 9;
            this.lblToplamHasilat.Text = "0";
            // 
            // lblToplamBosKoltukSayisi
            // 
            this.lblToplamBosKoltukSayisi.AutoSize = true;
            this.lblToplamBosKoltukSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamBosKoltukSayisi.Location = new System.Drawing.Point(207, 64);
            this.lblToplamBosKoltukSayisi.Name = "lblToplamBosKoltukSayisi";
            this.lblToplamBosKoltukSayisi.Size = new System.Drawing.Size(19, 21);
            this.lblToplamBosKoltukSayisi.TabIndex = 10;
            this.lblToplamBosKoltukSayisi.Text = "0";
            // 
            // lblSatKoltukSayisi
            // 
            this.lblSatKoltukSayisi.AutoSize = true;
            this.lblSatKoltukSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSatKoltukSayisi.Location = new System.Drawing.Point(207, 35);
            this.lblSatKoltukSayisi.Name = "lblSatKoltukSayisi";
            this.lblSatKoltukSayisi.Size = new System.Drawing.Size(19, 21);
            this.lblSatKoltukSayisi.TabIndex = 11;
            this.lblSatKoltukSayisi.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(50, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 21);
            this.label17.TabIndex = 6;
            this.label17.Text = "Toplam Hasılat:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(35, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 21);
            this.label18.TabIndex = 7;
            this.label18.Text = "Boş Koltuk Sayısı:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(9, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(169, 21);
            this.label19.TabIndex = 8;
            this.label19.Text = "Satılan Koltuk Sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 568);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalonOlustur);
            this.Controls.Add(this.btnFilmOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBiletSayisi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFilmOlustur;
        private Button btnSalonOlustur;
        private GroupBox groupBox1;
        private ListBox listSalonlar;
        private GroupBox groupBox2;
        private ListBox listFilmler;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageList1;
        private NumericUpDown nupBiletSayisi;
        private CheckBox chkIndırımli;
        private Button btnBiletSat;
        private Label lblBakiye;
        private Button btnBiletİptal;
        private Label lblIndFiyat;
        private Label lblFiyat;
        private Label lblBosKoltukSayisi;
        private Label lblKoltukSayisi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblHasilat;
        private Label lblBaslik;
        private Label lblTuru;
        private Label lblGosterimYili;
        private Label lblFilmAdi;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label lblYas;
        private Label lblDogumTarihi;
        private Label lblOyuncuAdi;
        private Label label9;
        private Label label10;
        private Label label16;
        private ListBox lstOyuncular;
        private GroupBox groupBox3;
        private Button btnVerileriYenile;
        private Label lblToplamHasilat;
        private Label lblToplamBosKoltukSayisi;
        private Label lblSatKoltukSayisi;
        private Label label17;
        private Label label18;
        private Label label19;
    }
}