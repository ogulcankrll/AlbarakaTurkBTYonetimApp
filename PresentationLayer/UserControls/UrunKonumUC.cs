using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Enums;
using EntityLayer.Models;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class UrunKonumUC : UserControl
    {
        private KategoriServis kategoriServis = new KategoriServis();
        private UrunServis urunServis = new UrunServis();
        private UrunKonumServis urunKonumServis = new UrunKonumServis();
        private PersonelServis personelServis = new PersonelServis();
        private UrunKonumServis UrunKonumServis = new UrunKonumServis();
        public UrunKonumUC()
        {
            InitializeComponent();
            Helpers.DataGridViewYardimci.SatirRenklendir(dataGridViewUrunKonum);

        }

        public void UrunleriGetir()
        {
            var urunler = urunServis.UrunBilgileriGetir();
            cmbUrun.DataSource = urunler;
            cmbUrun.ValueMember = "UrunID";
            cmbUrun.DisplayMember = "MarkaModel";
        }
        private void KategorileriGetir()
        {
            var kategoriler = kategoriServis.KategorileriGetir();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "KategoriID";
        }
        private void DurumlarıGetir()
        {
            cmbKonum.DataSource = Enum.GetValues(typeof(UrunKonum)).Cast<UrunKonum>().ToList();
        }
        private void PersonelGetir()
        {
            var personeller = personelServis.PersonelDetayGetir();
            cmbPersonel.DataSource = personeller;
            cmbPersonel.DisplayMember = "Ad";
            cmbPersonel.ValueMember = "ID";
        }
        private void UrunKonumBilgisiListele()
        {
            var urunKonumBilgisi = urunKonumServis.UrunKonumlariGetir();
            dataGridViewUrunKonum.DataSource = urunKonumBilgisi;
        }
        private void Temizle()
        {
            cmbKategori.Text = " ";
            cmbUrun.Text = " ";
            cmbKonum.Text = " ";
            cmbPersonel.Text = " ";
            richTxtAciklama.Clear();



        }

        private void UrunKonumUC_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
            UrunleriGetir();
            DurumlarıGetir();
            PersonelGetir();
            UrunKonumBilgisiListele();
            Temizle();
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedValue != null && int.TryParse(cmbKategori.SelectedValue.ToString(), out int kategoriID))
            {
                var urunler = urunServis.UrunBilgileriGetir()
                             .Where(u => u.KategoriID == kategoriID)
                             .ToList();

                cmbUrun.DataSource = urunler;
                cmbUrun.DisplayMember = "MarkaModel";
                cmbUrun.ValueMember = "UrunID";
            }
            else
            {
                cmbUrun.DataSource = null;
            }

        }
        private void cmbUrun_Format(object sender, ListControlConvertEventArgs e)
        {
            var urun = (UrunDTO)e.ListItem;
            e.Value = $"{urun.MarkaModel}  -  Seri No: {urun.SeriNo}";
        }

        private void cmbPersonel_Format(object sender, ListControlConvertEventArgs e)
        {
            var personel = (PersonelProfilDTO)e.ListItem;
            e.Value = $"{personel.Ad} {personel.Soyad} - Sicil No:{personel.SicilNo}";

        }

        private void cmbKonum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliKonum = (UrunKonum)cmbKonum.SelectedItem;

            if (seciliKonum == UrunKonum.GmPersonel)
            {
                lblPersonel.Visible = true;
                cmbPersonel.Visible = true;
            }
            else
            {
                lblPersonel.Visible = false;
                cmbPersonel.Visible = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var seciliKonum = (UrunKonum)cmbKonum.SelectedItem;
            int? personelID = null;

            if (seciliKonum == UrunKonum.GmPersonel)
            {
                if (cmbPersonel.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen personel seçin.");
                    return;
                }
                personelID = (int)cmbPersonel.SelectedValue;
            }

            var urunKonumBilgi = new UrunKonumBilgi
            {
                UrunID = (int)cmbUrun.SelectedValue,
                UrunKonum = seciliKonum,
                PersonelID = personelID,
                Aciklama = richTxtAciklama.Text
            };

            urunKonumServis.UrunKonumEkle(urunKonumBilgi);
            UrunKonumBilgisiListele();
            MessageBox.Show("Ürün konum bilgisi başarıyla eklendi.");
            Temizle();


        }



        private void cmbUrun_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            var urunListesi = urunKonumServis.UrunKonumlariGetir();
            string aramaKriteri = txtArama.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaKriteri))
            {

                dataGridViewUrunKonum.DataSource = urunListesi;
            }
            else
            {

                var aramaSonucu = urunListesi
                    .Where(p => p.MarkaModel.ToLower().Contains(aramaKriteri) ||
                                p.PersonelAdSoyad.ToLower().Contains(aramaKriteri) ||
                                p.PersonelSicilNo.ToLower().Contains(aramaKriteri) ||
                                p.MarkaModel.ToLower().Contains(aramaKriteri) ||
                                p.SeriNumarasi.ToLower().Contains(aramaKriteri))
                    .ToList();

                dataGridViewUrunKonum.DataSource = aramaSonucu;
            }
        }

        private void dataGridViewUrunKonum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

       
    }
}
    

