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
    public partial class Form3 : Form
    {
        private Object[] firmalar = new Firma[2];
        private Object[] teknikCalisanlari = new TeknikEkip[2];
        private Object[] evrakcilar = new EvrakCalisani[4];
        private Object[] yetkililer = new Yonetim[2];
        private Object[] sinemaOyunculari = new SinemaOyuncusu[3];
        private Object[] reklamOyunculari = new ReklamOyuncusu[2];
        private Object[] radyoOyunculari = new RadyoOyuncusu[1];


        Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Clear();
            listView1.Items.Clear();

            form2.teknikCalisanOlustur();
            form2.evrakCalisanOlustur();
            form2.yonetimCalisanOlustur();
            form2.firmaOlustur();
            form2.sinemaOyuncuOlustur();
            form2.reklamOyuncuOlustur();
            form2.radyoOyuncuOlustur();

            teknikCalisanlari = form2.teknikEkipBilgileri();
            firmalar = form2.firmaBilgileri();
            evrakcilar = form2.evrakEkibiBilgileri();
            yetkililer = form2.yetkiliBilgileri();
            sinemaOyunculari = form2.sinemaBilgileri();
            reklamOyunculari = form2.reklamBilgileri();
            radyoOyunculari = form2.radyoBilgileri();
        }

        private void teknikEkipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(true, 692, "Teknik Ekip Çalışanları");
            teknikCalisanListele();
        }
        private void evrakEkibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(true, 692, "Evrak Ekibi Çalışanları");
            evrakCalisanListele();
        }
        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(false, 860, "Anlaşmalı Firmalar");
            firmaListele();
        }
        private void oyuncularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(false, 860, "Oyuncular");
            oyuncuListele();
        }
        public void listViewYenile(bool groupVisible, int listViewWidth, string lblList)
        {
            inputGroup.Visible = groupVisible;
            listView1.Width = listViewWidth;
            lblListView.Text = lblList;
            listView1.Columns.Clear();
            listView1.Items.Clear();
        }
        public void teknikCalisanListele()
        {
            listViewSutunEkle("İsmi", 75,
                              "Maaş", 75,
                              "İzin Günü", 75,
                              "Ek izin Sayisi", 100,
                              "Başlangıç Tarihi", 100,
                              "Bitiş Tarihi", 100,
                              "Mevcut Proje", 100);

            foreach (TeknikEkip teknikCalisan in teknikCalisanlari)
            {
                string[] bilgiler = {   teknikCalisan.isim,
                                        teknikCalisan.maas.ToString(),
                                        teknikCalisan.izinGunleri,
                                        teknikCalisan.izinSayisi.ToString(),
                                        teknikCalisan.isBaslangic,
                                        teknikCalisan.isBitis,
                                        teknikCalisan.mevcutProje };

                listView1.Items.Add(new ListViewItem(bilgiler));
            }
        }

        public void evrakCalisanListele()
        {
            listViewSutunEkle("İsmi", 75, "Maaş", 75, "İzin Günü", 75, "Ek izin Sayisi", 100);


            foreach (EvrakCalisani evrakCalisani in evrakcilar)
            {
                string[] bilgiler = { evrakCalisani.isim, evrakCalisani.maas.ToString(), evrakCalisani.izinGunleri, evrakCalisani.izinSayisi.ToString() };
                listView1.Items.Add(new ListViewItem(bilgiler));
            }

        }


        public void firmaListele()
        {
            listViewSutunEkle("Firma İsmi", 150, "Anlaşmalı Fiyat", 150, "Şehir", 150, "Anlaşma Sayısı", 150);

            foreach (Firma frm in firmalar)
            {
                string[] bilgiler = { frm.firmaIsim, frm.anlasilanFiyat.ToString(), frm.sehir, frm.anlasmaSayisi.ToString() };
                listView1.Items.Add(new ListViewItem(bilgiler));
            }
        }

        public void oyuncuListele()
        {
            listView1.Columns.Add("İsmi", 100);
            listView1.Columns.Add("Aktiflik Durumu", 100);
            listView1.Columns.Add("Mevcut Proje", 100);
            listView1.Columns.Add("Rol", 100);
            listView1.Columns.Add("Başlangıç Tarihi", 100);
            listView1.Columns.Add("Bitiş Tarihi", 100);

            foreach (SinemaOyuncusu sinemaOyuncu in sinemaOyunculari)
            {
                string[] bilgiler = {sinemaOyuncu.oyuncuIsmi,
                                      sinemaOyuncu.aktiflikDurumu,
                                      sinemaOyuncu.mevcutProje,
                                      sinemaOyuncu.rol,
                                      sinemaOyuncu.isBaslangic,
                                      sinemaOyuncu.isBitis };
                listView1.Items.Add(new ListViewItem(bilgiler));
            }

            foreach (ReklamOyuncusu reklamOyuncu in reklamOyunculari)
            {
                string[] bilgiler = {reklamOyuncu.oyuncuIsmi,
                                      reklamOyuncu.aktiflikDurumu,
                                      reklamOyuncu.mevcutProje,
                                      reklamOyuncu.rol,
                                      reklamOyuncu.isBaslangic,
                                      reklamOyuncu.isBitis };
                listView1.Items.Add(new ListViewItem(bilgiler));
            }

            foreach (RadyoOyuncusu radyoOyuncu in radyoOyunculari)
            {
                string[] bilgiler = {radyoOyuncu.oyuncuIsmi,
                                      radyoOyuncu.aktiflikDurumu,
                                      radyoOyuncu.mevcutProje,
                                      radyoOyuncu.rol,
                                      radyoOyuncu.isBaslangic,
                                      radyoOyuncu.isBitis };
                listView1.Items.Add(new ListViewItem(bilgiler));
            }
        }
        public void listViewSutunEkle(string a, int a1, string b, int b1, string c, int c1, string d, int d1, string e, int e1, string f, int f1, string g, int g1)
        {
            listView1.Columns.Add(a, a1);
            listView1.Columns.Add(b, b1);
            listView1.Columns.Add(c, c1);
            listView1.Columns.Add(d, d1);
            listView1.Columns.Add(e, e1);
            listView1.Columns.Add(f, f1);
            listView1.Columns.Add(g, g1);
        }
        public void listViewSutunEkle(string a, int a1, string b, int b1, string c, int c1, string d, int d1)
        {
            listView1.Columns.Add(a, a1);
            listView1.Columns.Add(b, b1);
            listView1.Columns.Add(c, c1);
            listView1.Columns.Add(d, d1);
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtIzınGunu.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtEkIzın.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[2].Text = txtIzınGunu.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtEkIzın.Text;
            if (lblListView.Text == "Teknik Ekip Çalışanları")
            {
                foreach (TeknikEkip tknekp in teknikCalisanlari)
                {
                    if (tknekp.isim == listView1.SelectedItems[0].Text)
                    {
                        tknekp.izinGunleri = txtIzınGunu.Text;
                        tknekp.izinSayisi = Convert.ToInt32(txtEkIzın.Text);
                    }
                }
            }
            if (lblListView.Text == "Evrak Ekibi Çalışanları")
            {
                foreach (EvrakCalisani evrkekp in evrakcilar)
                {
                    if (evrkekp.isim == listView1.SelectedItems[0].Text)
                    {
                        evrkekp.izinGunleri = txtIzınGunu.Text;
                        evrkekp.izinSayisi = Convert.ToInt32(txtEkIzın.Text);
                    }
                }
            }
            if (lblListView.Text == "Yönetim Çalışanları")
            {
                foreach (Yonetim ytkl in yetkililer)
                {
                    if (ytkl.isim == listView1.SelectedItems[0].Text)
                    {
                        ytkl.izinGunleri = txtIzınGunu.Text;
                        ytkl.izinSayisi = Convert.ToInt32(txtEkIzın.Text);
                    }
                }
            }

            txtIzınGunu.Text = "";
            txtEkIzın.Text = "";
        }

        

       
    }
}
