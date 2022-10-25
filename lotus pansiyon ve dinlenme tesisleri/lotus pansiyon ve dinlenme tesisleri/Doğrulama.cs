using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotus_pansiyon_ve_dinlenme_tesisleri
{
    public partial class Doğrulama : Form
    {
        public Doğrulama()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDogrulamaBtn_Click(object sender, EventArgs e)
        {
            if (textDogrulama.Text.Equals(Frmsifreguncelle.dogrulamaKodu))
            {
                Console.WriteLine();
                MessageBox.Show("Doğrulama kodu dogrulandı");
            }
            else
            {

                MessageBox.Show("Doğrulama kodu hatalı.");
            }
        }
    }
}
