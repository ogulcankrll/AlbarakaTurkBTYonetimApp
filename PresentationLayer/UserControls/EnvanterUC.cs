using BusinessLogicLayer.GenericRepository;
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
    public partial class EnvanterUC : UserControl
    {
        UrunServis UrunServis;
        public EnvanterUC()
        {
            InitializeComponent();
           UrunServis = new UrunServis();

        }

        private void UrunleriGetir()
        {
            var urunListesi = UrunServis.UrunBilgileriGetir();
            dataGridViewUrunler.DataSource = urunListesi; 
            dataGridViewUrunler.Columns["KategoriID"].Visible = false;
        }

        private void EnvanterUC_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            var urunListesi = UrunServis.UrunBilgileriGetir();
            string aramaKriteri = txtUrunAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaKriteri))
            {

                dataGridViewUrunler.DataSource = urunListesi;
            }
            else
            {

                var aramaSonucu = urunListesi
                    .Where(p => p.MarkaModel.ToLower().Contains(aramaKriteri) ||
                                p.SeriNo.ToLower().Contains(aramaKriteri) ||
                                p.UrunID.ToString().Contains(aramaKriteri) ||
                                p.KategoriAdi.ToLower().Contains(aramaKriteri))
                    .ToList();

                dataGridViewUrunler.DataSource = aramaSonucu;
            }
        }

        private void btnUrunYonetim_Click(object sender, EventArgs e)
        {
            FrmUrunYonetim frmUrunYonetim = new FrmUrunYonetim();
            frmUrunYonetim.Show();
        }

   

        private void dataGridViewUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                var secilenUrun = (UrunDTO)dataGridViewUrunler.Rows[e.RowIndex].DataBoundItem;

              
                FrmUrunYonetim frmUrunYonetim = new FrmUrunYonetim(secilenUrun);
                frmUrunYonetim.ShowDialog();
            }
        }

        private void dataGridViewUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
