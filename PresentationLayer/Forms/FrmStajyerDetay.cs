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

        public void StajyerBilgiliGetir(int StajyerSicil,string AdSoyad,string TCNo,string KullaniciAdi,string Sifre)
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
            var guncellenecekStajyer = new Stajyer
            {
                ID = Convert.ToInt32(txtStajyerSicil.Text),
                AdSoyad=txtAd.Text, 
                TcNo=mskTC.Text,    
                KullaniciAdi=txtKullaniciAdi.Text,
                Sifre=txtSifre.Text,    
            };

            stajyerServis.stajyerKayıtGuncelle(guncellenecekStajyer);
            MessageBox.Show("Stajyer bilgisi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int stajyerSicil = Convert.ToInt32(txtStajyerSicil.Text);
            stajyerServis.stajyerKayıtSil(stajyerSicil);
            MessageBox.Show("Seçilen stajyer Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
