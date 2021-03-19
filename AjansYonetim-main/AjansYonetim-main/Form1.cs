using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProjeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtBoxAd.Text == "mudur" && txtBoxSifre.Text == "mudur" && rdioBtnMudur.Checked == true)
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Closed += (s, args) => this.Close();
                frm2.Show();
            }
            else if (txtBoxAd.Text == "Volkan Yılmaz" && txtBoxSifre.Text == "1234" && rdioBtnMudurYardimcisi.Checked == true)
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Closed += (s, args) => this.Close();
                frm3.Show();
            }
            else if (txtBoxAd.Text == "Beliz Türkmen" && txtBoxSifre.Text == "123456" && rdioBtnMudurYardimcisi.Checked == true)
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Closed += (s, args) => this.Close();
                frm3.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya sifre yanlis");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
