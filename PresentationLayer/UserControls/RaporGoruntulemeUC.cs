using BusinessLogicLayer.Services;
using EntityLayer.DTO;
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
    public partial class RaporGoruntulemeUC : UserControl
    {
        RaporServis RaporServis;
        public RaporGoruntulemeUC()
        {
            InitializeComponent();
            RaporServis = new RaporServis();
            Helpers.DataGridViewYardimci.SatirRenklendir(dataGridViewRaporlar);
        }
        
        public void RaporGoruntule()
        {
            var raporVerileri = RaporServis.RaporBilgiGetir();
            dataGridViewRaporlar.DataSource = raporVerileri;    
        }
        private void RaporGoruntulemeUC_Load(object sender, EventArgs e)
        {

            RaporGoruntule();
        }

        private void dataGridViewRaporlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                var selectedRapor = (RaporDTO)dataGridViewRaporlar.Rows[e.RowIndex].DataBoundItem;

                
                txtStajyer.Text = selectedRapor.AdSoyad;
                richTxticerik.Text = selectedRapor.Icerik;
                
                dtpYazimTarihi.Value = selectedRapor.YazimTarihi; 
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            richTxticerik.Clear();  
            txtStajyer.Clear();
            dtpYazimTarihi.Value=DateTime.Now;  
        }
    }
}
