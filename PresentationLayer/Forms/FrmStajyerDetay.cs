using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FrmStajyerDetay : Form
    {
        StajyerServis stajyerServis;
        private StajyerDTO Stajyer;

        public FrmStajyerDetay(StajyerDTO StajyerBilgi)
        {
            InitializeComponent();
            Stajyer = StajyerBilgi;
            stajyerServis = new StajyerServis();
        }

        public void StajyerBilgiliGetir(int StajyerSicil, string AdSoyad, string TCNo, string KullaniciAdi, string Sifre)
        {
            txtStajyerSicil.Text = StajyerSicil.ToString();
            txtAd.Text = AdSoyad;
            mskTC.Text = TCNo;
            txtKullaniciAdi.Text = KullaniciAdi;
            txtSifre.Text = Sifre;
        }

        private void FrmStajyerDetay_Load(object sender, EventArgs e)
        {
            StajyerBilgiliGetir(Stajyer.StajyerSicil, Stajyer.AdSoyad, Stajyer.TCNo, Stajyer.KullaniciAdi, Stajyer.Sifre);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(mskTC.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (mskTC.Text.Length != 11)
            {
                MessageBox.Show("Geçerli bir TC numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                var guncellenecekStajyer = new Stajyer
                {
                    ID = Convert.ToInt32(txtStajyerSicil.Text),
                    AdSoyad = txtAd.Text,
                    TcNo = mskTC.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text
                };

               
                stajyerServis.stajyerKayıtGuncelle(guncellenecekStajyer);
                MessageBox.Show("Stajyer bilgisi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int stajyerSicil = Convert.ToInt32(txtStajyerSicil.Text);

                
                stajyerServis.stajyerKayıtSil(stajyerSicil);
                MessageBox.Show("Seçilen stajyer başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                txtStajyerSicil.Clear();
                txtAd.Clear();
                mskTC.Clear();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
