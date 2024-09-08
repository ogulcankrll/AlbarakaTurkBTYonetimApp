using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmYoneticiAnaSayfa : Form
    {
        public frmYoneticiAnaSayfa()
        {
            InitializeComponent();
        }

        bool menuGenislet = false;
        private void MenuGecisi_Tick(object sender, EventArgs e)
        {
            
            if (menuGenislet)
            {
                flpMenu.Width += 10; 
                if (flpMenu.Width >= 249) 
                {
                    MenuGecisi.Stop(); 
                    menuGenislet = false; 
                }
            }
           
            else
            {
                flpMenu.Width -= 10; 
                if (flpMenu.Width <= 65) 
                {
                    MenuGecisi.Stop(); 
                    menuGenislet = true; 
                }
            }
        }


        private void pctMenuButon_Click(object sender, EventArgs e)
        {
            MenuGecisi.Start(); 
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            UserControls.PersonelUC personelUC = new UserControls.PersonelUC();
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(personelUC);


        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            FrmYoneticiGiris frmYoneticiGiris = new FrmYoneticiGiris(); 
            frmYoneticiGiris.Show();    
            this.Hide();
        }
    }
}
