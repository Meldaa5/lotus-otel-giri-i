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
namespace lotus_pansiyon_ve_dinlenme_tesisleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GT3IQDQ;Initial Catalog=loginekranı;Integrated Security=True"); 
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text == "")
            {
                MessageBox.Show("lütfen boş alan bırakmayınız");
            }
            else
            {

           
            baglanti.Open();
            string user;
            string password;
            user = textBox1.Text;
            password = textBox2.Text;
            SqlCommand komut = new SqlCommand("select *from users where kullanici='" + user + "'and sifre='" + password + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("HOŞGELDİN  " + user.ToUpper() + "");
            
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre..");
            }


            baglanti.Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        

          Frmsifreguncelle şifreguncelle = new Frmsifreguncelle();
           şifreguncelle.Show();
                
        }
    }
}
