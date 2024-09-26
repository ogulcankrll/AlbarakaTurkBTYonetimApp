using BusinessLogicLayer.GenericRepository;
using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class ParametreUC : UserControl
    {
        private DepartmanServis DepartmanServis;
        private KategoriServis KategoriServis;  
      


        public ParametreUC()
        {
            InitializeComponent();
            DepartmanServis = new DepartmanServis();
            KategoriServis = new KategoriServis();  
        }
        private void DepartmanVerileriGetir()
        {
            var departmanVerileri = DepartmanServis.DepartmanlariGetir();
            dataGridViewDepartmanlar.DataSource = departmanVerileri;
            dataGridViewDepartmanlar.Columns["DepartmanID"].HeaderText = "#  ";
            dataGridViewDepartmanlar.Columns["DepartmanAD"].HeaderText = "Departman Adı  ";
            dataGridViewDepartmanlar.Columns["DepartmanKat"].HeaderText = "Kat Bilgisi  ";

        }
        private void KategorileriGetir()
        {
            var kategoriVerileri = KategoriServis.KategorileriGetir();
            dataGridViewKategoriler.DataSource= kategoriVerileri;
            dataGridViewKategoriler.Columns["KategoriID"].HeaderText = "#";
            dataGridViewKategoriler.Columns["KategoriAd"].HeaderText = "Kategori Adı";
          
           

        }

        private void ParametreUC_Load(object sender, EventArgs e)
        {
            DepartmanVerileriGetir();
            KategorileriGetir();

        }


        
        

        private void btnDepartmanDetay_Click(object sender, EventArgs e)
        {
            Forms.FrmDepartmanDetay frmDepartmanDetay = new Forms.FrmDepartmanDetay();
            frmDepartmanDetay.Show();
        }

        private void btnKategoriDetay_Click(object sender, EventArgs e)
        {
            Forms.FrmKategoriDetay frmKategoriDetay = new Forms.FrmKategoriDetay();
            frmKategoriDetay.Show();
        }

        private void dataGridViewDepartmanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                
                DataGridViewRow row = dataGridViewDepartmanlar.Rows[e.RowIndex];

               
                DepartmanDTO secilenDepartman = new DepartmanDTO
                {
                    DepartmanID = Convert.ToInt32(row.Cells["DepartmanID"].Value),
                    DepartmanAd = row.Cells["DepartmanAd"].Value.ToString(),
                    DepartmanKat = row.Cells["DepartmanKat"].Value.ToString()
                };

              
                FrmDepartmanDetay detayFormu = new FrmDepartmanDetay(secilenDepartman);
                detayFormu.Show();

            }
        }

        private void btnDepartmanAra_Click(object sender, EventArgs e)
        {
            var departmanListesi = DepartmanServis.DepartmanlariGetir();
            string DepartmanAramaKriteri = txtDepartmanArama.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(DepartmanAramaKriteri))
            {

                dataGridViewDepartmanlar.DataSource = departmanListesi;
            }
            else
            {

                var aramaSonucu = departmanListesi
                    .Where(p => p.DepartmanAd.ToLower().Contains(DepartmanAramaKriteri) ||
                                p.DepartmanKat.ToLower().Contains(DepartmanAramaKriteri)
                                ).ToList(); 
                              
                dataGridViewDepartmanlar.DataSource = aramaSonucu;
            }
        }

        private void btnKategoriAra_Click(object sender, EventArgs e)
        {

            var kategoriListesi = KategoriServis.KategorileriGetir();
            string KategoriAramaKriteri = txtKategoriArama.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(KategoriAramaKriteri))
            {

                dataGridViewKategoriler.DataSource = kategoriListesi;
            }
            else
            {

                var aramaSonucu = kategoriListesi
                    .Where(p => p.KategoriAd.ToLower().Contains(KategoriAramaKriteri) ||
                                p.KategoriID.ToString().Contains(KategoriAramaKriteri)
                                ).ToList();

                dataGridViewKategoriler.DataSource = aramaSonucu;
            }
        }

        private void dataGridViewKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridViewKategoriler.Rows[e.RowIndex];


                KategoriDTO secilenKategori = new KategoriDTO
                {
                    KategoriID = Convert.ToInt32(row.Cells["KategoriID"].Value),
                    KategoriAd = row.Cells["KategoriAd"].Value.ToString(),
                    
                };


                FrmKategoriDetay detayFormu = new FrmKategoriDetay(secilenKategori);
                detayFormu.Show();

            }
        }

        private void dataGridViewDepartmanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepartmanSayfasi_Click(object sender, EventArgs e)
        {

        }
    }
}
