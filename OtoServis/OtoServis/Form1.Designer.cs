namespace OtoServis
{
    partial class frmAnasayfa
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
            pnlYan = new Panel();
            btnArac = new Button();
            btnOdeme = new Button();
            btnCikis = new Button();
            btnIslemler = new Button();
            btnMusteri = new Button();
            pnlMusteri = new Panel();
            label18 = new Label();
            txtMusteriEposta = new TextBox();
            label17 = new Label();
            txtMusteriTelefon = new TextBox();
            btnMusteriAraclar = new Button();
            btnMusteriGuncelle = new Button();
            btnMusteriSil = new Button();
            btnMusteriEkle = new Button();
            label3 = new Label();
            txtMusteriAdres = new TextBox();
            label2 = new Label();
            txtMusteriSoyad = new TextBox();
            label1 = new Label();
            txtMusteriAdi = new TextBox();
            dgwMusteriler = new DataGridView();
            pnlArac = new Panel();
            txtAracMotorTipi = new TextBox();
            label6 = new Label();
            txtAracUretimYili = new TextBox();
            label4 = new Label();
            txtAracPlaka = new TextBox();
            label5 = new Label();
            btnAracIslemler = new Button();
            btnAracGuncelle = new Button();
            btnAracSil = new Button();
            btnAracEkle = new Button();
            txtAracModel = new TextBox();
            label8 = new Label();
            txtAracMarka = new TextBox();
            label7 = new Label();
            dgwArabalar = new DataGridView();
            lblAracMusteriAdiSoyadi = new Label();
            pnlIslemler = new Panel();
            btnIslemlerOdemeYap = new Button();
            btnIslemlerIslemYap = new Button();
            label12 = new Label();
            txtIslemlerIslemUcreti = new TextBox();
            label11 = new Label();
            txtIslemlerIslemAciklamasi = new TextBox();
            dgwIslemler = new DataGridView();
            lblIslemAracMarkaModel = new Label();
            pnlOdeme = new Panel();
            btnOdemeOdemeYap = new Button();
            txtOdemeOdemeMiktari = new TextBox();
            label16 = new Label();
            lblOdemeKalanBorc = new Label();
            lblOdemeIslemUcreti = new Label();
            lblOdemeIslemAciklamasi = new Label();
            pnlYan.SuspendLayout();
            pnlMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMusteriler).BeginInit();
            pnlArac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwArabalar).BeginInit();
            pnlIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwIslemler).BeginInit();
            pnlOdeme.SuspendLayout();
            SuspendLayout();
            // 
            // pnlYan
            // 
            pnlYan.BackColor = Color.FromArgb(34, 36, 48);
            pnlYan.Controls.Add(btnArac);
            pnlYan.Controls.Add(btnOdeme);
            pnlYan.Controls.Add(btnCikis);
            pnlYan.Controls.Add(btnIslemler);
            pnlYan.Controls.Add(btnMusteri);
            pnlYan.Dock = DockStyle.Left;
            pnlYan.ForeColor = Color.CornflowerBlue;
            pnlYan.Location = new Point(0, 0);
            pnlYan.Name = "pnlYan";
            pnlYan.Size = new Size(250, 684);
            pnlYan.TabIndex = 0;
            // 
            // btnArac
            // 
            btnArac.BackColor = Color.FromArgb(34, 36, 48);
            btnArac.Cursor = Cursors.Hand;
            btnArac.FlatAppearance.BorderSize = 0;
            btnArac.FlatStyle = FlatStyle.Flat;
            btnArac.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnArac.ForeColor = Color.FromArgb(255, 192, 128);
            btnArac.Location = new Point(0, 96);
            btnArac.Name = "btnArac";
            btnArac.Size = new Size(250, 90);
            btnArac.TabIndex = 5;
            btnArac.Text = "Araç";
            btnArac.UseVisualStyleBackColor = false;
            btnArac.Click += btnArac_Click;
            // 
            // btnOdeme
            // 
            btnOdeme.BackColor = Color.FromArgb(34, 36, 48);
            btnOdeme.Cursor = Cursors.Hand;
            btnOdeme.FlatAppearance.BorderSize = 0;
            btnOdeme.FlatStyle = FlatStyle.Flat;
            btnOdeme.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdeme.ForeColor = Color.FromArgb(192, 255, 255);
            btnOdeme.Location = new Point(0, 291);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(250, 90);
            btnOdeme.TabIndex = 3;
            btnOdeme.Text = "Ödeme";
            btnOdeme.UseVisualStyleBackColor = false;
            btnOdeme.Click += btnOdeme_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(34, 36, 48);
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Tomato;
            btnCikis.Location = new Point(0, 387);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(250, 90);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnIslemler
            // 
            btnIslemler.BackColor = Color.FromArgb(34, 36, 48);
            btnIslemler.Cursor = Cursors.Hand;
            btnIslemler.FlatAppearance.BorderSize = 0;
            btnIslemler.FlatStyle = FlatStyle.Flat;
            btnIslemler.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnIslemler.ForeColor = Color.FromArgb(192, 255, 192);
            btnIslemler.Location = new Point(0, 195);
            btnIslemler.Name = "btnIslemler";
            btnIslemler.Size = new Size(250, 90);
            btnIslemler.TabIndex = 2;
            btnIslemler.Text = "İşlemler";
            btnIslemler.UseVisualStyleBackColor = false;
            btnIslemler.Click += btnIslemler_Click;
            // 
            // btnMusteri
            // 
            btnMusteri.BackColor = Color.FromArgb(34, 36, 48);
            btnMusteri.Cursor = Cursors.Hand;
            btnMusteri.FlatAppearance.BorderSize = 0;
            btnMusteri.FlatStyle = FlatStyle.Flat;
            btnMusteri.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteri.ForeColor = Color.FromArgb(255, 192, 192);
            btnMusteri.Location = new Point(0, 0);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(250, 90);
            btnMusteri.TabIndex = 1;
            btnMusteri.Text = "Müşteri";
            btnMusteri.UseVisualStyleBackColor = false;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // pnlMusteri
            // 
            pnlMusteri.BackColor = Color.FromArgb(255, 192, 192);
            pnlMusteri.Controls.Add(label18);
            pnlMusteri.Controls.Add(txtMusteriEposta);
            pnlMusteri.Controls.Add(label17);
            pnlMusteri.Controls.Add(txtMusteriTelefon);
            pnlMusteri.Controls.Add(btnMusteriAraclar);
            pnlMusteri.Controls.Add(btnMusteriGuncelle);
            pnlMusteri.Controls.Add(btnMusteriSil);
            pnlMusteri.Controls.Add(btnMusteriEkle);
            pnlMusteri.Controls.Add(label3);
            pnlMusteri.Controls.Add(txtMusteriAdres);
            pnlMusteri.Controls.Add(label2);
            pnlMusteri.Controls.Add(txtMusteriSoyad);
            pnlMusteri.Controls.Add(label1);
            pnlMusteri.Controls.Add(txtMusteriAdi);
            pnlMusteri.Controls.Add(dgwMusteriler);
            pnlMusteri.Dock = DockStyle.Fill;
            pnlMusteri.Location = new Point(250, 0);
            pnlMusteri.Name = "pnlMusteri";
            pnlMusteri.Size = new Size(1071, 684);
            pnlMusteri.TabIndex = 1;
            pnlMusteri.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(64, 505);
            label18.Name = "label18";
            label18.Size = new Size(57, 20);
            label18.TabIndex = 14;
            label18.Text = "Eposta:";
            // 
            // txtMusteriEposta
            // 
            txtMusteriEposta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMusteriEposta.Location = new Point(200, 500);
            txtMusteriEposta.Name = "txtMusteriEposta";
            txtMusteriEposta.Size = new Size(312, 30);
            txtMusteriEposta.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(60, 455);
            label17.Name = "label17";
            label17.Size = new Size(61, 20);
            label17.TabIndex = 12;
            label17.Text = "Telefon:";
            // 
            // txtMusteriTelefon
            // 
            txtMusteriTelefon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMusteriTelefon.Location = new Point(200, 450);
            txtMusteriTelefon.Name = "txtMusteriTelefon";
            txtMusteriTelefon.Size = new Size(312, 30);
            txtMusteriTelefon.TabIndex = 11;
            // 
            // btnMusteriAraclar
            // 
            btnMusteriAraclar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriAraclar.Location = new Point(618, 490);
            btnMusteriAraclar.Name = "btnMusteriAraclar";
            btnMusteriAraclar.Size = new Size(372, 40);
            btnMusteriAraclar.TabIndex = 10;
            btnMusteriAraclar.Text = "Araçlar";
            btnMusteriAraclar.UseVisualStyleBackColor = true;
            btnMusteriAraclar.Click += btnMusteriAraclar_Click;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriGuncelle.Location = new Point(618, 426);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new Size(372, 40);
            btnMusteriGuncelle.TabIndex = 9;
            btnMusteriGuncelle.Text = "Güncelle";
            btnMusteriGuncelle.UseVisualStyleBackColor = true;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriSil.Location = new Point(618, 361);
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.Size = new Size(372, 40);
            btnMusteriSil.TabIndex = 8;
            btnMusteriSil.Text = "Sil";
            btnMusteriSil.UseVisualStyleBackColor = true;
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriEkle.Location = new Point(618, 300);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(372, 40);
            btnMusteriEkle.TabIndex = 7;
            btnMusteriEkle.Text = "Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 405);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Adres:";
            // 
            // txtMusteriAdres
            // 
            txtMusteriAdres.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMusteriAdres.Location = new Point(200, 400);
            txtMusteriAdres.Name = "txtMusteriAdres";
            txtMusteriAdres.Size = new Size(312, 30);
            txtMusteriAdres.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 355);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Soyadı:";
            // 
            // txtMusteriSoyad
            // 
            txtMusteriSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMusteriSoyad.Location = new Point(200, 350);
            txtMusteriSoyad.Name = "txtMusteriSoyad";
            txtMusteriSoyad.Size = new Size(312, 30);
            txtMusteriSoyad.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 305);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "Adı:";
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMusteriAdi.Location = new Point(200, 300);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(312, 30);
            txtMusteriAdi.TabIndex = 1;
            // 
            // dgwMusteriler
            // 
            dgwMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMusteriler.Location = new Point(60, 64);
            dgwMusteriler.Name = "dgwMusteriler";
            dgwMusteriler.RowHeadersWidth = 51;
            dgwMusteriler.RowTemplate.Height = 29;
            dgwMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwMusteriler.Size = new Size(930, 190);
            dgwMusteriler.TabIndex = 0;
            dgwMusteriler.CellEnter += dgwMusteriler_CellEnter;
            // 
            // pnlArac
            // 
            pnlArac.BackColor = Color.FromArgb(255, 192, 128);
            pnlArac.Controls.Add(txtAracMotorTipi);
            pnlArac.Controls.Add(label6);
            pnlArac.Controls.Add(txtAracUretimYili);
            pnlArac.Controls.Add(label4);
            pnlArac.Controls.Add(txtAracPlaka);
            pnlArac.Controls.Add(label5);
            pnlArac.Controls.Add(btnAracIslemler);
            pnlArac.Controls.Add(btnAracGuncelle);
            pnlArac.Controls.Add(btnAracSil);
            pnlArac.Controls.Add(btnAracEkle);
            pnlArac.Controls.Add(txtAracModel);
            pnlArac.Controls.Add(label8);
            pnlArac.Controls.Add(txtAracMarka);
            pnlArac.Controls.Add(label7);
            pnlArac.Controls.Add(dgwArabalar);
            pnlArac.Controls.Add(lblAracMusteriAdiSoyadi);
            pnlArac.Dock = DockStyle.Fill;
            pnlArac.Location = new Point(250, 0);
            pnlArac.Name = "pnlArac";
            pnlArac.Size = new Size(1071, 684);
            pnlArac.TabIndex = 11;
            pnlArac.Visible = false;
            // 
            // txtAracMotorTipi
            // 
            txtAracMotorTipi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAracMotorTipi.Location = new Point(200, 500);
            txtAracMotorTipi.Name = "txtAracMotorTipi";
            txtAracMotorTipi.Size = new Size(312, 30);
            txtAracMotorTipi.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 505);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 16;
            label6.Text = "Motor Tipi:";
            // 
            // txtAracUretimYili
            // 
            txtAracUretimYili.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAracUretimYili.Location = new Point(200, 450);
            txtAracUretimYili.Name = "txtAracUretimYili";
            txtAracUretimYili.Size = new Size(312, 30);
            txtAracUretimYili.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 455);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 14;
            label4.Text = "Üretim Yılı:";
            // 
            // txtAracPlaka
            // 
            txtAracPlaka.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAracPlaka.Location = new Point(200, 400);
            txtAracPlaka.Name = "txtAracPlaka";
            txtAracPlaka.Size = new Size(312, 30);
            txtAracPlaka.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 405);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 12;
            label5.Text = "Plaka:";
            // 
            // btnAracIslemler
            // 
            btnAracIslemler.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAracIslemler.Location = new Point(618, 490);
            btnAracIslemler.Name = "btnAracIslemler";
            btnAracIslemler.Size = new Size(372, 40);
            btnAracIslemler.TabIndex = 11;
            btnAracIslemler.Text = "İşlemler";
            btnAracIslemler.UseVisualStyleBackColor = true;
            btnAracIslemler.Click += btnAracIslemler_Click;
            // 
            // btnAracGuncelle
            // 
            btnAracGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAracGuncelle.Location = new Point(618, 426);
            btnAracGuncelle.Name = "btnAracGuncelle";
            btnAracGuncelle.Size = new Size(372, 40);
            btnAracGuncelle.TabIndex = 10;
            btnAracGuncelle.Text = "Güncelle";
            btnAracGuncelle.UseVisualStyleBackColor = true;
            btnAracGuncelle.Click += btnAracGuncelle_Click;
            // 
            // btnAracSil
            // 
            btnAracSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAracSil.Location = new Point(618, 361);
            btnAracSil.Name = "btnAracSil";
            btnAracSil.Size = new Size(372, 40);
            btnAracSil.TabIndex = 9;
            btnAracSil.Text = "Sil";
            btnAracSil.UseVisualStyleBackColor = true;
            btnAracSil.Click += btnAracSil_Click;
            // 
            // btnAracEkle
            // 
            btnAracEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAracEkle.Location = new Point(618, 300);
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Size = new Size(372, 40);
            btnAracEkle.TabIndex = 8;
            btnAracEkle.Text = "Ekle";
            btnAracEkle.UseVisualStyleBackColor = true;
            btnAracEkle.Click += btnAracEkle_Click;
            // 
            // txtAracModel
            // 
            txtAracModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAracModel.Location = new Point(200, 350);
            txtAracModel.Name = "txtAracModel";
            txtAracModel.Size = new Size(312, 30);
            txtAracModel.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 355);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 6;
            label8.Text = "Model:";
            // 
            // txtAracMarka
            // 
            txtAracMarka.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAracMarka.Location = new Point(200, 300);
            txtAracMarka.Name = "txtAracMarka";
            txtAracMarka.Size = new Size(312, 30);
            txtAracMarka.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 305);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 4;
            label7.Text = "Marka:";
            // 
            // dgwArabalar
            // 
            dgwArabalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwArabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwArabalar.Location = new Point(60, 64);
            dgwArabalar.Name = "dgwArabalar";
            dgwArabalar.RowHeadersWidth = 51;
            dgwArabalar.RowTemplate.Height = 29;
            dgwArabalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwArabalar.Size = new Size(930, 190);
            dgwArabalar.TabIndex = 3;
            dgwArabalar.CellEnter += dgwArabalar_CellEnter;
            // 
            // lblAracMusteriAdiSoyadi
            // 
            lblAracMusteriAdiSoyadi.AutoSize = true;
            lblAracMusteriAdiSoyadi.Location = new Point(620, 22);
            lblAracMusteriAdiSoyadi.Name = "lblAracMusteriAdiSoyadi";
            lblAracMusteriAdiSoyadi.Size = new Size(61, 20);
            lblAracMusteriAdiSoyadi.TabIndex = 0;
            lblAracMusteriAdiSoyadi.Text = "Müşteri:";
            // 
            // pnlIslemler
            // 
            pnlIslemler.BackColor = Color.FromArgb(192, 255, 192);
            pnlIslemler.Controls.Add(btnIslemlerOdemeYap);
            pnlIslemler.Controls.Add(btnIslemlerIslemYap);
            pnlIslemler.Controls.Add(label12);
            pnlIslemler.Controls.Add(txtIslemlerIslemUcreti);
            pnlIslemler.Controls.Add(label11);
            pnlIslemler.Controls.Add(txtIslemlerIslemAciklamasi);
            pnlIslemler.Controls.Add(dgwIslemler);
            pnlIslemler.Controls.Add(lblIslemAracMarkaModel);
            pnlIslemler.Dock = DockStyle.Fill;
            pnlIslemler.Location = new Point(250, 0);
            pnlIslemler.Name = "pnlIslemler";
            pnlIslemler.Size = new Size(1071, 684);
            pnlIslemler.TabIndex = 12;
            pnlIslemler.Visible = false;
            // 
            // btnIslemlerOdemeYap
            // 
            btnIslemlerOdemeYap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnIslemlerOdemeYap.Location = new Point(618, 390);
            btnIslemlerOdemeYap.Name = "btnIslemlerOdemeYap";
            btnIslemlerOdemeYap.Size = new Size(372, 40);
            btnIslemlerOdemeYap.TabIndex = 8;
            btnIslemlerOdemeYap.Text = "Ödeme Yap";
            btnIslemlerOdemeYap.UseVisualStyleBackColor = true;
            btnIslemlerOdemeYap.Click += btnIslemlerOdemeYap_Click;
            // 
            // btnIslemlerIslemYap
            // 
            btnIslemlerIslemYap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnIslemlerIslemYap.Location = new Point(618, 300);
            btnIslemlerIslemYap.Name = "btnIslemlerIslemYap";
            btnIslemlerIslemYap.Size = new Size(372, 40);
            btnIslemlerIslemYap.TabIndex = 7;
            btnIslemlerIslemYap.Text = "İşlem Yap";
            btnIslemlerIslemYap.UseVisualStyleBackColor = true;
            btnIslemlerIslemYap.Click += btnIslemlerIslemYap_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(91, 405);
            label12.Name = "label12";
            label12.Size = new Size(90, 20);
            label12.TabIndex = 6;
            label12.Text = "İşlem Ücreti:";
            // 
            // txtIslemlerIslemUcreti
            // 
            txtIslemlerIslemUcreti.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIslemlerIslemUcreti.Location = new Point(200, 400);
            txtIslemlerIslemUcreti.Name = "txtIslemlerIslemUcreti";
            txtIslemlerIslemUcreti.Size = new Size(312, 30);
            txtIslemlerIslemUcreti.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(60, 305);
            label11.Name = "label11";
            label11.Size = new Size(122, 20);
            label11.TabIndex = 4;
            label11.Text = "İşlem Açıklaması:";
            // 
            // txtIslemlerIslemAciklamasi
            // 
            txtIslemlerIslemAciklamasi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIslemlerIslemAciklamasi.Location = new Point(200, 300);
            txtIslemlerIslemAciklamasi.Multiline = true;
            txtIslemlerIslemAciklamasi.Name = "txtIslemlerIslemAciklamasi";
            txtIslemlerIslemAciklamasi.Size = new Size(312, 90);
            txtIslemlerIslemAciklamasi.TabIndex = 3;
            // 
            // dgwIslemler
            // 
            dgwIslemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwIslemler.Location = new Point(60, 64);
            dgwIslemler.Name = "dgwIslemler";
            dgwIslemler.RowHeadersWidth = 51;
            dgwIslemler.RowTemplate.Height = 29;
            dgwIslemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwIslemler.Size = new Size(930, 190);
            dgwIslemler.TabIndex = 2;
            // 
            // lblIslemAracMarkaModel
            // 
            lblIslemAracMarkaModel.AutoSize = true;
            lblIslemAracMarkaModel.Location = new Point(620, 22);
            lblIslemAracMarkaModel.Name = "lblIslemAracMarkaModel";
            lblIslemAracMarkaModel.Size = new Size(42, 20);
            lblIslemAracMarkaModel.TabIndex = 0;
            lblIslemAracMarkaModel.Text = "Araç:";
            // 
            // pnlOdeme
            // 
            pnlOdeme.BackColor = Color.FromArgb(192, 255, 255);
            pnlOdeme.Controls.Add(btnOdemeOdemeYap);
            pnlOdeme.Controls.Add(txtOdemeOdemeMiktari);
            pnlOdeme.Controls.Add(label16);
            pnlOdeme.Controls.Add(lblOdemeKalanBorc);
            pnlOdeme.Controls.Add(lblOdemeIslemUcreti);
            pnlOdeme.Controls.Add(lblOdemeIslemAciklamasi);
            pnlOdeme.Dock = DockStyle.Fill;
            pnlOdeme.Location = new Point(250, 0);
            pnlOdeme.Name = "pnlOdeme";
            pnlOdeme.Size = new Size(1071, 684);
            pnlOdeme.TabIndex = 13;
            pnlOdeme.Visible = false;
            // 
            // btnOdemeOdemeYap
            // 
            btnOdemeOdemeYap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdemeOdemeYap.Location = new Point(618, 390);
            btnOdemeOdemeYap.Name = "btnOdemeOdemeYap";
            btnOdemeOdemeYap.Size = new Size(372, 40);
            btnOdemeOdemeYap.TabIndex = 5;
            btnOdemeOdemeYap.Text = "Ödeme Yap";
            btnOdemeOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeOdemeYap.Click += btnOdemeOdemeYap_Click;
            // 
            // txtOdemeOdemeMiktari
            // 
            txtOdemeOdemeMiktari.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtOdemeOdemeMiktari.Location = new Point(200, 400);
            txtOdemeOdemeMiktari.Name = "txtOdemeOdemeMiktari";
            txtOdemeOdemeMiktari.Size = new Size(312, 30);
            txtOdemeOdemeMiktari.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(70, 405);
            label16.Name = "label16";
            label16.Size = new Size(111, 20);
            label16.TabIndex = 3;
            label16.Text = "Ödeme Miktarı:";
            // 
            // lblOdemeKalanBorc
            // 
            lblOdemeKalanBorc.AutoSize = true;
            lblOdemeKalanBorc.Location = new Point(98, 355);
            lblOdemeKalanBorc.Name = "lblOdemeKalanBorc";
            lblOdemeKalanBorc.Size = new Size(83, 20);
            lblOdemeKalanBorc.TabIndex = 2;
            lblOdemeKalanBorc.Text = "Kalan Borç:";
            // 
            // lblOdemeIslemUcreti
            // 
            lblOdemeIslemUcreti.AutoSize = true;
            lblOdemeIslemUcreti.Location = new Point(91, 305);
            lblOdemeIslemUcreti.Name = "lblOdemeIslemUcreti";
            lblOdemeIslemUcreti.Size = new Size(90, 20);
            lblOdemeIslemUcreti.TabIndex = 1;
            lblOdemeIslemUcreti.Text = "İşlem Ücreti:";
            // 
            // lblOdemeIslemAciklamasi
            // 
            lblOdemeIslemAciklamasi.AutoSize = true;
            lblOdemeIslemAciklamasi.Location = new Point(59, 255);
            lblOdemeIslemAciklamasi.Name = "lblOdemeIslemAciklamasi";
            lblOdemeIslemAciklamasi.Size = new Size(122, 20);
            lblOdemeIslemAciklamasi.TabIndex = 0;
            lblOdemeIslemAciklamasi.Text = "İşlem Açıklaması:";
            // 
            // frmAnasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 50, 64);
            ClientSize = new Size(1321, 684);
            Controls.Add(pnlOdeme);
            Controls.Add(pnlMusteri);
            Controls.Add(pnlArac);
            Controls.Add(pnlIslemler);
            Controls.Add(pnlYan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAnasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmAnasayfa_Load;
            pnlYan.ResumeLayout(false);
            pnlMusteri.ResumeLayout(false);
            pnlMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMusteriler).EndInit();
            pnlArac.ResumeLayout(false);
            pnlArac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwArabalar).EndInit();
            pnlIslemler.ResumeLayout(false);
            pnlIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwIslemler).EndInit();
            pnlOdeme.ResumeLayout(false);
            pnlOdeme.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlYan;
        private Button btnMusteri;
        private Button btnOdeme;
        private Button btnIslemler;
        private Button btnCikis;
        private Button btnArac;
        private Panel pnlMusteri;
        private DataGridView dgwMusteriler;
        private Button btnMusteriAraclar;
        private Button btnMusteriGuncelle;
        private Button btnMusteriSil;
        private Button btnMusteriEkle;
        private Label label3;
        private TextBox txtMusteriAdres;
        private Label label2;
        private TextBox txtMusteriSoyad;
        private Label label1;
        private TextBox txtMusteriAdi;
        private Panel pnlArac;
        private Button btnAracIslemler;
        private Button btnAracGuncelle;
        private Button btnAracSil;
        private Button btnAracEkle;
        private TextBox txtAracModel;
        private Label label8;
        private TextBox txtAracMarka;
        private Label label7;
        private DataGridView dgwArabalar;
        private Label lblAracMusteriSoyadi;
        private Label lblAracMusteriAdiSoyadi;
        private Panel pnlIslemler;
        private Button btnIslemlerOdemeYap;
        private Button btnIslemlerIslemYap;
        private Label label12;
        private TextBox txtIslemlerIslemUcreti;
        private Label label11;
        private TextBox txtIslemlerIslemAciklamasi;
        private DataGridView dgwIslemler;
        private Label lblIslemAracMarkaModel;
        private Panel pnlOdeme;
        private Label lblOdemeKalanBorc;
        private Label lblOdemeIslemUcreti;
        private Label lblOdemeIslemAciklamasi;
        private Button btnOdemeOdemeYap;
        private TextBox txtOdemeOdemeMiktari;
        private Label label16;
        private Label label18;
        private TextBox txtMusteriEposta;
        private Label label17;
        private TextBox txtMusteriTelefon;
        private TextBox txtAracMotorTipi;
        private Label label6;
        private TextBox txtAracUretimYili;
        private Label label4;
        private TextBox txtAracPlaka;
        private Label label5;
    }
}