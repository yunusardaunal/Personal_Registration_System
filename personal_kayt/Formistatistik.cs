using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;


namespace personal_kayt
{
    public partial class Formistatistik : Form
    {

        
        public Formistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=YunusArdaUnal;Initial Catalog=PersonalVeriTabani;Integrated Security=True;Encrypt=False");
        private void Forrmistatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglanti.Open();

            SqlCommand komut1=new SqlCommand("Select Count(*) From Tbl_Personal",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                LblToplamPersonel.Text= dr1[0].ToString();
             }
           baglanti.Close();

            //Evli Personel Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personal where PerDurum=1",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) 
            { 
            LblEvliPersonel.Text= dr2[0].ToString();
            }

            baglanti.Close();

            //Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personal where Perdurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }

            baglanti.Close();

            //Farklı Şehir Sayısı

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personal", baglanti);
            SqlDataReader dr4 =komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblFarklıSehir.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Maaş
            baglanti.Open();
            SqlCommand komut5= new SqlCommand("Select Sum(PerMaas) From Tbl_Personal", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblToplamMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //Ortalama Maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personal", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            { 
            LblOrtalamaMaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }

        private void LblToplamPersonel_Click(object sender, EventArgs e)
        {

        }
    }
}
