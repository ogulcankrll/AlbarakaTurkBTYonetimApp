using BusinessLogicLayer.Services;
using EntityLayer.Models;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FrmStajyerEkle : Form
    {
        StajyerServis stajyerServis;

        public FrmStajyerEkle()
        {
            InitializeComponent();
            stajyerServis = new StajyerServis();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(mskTC.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtSifreTekrar.Text))
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (mskTC.Text.Length != 11)
            {
                MessageBox.Show("Geçerli bir TC numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen şifrelerinizi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                Stajyer eklenecekStajyer = new Stajyer
                {
                    AdSoyad = txtAd.Text,
                    TcNo = mskTC.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text
                };

                
                stajyerServis.stajyerKayıtEkle(eklenecekStajyer);
                MessageBox.Show("Stajyer başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAd.Clear();
                mskTC.Clear();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                txtSifreTekrar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
