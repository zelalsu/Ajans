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
    public partial class Form2 : Form
    {
        private Object[] firmalar = new Firma[4];
        private Object[] teknikCalisanlari = new TeknikEkip[2];
        private Object[] evrakcilar = new EvrakCalisani[4];
        private Object[] yetkililer = new Yonetim[2];
        private Object[] sinemaOyunculari = new SinemaOyuncusu[3];
        private Object[] reklamOyunculari = new ReklamOyuncusu[2];
        private Object[] radyoOyunculari = new RadyoOyuncusu[1];
        MaliDurum gelirDrm = new MaliDurum();
        MaliDurum giderDrm = new MaliDurum();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            teknikCalisanOlustur();
            evrakCalisanOlustur();
            yonetimCalisanOlustur();
            firmaOlustur();
            sinemaOyuncuOlustur();
            reklamOyuncuOlustur();
            radyoOyuncuOlustur();
            giderDrm.faturaKira = 18000;
            gelirDrm.toplamGelir = gelirDrm.reklamProjeGlr + gelirDrm.gorevlendirmeProjeGlr;
            giderDrm.toplamGider = giderDrm.faturaKira + giderDrm.maaslar;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Visible = false;
            inputGroup.Visible = false;
            
        }
        private void teknikEkipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(true, false, 692, "Teknik Ekip Çalışanları");
            teknikCalisanListele();
        }
        private void evrakEkibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(true, false, 692, "Evrak Ekibi Çalışanları");
            evrakCalisanListele();
        }
        private void yönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(true, false, 692, "Yönetim Çalışanları");
            yonetimCalisanListele();
        }
        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(false, false, 860, "Anlaşmalı Firmalar");
            firmaListele();
        }
        private void maliDurumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(false, true, 692, "Mali Durum");
            maliDurumGoster();
        }
        private void sinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(false, false, 860, "Sinema Oyuncuları");
            sinemaOyuncuListele();
        }
        private void görselReklamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(false, false, 860, "Reklam Oyuncuları");
            reklamOyuncuListele();
        }
        private void sesliRadyoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewYenile(false, false, 860, "Radyo Oyuncuları");
            radyoOyuncuListele();
        }
        public void listViewYenile(bool groupVisible, bool btnMaliVisible, int listViewWidth, string lblList)
        {
            inputGroup.Visible = groupVisible;
            btnMali.Visible = btnMaliVisible;
            listView1.Width = listViewWidth;
            lblListView.Text = lblList;
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Visible = true;
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxMaas.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtBoxIzınGunu.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtBoxEkIzın.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[1].Text = txtBoxMaas.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtBoxIzınGunu.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtBoxEkIzın.Text;


            if (lblListView.Text == "Teknik Ekip Çalışanları")
            {
                foreach (TeknikEkip tknekp in teknikCalisanlari)
                {
                    if (tknekp.isim == listView1.SelectedItems[0].Text)
                    {
                        giderDrm.toplamGider -= giderDrm.maaslar;
                        giderDrm.maaslar -= tknekp.maas;
                        tknekp.maas = float.Parse(txtBoxMaas.Text);
                        tknekp.izinGunleri = txtBoxIzınGunu.Text;
                        tknekp.izinSayisi = Convert.ToInt32(txtBoxEkIzın.Text);
                        giderDrm.maaslar += float.Parse(txtBoxMaas.Text);
                        giderDrm.toplamGider += giderDrm.maaslar;
                    }
                }
            }
            if (lblListView.Text == "Evrak Ekibi Çalışanları")
            {
                foreach (EvrakCalisani evrkekp in evrakcilar)
                {
                    if (evrkekp.isim == listView1.SelectedItems[0].Text)
                    {
                        giderDrm.toplamGider -= giderDrm.maaslar;
                        giderDrm.maaslar -= evrkekp.maas;
                        evrkekp.maas = float.Parse(txtBoxMaas.Text);
                        evrkekp.izinGunleri = txtBoxIzınGunu.Text;
                        evrkekp.izinSayisi = Convert.ToInt32(txtBoxEkIzın.Text);
                        giderDrm.maaslar += float.Parse(txtBoxMaas.Text);
                        giderDrm.toplamGider += giderDrm.maaslar;
                    }
                }
            }
            if (lblListView.Text == "Yönetim Çalışanları")
            {
                foreach (Yonetim ytkl in yetkililer)
                {
                    if (ytkl.isim == listView1.SelectedItems[0].Text)
                    {
                        giderDrm.toplamGider -= giderDrm.maaslar;
                        giderDrm.maaslar -= ytkl.maas;
                        ytkl.maas = float.Parse(txtBoxMaas.Text);
                        ytkl.izinGunleri = txtBoxIzınGunu.Text;
                        ytkl.izinSayisi = Convert.ToInt32(txtBoxEkIzın.Text);
                        giderDrm.maaslar += float.Parse(txtBoxMaas.Text);
                        giderDrm.toplamGider += giderDrm.maaslar;
                    }
                }
            }

            txtBoxMaas.Text = "";
            txtBoxIzınGunu.Text = "";
            txtBoxEkIzın.Text = "";
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

        public void yonetimCalisanListele()
        {
            listViewSutunEkle("İsmi", 75, "Maaş", 75, "İzin Günü", 75, "Ek izin Sayisi", 100);

            foreach (Yonetim yonetimCalisani in yetkililer)
            {
                string[] bilgiler = { yonetimCalisani.isim, yonetimCalisani.maas.ToString(), yonetimCalisani.izinGunleri, yonetimCalisani.izinSayisi.ToString() };
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
        public void sinemaOyuncuListele()
        {
            listViewSutunEkle("İsmi", 100, "Kategori", 75, "Aktiflik Durumu", 100, "Mevcut Proje", 100, "Rol", 100, "Başlangıç Tarihi", 100, "Bitiş Tarihi", 100);

            foreach (SinemaOyuncusu sinemaOyuncu in sinemaOyunculari)
            {
                string[] bilgiler = { sinemaOyuncu.oyuncuIsmi,
                                      sinemaOyuncu.kategori,
                                      sinemaOyuncu.aktiflikDurumu,
                                      sinemaOyuncu.mevcutProje,
                                      sinemaOyuncu.rol,
                                      sinemaOyuncu.isBaslangic,
                                      sinemaOyuncu.isBitis };

                listView1.Items.Add(new ListViewItem(bilgiler));
            }

        }
        public void reklamOyuncuListele()
        {
            listViewSutunEkle("İsmi", 100, "Kategori", 75, "Aktiflik Durumu", 100, "Mevcut Proje", 100, "Rol", 100, "Başlangıç Tarihi", 100, "Bitiş Tarihi", 100);
            foreach (ReklamOyuncusu reklamOyuncu in reklamOyunculari)
            {
                string[] bilgiler = {reklamOyuncu.oyuncuIsmi,
                                      reklamOyuncu.kategori,
                                      reklamOyuncu.aktiflikDurumu,
                                      reklamOyuncu.mevcutProje,
                                      reklamOyuncu.rol,
                                      reklamOyuncu.isBaslangic,
                                      reklamOyuncu.isBitis };
                listView1.Items.Add(new ListViewItem(bilgiler));
            }
        }
        public void radyoOyuncuListele()
        {
            listViewSutunEkle("İsmi", 100, "Kategori", 75, "Aktiflik Durumu", 100, "Mevcut Proje", 100, "Rol", 100, "Başlangıç Tarihi", 100, "Bitiş Tarihi", 100);

            foreach (RadyoOyuncusu radyoOyuncu in radyoOyunculari)
            {
                string[] bilgiler = { radyoOyuncu.oyuncuIsmi,
                                      radyoOyuncu.kategori,
                                      radyoOyuncu.aktiflikDurumu,
                                      radyoOyuncu.mevcutProje,
                                      radyoOyuncu.rol,
                                      radyoOyuncu.isBaslangic,
                                      radyoOyuncu.isBitis };

                listView1.Items.Add(new ListViewItem(bilgiler));
            }
        }
        public void maliDurumGoster()
        {
            listViewSutunEkle("Gelir Tipi", 173, "Gelir Miktarı", 173, "Gider Tipi", 173, "Gider Miktarı", 173);

            string[] bilgiler1 = { "Reklam Proje geliri:", gelirDrm.reklamProjeGlr.ToString(), "Maaş Gideri:", giderDrm.maaslar.ToString() };
            listView1.Items.Add(new ListViewItem(bilgiler1));

            string[] bilgiler2 = { "Oyuncu Görevlendirme Geliri:", gelirDrm.gorevlendirmeProjeGlr.ToString(), "Faturalar ve Kira:", giderDrm.faturaKira.ToString() };
            listView1.Items.Add(new ListViewItem(bilgiler2));

            string[] bilgiler3 = { "Toplam Gelir:", gelirDrm.toplamGelir.ToString(), "Toplam Gider:", giderDrm.toplamGider.ToString() };
            listView1.Items.Add(new ListViewItem(bilgiler3));
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
        public void teknikCalisanOlustur()
        {
            TeknikEkip calisan1 = new TeknikEkip();
            calisan1.isim = "Osman Gültekin";
            calisan1.maas = 1000;
            calisan1.izinGunleri = "Çarşamba";
            calisan1.izinSayisi = 2;
            calisan1.mevcutProje = "Kamera Çekimi";
            DateTime baslangic = new DateTime(2020, 11, 15);
            calisan1.isBaslangic = baslangic.ToString("d");
            DateTime bitis = new DateTime(2021, 3, 22);
            calisan1.isBitis = bitis.ToString("d");

            TeknikEkip calisan2 = new TeknikEkip();
            calisan2.isim = "Sahra Kapalı";
            calisan2.maas = 1000;
            calisan2.izinGunleri = "Pazartesi";
            calisan2.izinSayisi = 1;
            calisan2.mevcutProje = "Ses Sistemi Kurulumu";
            DateTime baslangic1 = new DateTime(2020, 11, 15);
            calisan2.isBaslangic = baslangic.ToString("d");
            DateTime bitis2 = new DateTime(2020, 11, 25);
            calisan2.isBitis = bitis.ToString("d");

            teknikCalisanlari[0] = calisan1;
            teknikCalisanlari[1] = calisan2;
            giderDrm.maaslar += (calisan1.maas + calisan2.maas);
        }
        public void evrakCalisanOlustur()
        {
            EvrakCalisani calisan1 = new EvrakCalisani();
            calisan1.isim = "Gül Metin";
            calisan1.maas = 1500;
            calisan1.izinGunleri = "Çarşamba";
            calisan1.izinSayisi = 3;

            EvrakCalisani calisan2 = new EvrakCalisani();
            calisan2.isim = "Merve Nerkis";
            calisan2.maas = 1500;
            calisan2.izinGunleri = "Salı";
            calisan2.izinSayisi = 1;

            EvrakCalisani calisan3 = new EvrakCalisani();
            calisan3.isim = "Zelal Kartal";
            calisan3.maas = 1500;
            calisan3.izinGunleri = "Perşembe";
            calisan3.izinSayisi = 2;

            EvrakCalisani calisan4 = new EvrakCalisani();
            calisan4.isim = "Emre Türkmen";
            calisan4.maas = 1500;
            calisan4.izinGunleri = "Cumartesi";
            calisan4.izinSayisi = 2;
            evrakcilar[0] = calisan1;
            evrakcilar[1] = calisan2;
            evrakcilar[2] = calisan3;
            evrakcilar[3] = calisan4;
            giderDrm.maaslar += (calisan1.maas + calisan2.maas + calisan3.maas + calisan4.maas);
        }
        public void yonetimCalisanOlustur()
        {
            Yonetim mudurYardimcisi1 = new Yonetim();
            mudurYardimcisi1.isim = "Volkan Yılmaz";
            mudurYardimcisi1.maas = 2000;
            mudurYardimcisi1.izinGunleri = "Cumartesi";
            mudurYardimcisi1.izinSayisi = 4;
            mudurYardimcisi1.yetki = false;

            Yonetim mudurYardimcisi2 = new Yonetim();
            mudurYardimcisi2.isim = "Beliz Türkmen";
            mudurYardimcisi2.maas = 2000;
            mudurYardimcisi2.izinGunleri = "Cuma";
            mudurYardimcisi2.izinSayisi = 2;
            mudurYardimcisi2.yetki = false;

            yetkililer[0] = mudurYardimcisi1;
            yetkililer[1] = mudurYardimcisi2;
            giderDrm.maaslar += mudurYardimcisi1.maas + mudurYardimcisi2.maas;
        }
        public void firmaOlustur()
        {
            Firma frm1 = new Firma();
            frm1.firmaIsim = "Kuvars Reklam";
            frm1.anlasilanFiyat = 9000;
            frm1.sehir = "İzmir";
            frm1.anlasmaSayisi = 2;

            Firma frm2 = new Firma();
            frm2.firmaIsim = "Manolya Reklam";
            frm2.anlasilanFiyat = 7000;
            frm2.sehir = "Ankara";
            frm2.anlasmaSayisi = 4;

            Firma frm3 = new Firma();
            frm3.firmaIsim = "Star Yapım";
            frm3.anlasilanFiyat = 5000;
            frm3.sehir = "İstanbul";
            frm3.anlasmaSayisi = 5;

            Firma frm4 = new Firma();
            frm4.firmaIsim = "Ay Yapım";
            frm4.anlasilanFiyat = 10000;
            frm4.sehir = "Sivas";
            frm4.anlasmaSayisi = 3;

            firmalar[0] = frm1;
            firmalar[1] = frm2;
            firmalar[2] = frm3;
            firmalar[3] = frm4;
            float yuzde, indirim;

            foreach (Firma frm in firmalar)
            {
                if (frm.anlasmaSayisi >= 3)
                {
                    yuzde = frm.anlasilanFiyat * 20 / 100;
                    indirim = frm.anlasilanFiyat - yuzde;
                    frm.anlasilanFiyat = indirim;
                }
            }
            gelirDrm.reklamProjeGlr = (frm1.anlasilanFiyat+frm2.anlasilanFiyat);
            gelirDrm.gorevlendirmeProjeGlr = (frm3.anlasilanFiyat + frm4.anlasilanFiyat);




        }
        public void sinemaOyuncuOlustur()
        {
            SinemaOyuncusu calisan1 = new SinemaOyuncusu();
            calisan1.oyuncuIsmi = "Haluk Bilginer";
            calisan1.rol = "-";
            calisan1.kategori = "sinema";
            calisan1.aktiflikDurumu = "pasif";
            calisan1.mevcutProje = "-";

            SinemaOyuncusu calisan2 = new SinemaOyuncusu();
            calisan2.oyuncuIsmi = "Binnur Kaya";
            calisan2.rol = "Doktor Hanım";
            calisan2.kategori = "sinema";
            calisan2.aktiflikDurumu = "aktif";
            calisan2.mevcutProje = "Kırmızı Oda";
            DateTime baslangic1 = new DateTime(2020, 09, 04);
            calisan2.isBaslangic = baslangic1.ToString("d");
            DateTime bitis1 = new DateTime(2022, 12, 25);
            calisan2.isBitis = bitis1.ToString("d");

            SinemaOyuncusu calisan3 = new SinemaOyuncusu();
            calisan3.oyuncuIsmi = "Burak Özçivit";
            calisan3.rol = "Osman Bey";
            calisan3.kategori = "sinema";
            calisan3.aktiflikDurumu = "aktif";
            calisan3.mevcutProje = "Kuruluş Osman";
            DateTime baslangic2 = new DateTime(2019, 11, 20);
            calisan3.isBaslangic = baslangic2.ToString("d");
            DateTime bitis2 = new DateTime(2023, 9, 15);
            calisan3.isBitis = bitis2.ToString("d");

            sinemaOyunculari[0] = calisan1;
            sinemaOyunculari[1] = calisan2;
            sinemaOyunculari[2] = calisan3;

        }
        public void reklamOyuncuOlustur()
        {
            ReklamOyuncusu calisan1 = new ReklamOyuncusu();
            calisan1.oyuncuIsmi = "Kıvanç Tatlıtuğ";
            calisan1.rol = "Mavi Modeli";
            calisan1.kategori = "reklam";
            calisan1.aktiflikDurumu = "aktif";
            calisan1.mevcutProje = "Mavi";
            DateTime baslangic = new DateTime(2020, 12, 10);
            calisan1.isBaslangic = baslangic.ToString("d");
            DateTime bitis = new DateTime(2021, 1, 10);
            calisan1.isBitis = bitis.ToString("d");

            ReklamOyuncusu calisan2 = new ReklamOyuncusu();
            calisan2.oyuncuIsmi = "Elçin Sangu";
            calisan2.rol = "-";
            calisan2.kategori = "reklam";
            calisan2.aktiflikDurumu = "pasif";
            calisan2.mevcutProje = "-";


            reklamOyunculari[0] = calisan1;
            reklamOyunculari[1] = calisan2;

        }
        public void radyoOyuncuOlustur()
        {
            RadyoOyuncusu calisan1 = new RadyoOyuncusu();
            calisan1.oyuncuIsmi = "Nihat Sırdar";
            calisan1.rol = "konuşmacı";
            calisan1.kategori = "radyo";
            calisan1.aktiflikDurumu = "aktif";
            calisan1.mevcutProje = "Nihat'la Sivrisinek";
            DateTime baslangic = new DateTime(2013, 01, 01);
            calisan1.isBaslangic = baslangic.ToString("d");
            DateTime bitis = new DateTime(2025, 1, 15);
            calisan1.isBitis = bitis.ToString("d");

            radyoOyunculari[0] = calisan1;

        }
        
        
        
        private void btnMali_Click(object sender, EventArgs e)
        {
            float maliyet = gelirDrm.toplamGelir - giderDrm.toplamGider;
            if (maliyet >= 0)
            {
                MessageBox.Show("Net Kar: "+ maliyet);
            }
            else
            {
                MessageBox.Show("Net Zarar: "+ maliyet);
            }
        }
        public Object[] evrakEkibiBilgileri()
        {
            return evrakcilar;
        }
        public Object[] yetkiliBilgileri()
        {
            return yetkililer;
        }
        public Object[] firmaBilgileri()
        {
            return firmalar;
        }
        public Object[] sinemaBilgileri()
        {
            return sinemaOyunculari;
        }
        public Object[] reklamBilgileri()
        {
            return reklamOyunculari;
        }
        public Object[] radyoBilgileri()
        {
            return radyoOyunculari;
        }
        public Object[] teknikEkipBilgileri()
        {
            return teknikCalisanlari;
        }
    }
}
