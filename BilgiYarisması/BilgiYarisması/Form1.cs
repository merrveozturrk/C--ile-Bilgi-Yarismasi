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

namespace BilgiYarisması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-4BVIJ10J\\MSSQLSERVER01;Database=BilgiYarismasiSoruHavuzu;Integrated Security=true");
        int sayac = 0;
        int puan = 0;
        int zaman = 20;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;
            btnA.BackColor = Color.White; btnB.BackColor=Color.White; btnC.BackColor=Color.White; btnD.BackColor=Color.White; 
            btnBasla.Enabled = false;
            btnA.Enabled = true; btnB.Enabled = true; btnC.Enabled = true; btnD.Enabled = true;
            sayac++;
            lblSoruSayisi.Text = sayac.ToString();
            btnBasla.Text = "Sonraki Soru";
            if (sayac==1)
            {

            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("Select * from soru7 order by NEWID()", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) 
            { 
                btnA.Text= oku["a"].ToString();
                btnB.Text= oku["b"].ToString();
                btnC.Text= oku["c"].ToString();
                btnD.Text= oku["d"].ToString();
                textBox1.Text = oku["soru"].ToString();
                lblDogru.Text = oku["dogru"].ToString();
            }
            if (baglanti.State==ConnectionState.Open)
            {
                baglanti.Close();
            }
            }
            if (sayac==2)
            {

            
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("Select * from soru2 order by NEWID()", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                btnA.Text = oku["a"].ToString();
                btnB.Text = oku["b"].ToString();
                btnC.Text = oku["c"].ToString();
                btnD.Text = oku["d"].ToString();
                textBox1.Text = oku["soru"].ToString();
                lblDogru.Text = oku["dogru"].ToString();
            }
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            }
            if (sayac == 3)
            {


                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("Select * from soru3 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    lblDogru.Text = oku["dogru"].ToString();
                }
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            if (sayac == 4)
            {


                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("Select * from soru4 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    lblDogru.Text = oku["dogru"].ToString();
                }
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            if (sayac == 5)
            {


                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("Select * from soru5 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    lblDogru.Text = oku["dogru"].ToString();
                }
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            if (sayac == 6)
            {
                btnBasla.Text = "Oyun Bitti";
                btnBasla.Enabled = true;

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("Select * from soru6 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    lblDogru.Text = oku["dogru"].ToString();
                }
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            if (sayac==7)
            {
                btnBasla.Text = "Oyun Bitti";
                textBox1.Clear();
                btnA.Text = "";
                btnA.BackColor = Color.Gray;
                btnB.Text = "";
                btnB.BackColor = Color.Gray;
                btnC.Text = "";
                btnC.BackColor = Color.Gray;
                btnD.Text = "";
                btnD.BackColor = Color.Gray;
                timer1.Enabled = false;
                
                if (Convert.ToInt32(lblPuan.Text)>30)
                {
                    MessageBox.Show($"Tebrikler Puanınız: {lblPuan.Text}. Bilgi Yarışmasını Başarılı Bir Şekilde Tamamladınız.");
                }
                else if (Convert.ToInt32(lblPuan.Text) <= 30)
                {
                    MessageBox.Show($"Puanınız: {lblPuan.Text}. Bilgi Yarışmasını Başarılı Bir Şekilde Tamamlayamadınız.");
                }
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSoruSayisi.Text = sayac.ToString();
            lblDogru.Visible = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text==lblDogru.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnA.BackColor = Color.GreenYellow;
            }
            else
            {
                btnA.BackColor = Color.Tomato;
            }
            
            btnBasla.Enabled = true;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {

            if (btnB.Text == lblDogru.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnB.BackColor = Color.GreenYellow;
            }
            else
            {
                btnB.BackColor = Color.Tomato;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            if (btnC.Text == lblDogru.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnC.BackColor = Color.GreenYellow;
            }
            else
            {
                btnC.BackColor = Color.Tomato;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {

            if (btnD.Text == lblDogru.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnD.BackColor = Color.GreenYellow;
            }
            else
            {
                btnD.BackColor = Color.Tomato;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false; btnB.Enabled=false; btnC.Enabled=false; btnD.Enabled=false;
        }

        private void lblDogru_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblSure.Text = zaman.ToString();
            if (zaman==0)
            {
                timer1.Enabled = false;
                btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false; btnBasla.Enabled = true;
            }
        }
    }
}
