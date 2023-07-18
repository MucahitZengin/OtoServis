using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtoServis
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private SqlConnection connection;
        private SqlCommand komut;
        private SqlDataAdapter da;

        private int genericMusteriID;
        private int genericAracID;
        private int genericIslemID;
        private decimal genericKalanBorc;
        private bool ilkOdemeMi;

        public void frmAnasayfa_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=DESKTOP-LLVV909; Database=OtoServis; integrated security=true;";
                connection = new SqlConnection(connectionString);
                connection.Open();
                // Baðlantý baþarýlý bir þekilde kurulduðunda yapýlmasý gereken iþlemler buraya yazýlabilir.
                //MessageBox.Show("SQL baðlantýsý kuruldu");
                connection.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda yapýlacak iþlemler buraya yazýlabilir.
                MessageBox.Show("SQL baðlantýsý kurulamadý. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            if (pnlMusteri.Visible == true)
            {
                pnlMusteri.Visible = false;
            }
            else
            {
                btnMusteri.BackColor = Color.Linen;

                btnArac.BackColor = Color.FromArgb(34, 36, 48);
                btnIslemler.BackColor = Color.FromArgb(34, 36, 48);
                btnOdeme.BackColor = Color.FromArgb(34, 36, 48);

                pnlMusteri.Visible = true;
                pnlArac.Visible = false;
                pnlIslemler.Visible = false;
                pnlOdeme.Visible = false;

                string query = "SELECT * FROM tbl_Musteriler";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgwMusteriler.DataSource = dataTable;

                reader.Close();
                connection.Close();

                if (dgwMusteriler.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgwMusteriler.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgwMusteriler.Rows[selectedRowIndex];
                    string cellValue = Convert.ToString(selectedRow.Cells["Adi"].Value);
                    txtMusteriAdi.Text = cellValue;
                }
                else
                {
                    // Seçili hücre yoksa iþlem yapma veya kullanýcýya uyarý mesajý gösterme
                }
            }
        }

        private void btnArac_Click(object sender, EventArgs e)
        {
            if (pnlArac.Visible == true)
            {
                pnlArac.Visible = false;
            }
            else
            {
                btnArac.BackColor = Color.Linen;

                btnMusteri.BackColor = Color.FromArgb(34, 36, 48);
                btnIslemler.BackColor = Color.FromArgb(34, 36, 48);
                btnOdeme.BackColor = Color.FromArgb(34, 36, 48);

                pnlMusteri.Visible = false;
                pnlArac.Visible = true;
                pnlIslemler.Visible = false;
                pnlOdeme.Visible = false;
            }
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            if (pnlIslemler.Visible == true)
            {
                pnlIslemler.Visible = false;
            }
            else
            {
                btnIslemler.BackColor = Color.Linen;

                btnMusteri.BackColor = Color.FromArgb(34, 36, 48);
                btnArac.BackColor = Color.FromArgb(34, 36, 48);
                btnOdeme.BackColor = Color.FromArgb(34, 36, 48);

                pnlMusteri.Visible = false;
                pnlArac.Visible = false;
                pnlIslemler.Visible = true;
                pnlOdeme.Visible = false;
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (pnlOdeme.Visible == true)
            {
                pnlOdeme.Visible = false;
            }
            else
            {
                btnOdeme.BackColor = Color.Linen;

                btnMusteri.BackColor = Color.FromArgb(34, 36, 48);
                btnArac.BackColor = Color.FromArgb(34, 36, 48);
                btnIslemler.BackColor = Color.FromArgb(34, 36, 48);

                pnlMusteri.Visible = false;
                pnlArac.Visible = false;
                pnlIslemler.Visible = false;
                pnlOdeme.Visible = true;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        private void dgwMusteriler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriAdi.Text = dgwMusteriler.CurrentRow.Cells[1].Value.ToString();
            txtMusteriSoyad.Text = dgwMusteriler.CurrentRow.Cells[2].Value.ToString();
            txtMusteriAdres.Text = dgwMusteriler.CurrentRow.Cells[3].Value.ToString();
            txtMusteriTelefon.Text = dgwMusteriler.CurrentRow.Cells[4].Value.ToString();
            txtMusteriEposta.Text = dgwMusteriler.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO tbl_Musteriler(Adi, Soyadi, Adres, Telefon, Eposta) " +
                           "VALUES (@adi, @soyadi, @adres, @telefon, @eposta)";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@adi", txtMusteriAdi.Text);
            komut.Parameters.AddWithValue("@soyadi", txtMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@adres", txtMusteriAdres.Text);
            komut.Parameters.AddWithValue("@telefon", txtMusteriTelefon.Text);
            komut.Parameters.AddWithValue("@eposta", txtMusteriEposta.Text);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            MusteriGetir();
        }

        void MusteriGetir()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_musteriler", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgwMusteriler.DataSource = tablo;
            connection.Close();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            int seciliSatirIndex = dgwMusteriler.SelectedCells[0].RowIndex;
            int musteriID = Convert.ToInt32(dgwMusteriler.Rows[seciliSatirIndex].Cells["MusteriID"].Value);

            string sorgu = "DELETE FROM tbl_Musteriler WHERE MusteriID =@musteriID";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@musteriID", musteriID);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            MusteriGetir();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            int seciliSatirIndex = dgwMusteriler.SelectedCells[0].RowIndex;
            int musteriID = Convert.ToInt32(dgwMusteriler.Rows[seciliSatirIndex].Cells["MusteriID"].Value);

            string sorgu = "UPDATE tbl_Musteriler SET Adi = @adi, Soyadi = @soyadi, Adres = @adres, Telefon = @telefon, Eposta = @eposta WHERE MusteriID = @musteriID";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@musteriID", musteriID);
            komut.Parameters.AddWithValue("@adi", txtMusteriAdi.Text);
            komut.Parameters.AddWithValue("@soyadi", txtMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@adres", txtMusteriAdres.Text);
            komut.Parameters.AddWithValue("@telefon", txtMusteriTelefon.Text);
            komut.Parameters.AddWithValue("@eposta", txtMusteriEposta.Text);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            MusteriGetir();
        }

        private void btnMusteriAraclar_Click(object sender, EventArgs e)
        {
            int seciliSatirIndex = dgwMusteriler.SelectedCells[0].RowIndex;
            int musteriID = Convert.ToInt32(dgwMusteriler.Rows[seciliSatirIndex].Cells["MusteriID"].Value);
            string? musteriAdi = dgwMusteriler.Rows[seciliSatirIndex].Cells["Adi"].Value.ToString();
            string? musteriSoyadi = dgwMusteriler.Rows[seciliSatirIndex].Cells["Soyadi"].Value.ToString();

            genericMusteriID = musteriID;

            if (pnlArac.Visible == true) //panel açýksa kapat
            {
                pnlArac.Visible = false;
            }
            else //deðilse aç 
            {
                btnArac.BackColor = Color.Linen; //buton rengini deðiþtir

                btnMusteri.BackColor = Color.FromArgb(34, 36, 48); //digerlerini default yap
                btnIslemler.BackColor = Color.FromArgb(34, 36, 48);
                btnOdeme.BackColor = Color.FromArgb(34, 36, 48);

                pnlMusteri.Visible = false; //diðer panelleri kapat
                pnlArac.Visible = true;
                pnlIslemler.Visible = false;
                pnlOdeme.Visible = false;

                lblAracMusteriAdiSoyadi.Text = "Müþteri: " + musteriAdi + " " + musteriSoyadi; //hangi müsterinin araclarý

                string query = "SELECT * FROM tbl_Arabalar WHERE MusteriID = @musteriID"; //o musterinin araçlarýný getir
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@musteriID", musteriID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //connection.Close();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgwArabalar.DataSource = dataTable; //data gridviewa doldur

                reader.Close(); //kapatma iþlemleri
                connection.Close();

                if (dgwArabalar.SelectedCells.Count > 0) //datagridview boþ deðilse
                {
                    int selectedRowIndex = dgwArabalar.SelectedCells[0].RowIndex; //ilk satýrý seç
                    DataGridViewRow selectedRow = dgwArabalar.Rows[selectedRowIndex];
                    //string? cellValue = Convert.ToString(selectedRow.Cells["Marka"].Value);
                    //txtAracMarka.Text = cellValue;
                }
                else
                {
                    // Seçili hücre yoksa iþlem yapma veya kullanýcýya uyarý mesajý gösterme
                }
            }
        }

        private void dgwArabalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAracMarka.Text = dgwArabalar.CurrentRow.Cells[2].Value.ToString();
            txtAracModel.Text = dgwArabalar.CurrentRow.Cells[3].Value.ToString();
            txtAracPlaka.Text = dgwArabalar.CurrentRow.Cells[4].Value.ToString();
            txtAracUretimYili.Text = dgwArabalar.CurrentRow.Cells[5].Value.ToString();
            txtAracMotorTipi.Text = dgwArabalar.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO tbl_Arabalar(MusteriID, Marka, Model, Plaka, UretimYili, MotorTipi) " +
                           "VALUES (@musteriID, @marka, @model, @plaka, @uretimYili, @motorTipi)";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@musteriID", genericMusteriID);
            komut.Parameters.AddWithValue("@marka", txtAracMarka.Text);
            komut.Parameters.AddWithValue("@model", txtAracModel.Text);
            komut.Parameters.AddWithValue("@plaka", txtAracPlaka.Text);
            komut.Parameters.AddWithValue("@uretimYili", txtAracUretimYili.Text);
            komut.Parameters.AddWithValue("@motorTipi", txtAracMotorTipi.Text);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            AracGetir();
        }

        void AracGetir()
        {
            int seciliSatirIndex = dgwMusteriler.SelectedCells[0].RowIndex;
            int musteriID = Convert.ToInt32(dgwMusteriler.Rows[seciliSatirIndex].Cells["MusteriID"].Value);

            string query = "SELECT * FROM tbl_Arabalar WHERE MusteriID = @musteriID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@musteriID", musteriID);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            //connection.Close();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgwArabalar.DataSource = dataTable;

            reader.Close();
            connection.Close();

            if (dgwArabalar.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgwArabalar.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgwArabalar.Rows[selectedRowIndex];
            }
            else
            {
                // Seçili hücre yoksa iþlem yapma veya kullanýcýya uyarý mesajý gösterme
            }
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            int seciliSatirIndex = dgwArabalar.SelectedCells[0].RowIndex;
            int arabaID = Convert.ToInt32(dgwArabalar.Rows[seciliSatirIndex].Cells["ArabaID"].Value);

            string sorgu = "DELETE FROM tbl_Arabalar WHERE ArabaID =@arabaID";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@arabaID", arabaID);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            AracGetir();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            int seciliSatirIndex = dgwArabalar.SelectedCells[0].RowIndex;
            int arabaID = Convert.ToInt32(dgwArabalar.Rows[seciliSatirIndex].Cells["ArabaID"].Value);

            string sorgu = "UPDATE tbl_Arabalar SET Marka = @marka, Model = @model, Plaka = @plaka, UretimYili = @uretimYili, MotorTipi = @motorTipi WHERE ArabaID = @arabaID";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@arabaID", arabaID);
            komut.Parameters.AddWithValue("@marka", txtAracMarka.Text);
            komut.Parameters.AddWithValue("@model", txtAracModel.Text);
            komut.Parameters.AddWithValue("@plaka", txtAracPlaka.Text);
            komut.Parameters.AddWithValue("@uretimYili", txtAracUretimYili.Text);
            komut.Parameters.AddWithValue("@motorTipi", txtAracMotorTipi.Text);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            AracGetir();
        }

        private void btnAracIslemler_Click(object sender, EventArgs e)
        {
            int seciliSatirIndex = dgwArabalar.SelectedCells[0].RowIndex;
            int arabaID = Convert.ToInt32(dgwArabalar.Rows[seciliSatirIndex].Cells["ArabaID"].Value);
            string? arabaMarka = dgwArabalar.Rows[seciliSatirIndex].Cells["Marka"].Value.ToString();
            string? arabaModel = dgwArabalar.Rows[seciliSatirIndex].Cells["Model"].Value.ToString();

            genericAracID = arabaID;

            if (pnlIslemler.Visible == true)
            {
                pnlIslemler.Visible = false;
            }
            else
            {
                btnIslemler.BackColor = Color.Linen;

                btnMusteri.BackColor = Color.FromArgb(34, 36, 48);
                btnArac.BackColor = Color.FromArgb(34, 36, 48);
                btnOdeme.BackColor = Color.FromArgb(34, 36, 48);

                pnlMusteri.Visible = false;
                pnlArac.Visible = false;
                pnlIslemler.Visible = true;
                pnlOdeme.Visible = false;

                lblIslemAracMarkaModel.Text = "Araç: " + arabaMarka + " " + arabaModel;

                //

                string query = "SELECT * FROM tbl_Islemler WHERE ArabaID = @arabaID"; //seçili arabaya ait iþlemleri getir
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@arabaID", arabaID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //connection.Close();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgwIslemler.DataSource = dataTable; //datagridviewa doldur

                reader.Close();
                connection.Close();

                if (dgwIslemler.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgwIslemler.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgwIslemler.Rows[selectedRowIndex];
                    //string? cellValue = Convert.ToString(selectedRow.Cells["Marka"].Value);
                    //txtAracMarka.Text = cellValue;
                }
                else
                {
                    // Seçili hücre yoksa iþlem yapma veya kullanýcýya uyarý mesajý gösterme
                }
            }
        }

        private void btnIslemlerIslemYap_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu iþlem geri alýnamaz. Emin misiniz?", "Ýþlem Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string sorgu = "INSERT INTO tbl_Islemler(ArabaID, IslemAciklamasi, IslemTarihi, IslemUcreti) " +
                           "VALUES (@arabaID, @islemAciklamasi, @islemTarihi, @islemUcreti)";
                komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@arabaID", genericAracID);
                komut.Parameters.AddWithValue("@islemAciklamasi", txtIslemlerIslemAciklamasi.Text);
                komut.Parameters.AddWithValue("@islemTarihi", DateTime.Now);
                komut.Parameters.AddWithValue("@islemUcreti", txtIslemlerIslemUcreti.Text);

                connection.Open();
                komut.ExecuteNonQuery();
                connection.Close();

                IslemlerGetir(GetArabaID());
            }              
        }

        private int GetArabaID()
        {
            return genericAracID;
        }

        void IslemlerGetir(int arabaID)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Islemler WHERE ArabaID = @arabaID", connection);
            da.SelectCommand.Parameters.AddWithValue("@arabaID", arabaID);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgwIslemler.DataSource = tablo;
            connection.Close();
        }

        private void btnIslemlerOdemeYap_Click(object sender, EventArgs e)
        {
            int seciliSatirIndex = dgwIslemler.SelectedCells[0].RowIndex;
            int islemID = Convert.ToInt32(dgwIslemler.Rows[seciliSatirIndex].Cells["IslemID"].Value);
            string? islemAciklamasi = dgwIslemler.Rows[seciliSatirIndex].Cells["IslemAciklamasi"].Value.ToString();
            decimal islemUcreti = decimal.Parse(dgwIslemler.Rows[seciliSatirIndex].Cells["IslemUcreti"].Value.ToString());

            genericIslemID = islemID;

            if (pnlOdeme.Visible == true)
            {
                pnlOdeme.Visible = false;
            }
            else
            {
                btnOdeme.BackColor = Color.Linen;

                btnMusteri.BackColor = Color.FromArgb(34, 36, 48);
                btnArac.BackColor = Color.FromArgb(34, 36, 48);
                btnIslemler.BackColor = Color.FromArgb(34, 36, 48);

                pnlMusteri.Visible = false;
                pnlArac.Visible = false;
                pnlIslemler.Visible = false;
                pnlOdeme.Visible = true;

                string query = "SELECT COUNT(*) FROM tbl_Odemeler WHERE IslemID = @islemID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@islemID", islemID);
                connection.Open();
                int odemeSayisi = (int)command.ExecuteScalar();
                

                decimal kalanBorc;

                if (odemeSayisi > 0)
                {
                    // Daha önce en az bir ödeme yapýldýysa kalan borcu Ödemeler tablosundan alýn
                    query = "SELECT TOP 1 KalanBorc FROM tbl_Odemeler WHERE IslemID = @islemID ORDER BY OdemeTarihi DESC";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@islemID", islemID);
                    kalanBorc = (decimal)command.ExecuteScalar();
                    ilkOdemeMi = false;
                }
                else
                {
                    // Hiç ödeme yapýlmadýysa kalan borç Ýþlem Ücreti deðerine eþittir
                    kalanBorc = islemUcreti;
                    ilkOdemeMi = true;
                }
                connection.Close();

                lblOdemeIslemAciklamasi.Text = "Ýþlem Açýklamasý:     " + islemAciklamasi;
                lblOdemeIslemUcreti.Text = "Ýþlem Ücreti:     " + islemUcreti;
                lblOdemeKalanBorc.Text = "Kalan Borç:     " + kalanBorc;

                genericKalanBorc = kalanBorc;
            }
        }

        private void btnOdemeOdemeYap_Click(object sender, EventArgs e)
        {
            decimal odemeMiktari = decimal.Parse(txtOdemeOdemeMiktari.Text);

            if (!(odemeMiktari > genericKalanBorc))
            {
                string sorgu = "INSERT INTO tbl_Odemeler(IslemID, KalanBorc, OdemeMiktari, OdemeTarihi) " +
                       "VALUES (@islemID, @kalanBorc, @odemeMiktari, @odemeTarihi)";
                komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@islemID", genericIslemID);
                komut.Parameters.AddWithValue("@kalanBorc", genericKalanBorc - odemeMiktari);
                komut.Parameters.AddWithValue("@odemeMiktari", txtOdemeOdemeMiktari.Text);
                komut.Parameters.AddWithValue("@odemeTarihi", DateTime.Now);

                connection.Open();
                komut.ExecuteNonQuery();
                connection.Close();

                string sorgu2 = "SELECT KalanBorc FROM tbl_Odemeler WHERE IslemID = @islemID ORDER BY OdemeTarihi DESC";
                komut = new SqlCommand(sorgu2, connection);
                komut.Parameters.AddWithValue("@islemID", genericIslemID);

                connection.Open();
                decimal guncelKalanBorc = (decimal)komut.ExecuteScalar();
                connection.Close();

                MessageBox.Show("Ödeme baþarýyla tamamlandý. Kalan borcunuz: " + guncelKalanBorc);
            }
            else
            {
                MessageBox.Show("Borç miktarýndan fazla odeme yapamazsýnýz.");
            }
            txtOdemeOdemeMiktari.Text = "";
        }
    }
}