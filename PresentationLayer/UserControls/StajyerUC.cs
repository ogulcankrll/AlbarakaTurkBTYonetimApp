using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class StajyerUC : UserControl
    {
        StajyerServis StajyerServis;
        public StajyerUC()
        {
            InitializeComponent();
            StajyerServis = new StajyerServis();
            Helpers.DataGridViewYardimci.SatirRenklendir(dataGridViewStajyer);
        }
        
        public void StajyerBilgiListele()
        {
            var satjyerListesi = StajyerServis.StajyerBilgiGetir();
            dataGridViewStajyer.DataSource = satjyerListesi;    
        }

        private void btnDepartmanAra_Click(object sender, EventArgs e)
        {
            var stajyerListesi = StajyerServis.StajyerBilgiGetir();
            string DepartmanAramaKriteri = txtAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(DepartmanAramaKriteri))
            {

                dataGridViewStajyer.DataSource = stajyerListesi;
            }
            else
            {

                var aramaSonucu = stajyerListesi
                    .Where(p => p.AdSoyad.ToLower().Contains(DepartmanAramaKriteri) ||
                                p.KullaniciAdi.ToLower().Contains(DepartmanAramaKriteri) ||
                                p.StajyerSicil.ToString().Contains(DepartmanAramaKriteri) ||
                                p.TCNo.ToLower().Contains(DepartmanAramaKriteri)
                                ).ToList();

                dataGridViewStajyer.DataSource = aramaSonucu;
            }

        }

        private void StajyerUC_Load(object sender, EventArgs e)
        {
            StajyerBilgiListele();
        }

        private void dataGridViewStajyer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var secilenStajyer = (StajyerDTO)dataGridViewStajyer.Rows[e.RowIndex].DataBoundItem;


                FrmStajyerDetay frmStajyerDetay = new FrmStajyerDetay(secilenStajyer);
                frmStajyerDetay.ShowDialog();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStajyerEkle frmStajyerEkle = new FrmStajyerEkle();
            frmStajyerEkle.Show();
        }
    }
}
