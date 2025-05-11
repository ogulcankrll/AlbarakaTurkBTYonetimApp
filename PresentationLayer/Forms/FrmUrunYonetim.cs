using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FrmUrunYonetim : Form
    {
        private UrunDTO Urun;
        UrunServis UrunServis;
      
        public FrmUrunYonetim()
        {
            InitializeComponent();
           
        }

        public FrmUrunYonetim(UrunDTO secilenUrun)
        {
            InitializeComponent();
            Urun = secilenUrun;
            UrunServis = new UrunServis();
            UrunBilgileriniFormdaGoster();
        }

        private void UrunBilgileriniFormdaGoster()
        {
            if (Urun != null)
            {
                txtID.Text = Urun.UrunID.ToString();
                txtMarkaModel.Text = Urun.MarkaModel;
                txtSeriNo.Text = Urun.SeriNo;
                cmbKategori.SelectedItem = Urun.KategoriAdi;
            }
        }

        public void KategorileriGetir()
        {
            var kategoriServis = new KategoriServis();
            var kategoriler = kategoriServis.KategorileriGetir();

            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "KategoriID";
            cmbKategori.DataSource = kategoriler;
        }

        private void FrmUrunYonetim_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarkaModel.Text) || string.IsNullOrWhiteSpace(txtSeriNo.Text) || cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Urun eklenecekUrun = new Urun
            {
                MarkaModel = txtMarkaModel.Text,
                SeriNumarasi = txtSeriNo.Text,
                KategoriID = (int)cmbKategori.SelectedValue,
            };
            UrunServis.UrunEkle(eklenecekUrun);
            MessageBox.Show("Ürün başarıyla eklendi.");
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Silmek için bir ürün seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kategoriID = Convert.ToInt32(txtID.Text);
            UrunServis.urunSil(kategoriID);
            MessageBox.Show($"Seçilen ürün (ID: {txtID.Text}) başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtMarkaModel.Text) || string.IsNullOrWhiteSpace(txtSeriNo.Text) || cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Urun guncellenecekUrun = new Urun
            {
                ID=Convert.ToInt32(txtID.Text),
                MarkaModel = txtMarkaModel.Text,
                SeriNumarasi = txtSeriNo.Text,
                KategoriID = (int)cmbKategori.SelectedValue,
            };
            UrunServis.urunGuncelle(guncellenecekUrun);
            MessageBox.Show($"Ürün (ID: {txtID.Text}) başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
