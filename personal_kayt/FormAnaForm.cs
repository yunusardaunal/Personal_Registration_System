using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace personal_kayt
{
    public partial class FormAnaForm : Form
    {
        public FormAnaForm()
        {
            InitializeComponent();
        }

SqlConnection baglanti = new SqlConnection("Data Source=YunusArdaUnal;Initial Catalog=PersonalVeriTabani;Integrated Security=True;Encrypt=False");        
        void temizle() 
        {
            Txtid.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbSehir.Text = "";
            MskMaas.Text = "";
            TxtMeslek.Text = "";
            radioButton1.Checked=false;
            radioButton2.Checked=false;
            TxtAd.Focus();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.tbl_PersonalTableAdapter.Fill(this.personalVeriTabaniDataSet.Tbl_Personal);

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonalTableAdapter.Fill(this.personalVeriTabaniDataSet.Tbl_Personal);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Ad = TxtAd.Text;
            p.Soyad = TxtSoyad.Text;
            p.Meslek = TxtMeslek.Text;
            p.Sehir = CmbSehir.Text;
            p.MaasBelirle(Convert.ToInt32(MskMaas.Text));
            p.DurumBelirle(radioButton1.Checked); // Evli=true, Bekar=false

            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "insert into Tbl_Personal (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", p.Ad);
            komut.Parameters.AddWithValue("@p2", p.Soyad);
            komut.Parameters.AddWithValue("@p3", p.Sehir);
            komut.Parameters.AddWithValue("@p4", p.Maas);
            komut.Parameters.AddWithValue("@p5", p.Meslek);
            komut.Parameters.AddWithValue("@p6", p.Durum);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) 
            {
            label8.Text= "False";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[secilen ].Cells[4].Value.ToString();
            label8.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            bool durum = Convert.ToBoolean(label8.Text);
            radioButton1.Checked = durum;      // Evli
            radioButton2.Checked = !durum;     // Bekar
        }


        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil =new SqlCommand("Delete From Tbl_Personal where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", Txtid.Text);
            komutsil.ExecuteNonQuery(); 
            baglanti.Close();
            MessageBox.Show("Personel Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Ad = TxtAd.Text;
            p.Soyad = TxtSoyad.Text;
            p.Sehir = CmbSehir.Text;
            p.Meslek = TxtMeslek.Text;
            p.MaasBelirle(Convert.ToInt32(MskMaas.Text));
            p.DurumBelirle(radioButton1.Checked);

            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand(
                "Update Tbl_Personal set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7",
                baglanti);

            komutguncelle.Parameters.AddWithValue("@a1", p.Ad);
            komutguncelle.Parameters.AddWithValue("@a2", p.Soyad);
            komutguncelle.Parameters.AddWithValue("@a3", p.Sehir);
            komutguncelle.Parameters.AddWithValue("@a4", p.Maas);
            komutguncelle.Parameters.AddWithValue("@a5", p.Durum);
            komutguncelle.Parameters.AddWithValue("@a6", p.Meslek);
            komutguncelle.Parameters.AddWithValue("@a7", Txtid.Text);

            komutguncelle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel Güncellendi");
        }


        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            Formistatistik fr = new Formistatistik();
            fr.Show();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FormGrafikler frg= new FormGrafikler();
            frg.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
