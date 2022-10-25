using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace lotus_pansiyon_ve_dinlenme_tesisleri
{
    public partial class Frmsifreguncelle : Form
    {
        public Frmsifreguncelle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
       public static  string dogrulamaKodu;

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double deger = random.Next(10000, 100000);
            dogrulamaKodu = deger.ToString();
 MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("meldaca.49@gmail.com", "pwnsuxwuzfcmustx");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(textBoxmail.Text);
            mesajım.From = new MailAddress("meldaca.49@gmail.com");
            mesajım.Subject = "Şifre sıfırlama";
            mesajım.Body = dogrulamaKodu;
            istemci.Send(mesajım);
            Doğrulama doğrulama = new Doğrulama();
            doğrulama.Show();
            this.Hide();

        }

        private void Frmsifreguncelle_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
