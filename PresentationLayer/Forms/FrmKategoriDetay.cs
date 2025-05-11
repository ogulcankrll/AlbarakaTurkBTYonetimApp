using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FrmKategoriDetay : Form
    {
        KategoriServis KategoriServis;
        KategoriDTO KategoriDTO;

        public FrmKategoriDetay(KategoriDTO _kategoriDTO)
        {
            InitializeComponent();
            this.KategoriDTO = _kategoriDTO;
            KategoriServis = new KategoriServis();

           
            txtID.Text = _kategoriDTO.KategoriID.ToString();
            txtAd.Text = _kategoriDTO.KategoriAd;
        }

        public FrmKategoriDetay()
        {
            InitializeComponent();
            KategoriServis = new KategoriServis();
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var yeniKategori = new Kategori
                {
                    KategoriAd = txtAd.Text,
                };

                KategoriServis.KategoriEkle(yeniKategori);
                MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                txtID.Clear();
                txtAd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Lütfen silinecek kategoriyi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kategoriID = Convert.ToInt32(txtID.Text);
                KategoriServis.KategoriSil(kategoriID);
                MessageBox.Show("Seçilen kategori başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                txtID.Clear();
                txtAd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Lütfen güncellenecek kategoriyi seçin ve tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var guncellenecekKategori = new Kategori
                {
                    ID = Convert.ToInt32(txtID.Text),
                    KategoriAd = txtAd.Text
                };

                KategoriServis.KategoriGuncelle(guncellenecekKategori);
                MessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                txtID.Clear();
                txtAd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
