using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void FrmKategoriDetay_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var yeniKategori = new Kategori
            {
                KategoriAd = txtAd.Text,
            };
            KategoriServis.KategoriEkle(yeniKategori);
            MessageBox.Show("Departman başarıyla eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int kategoriID=Convert.ToInt32(txtID.Text); 
            KategoriServis.KategoriSil(kategoriID);
            MessageBox.Show("Seçilen kategori Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekKategori = new Kategori
            {
                ID = Convert.ToInt32(txtID.Text),
                KategoriAd = txtAd.Text,
                
            };

            KategoriServis.KategoriGuncelle(guncellenecekKategori);
            MessageBox.Show("Departman başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
