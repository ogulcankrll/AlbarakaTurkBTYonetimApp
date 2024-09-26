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

namespace PresentationLayer.UserControls
{
    public partial class RaporYazmaUC : UserControl
    {
        private RaporServis RaporServis;
        private int stajyerId; // Örneğin stajyerId'yi burada saklayabilirsiniz.

        // Parametreli constructor
        public RaporYazmaUC(int id)
        {
            InitializeComponent();
            RaporServis = new RaporServis();
            stajyerId = id; // İD'yi saklayın.
        }

        // Parametresiz constructor
        public RaporYazmaUC()
        {
            InitializeComponent();
            RaporServis = new RaporServis();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var rapor = new Rapor
            {
                StajyerID = stajyerId,
                Icerik = richTxtRapor.Text,
              
            };

            RaporServis.RaporEkle(rapor);
            MessageBox.Show("Rapor başarıyla kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
