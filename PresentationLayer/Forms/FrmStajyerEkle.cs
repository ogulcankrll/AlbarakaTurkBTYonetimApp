using BusinessLogicLayer.Services;
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
            Stajyer eklenecekStajyer = new Stajyer
            {
                AdSoyad = txtAd.Text,
                TcNo=mskTC.Text,
                KullaniciAdi=txtKullaniciAdi.Text,  
                Sifre=txtSifre.Text,
            };
            stajyerServis.stajyerKayıtEkle(eklenecekStajyer);   
            MessageBox.Show("Personel başarıyla eklendi.");
        }
    }
}
