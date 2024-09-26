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
            UrunServis = new UrunServis();
        }

        public FrmUrunYonetim(UrunDTO secilenUrun) 
        {
            InitializeComponent();
            Urun = secilenUrun;
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
            Urun eklenecekUrun = new Urun
            {
                MarkaModel = txtMarkaModel.Text,
                SeriNumarasi = txtSeriNo.Text,
                KategoriID = (int)cmbKategori.SelectedValue,
            };
            UrunServis.UrunEkle(eklenecekUrun);
            MessageBox.Show("Personel başarıyla eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int kategoriID = Convert.ToInt32(txtID.Text);
            UrunServis.urunSil(kategoriID);
            MessageBox.Show("Seçilen kategori Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Urun guncellenecekUrun = new Urun
            {
                MarkaModel = txtMarkaModel.Text,
                SeriNumarasi = txtSeriNo.Text,
                KategoriID = (int)cmbKategori.SelectedValue,
            };
            UrunServis.UrunEkle(guncellenecekUrun);
            MessageBox.Show("Personel başarıyla güncellendi.");
        }
    }
}
