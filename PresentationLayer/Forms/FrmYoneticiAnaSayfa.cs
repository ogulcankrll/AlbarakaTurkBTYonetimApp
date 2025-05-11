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

        public void UserControlYukle(UserControl userControl)
        {
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.PersonelUC());
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (dialogResult == DialogResult.Yes)
            {
                FrmYoneticiGiris frmYoneticiGiris = new FrmYoneticiGiris();
                frmYoneticiGiris.Show();
                this.Hide();  
            }
            else
            {
                
            }
        }


        private void btnUrun_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.EnvanterUC());
        }

        private void btnParametreler_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.ParametreUC());
        }

        private void btnZimmetIslemleri_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.UrunKonumUC());
          
        }

        private void btnStajyerKayıt_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.StajyerUC()); 
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.RaporGoruntulemeUC());
        }

        private void btnAnaSyafa_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.AnaSayfaUC());
        }

        private void frmYoneticiAnaSayfa_Load(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.AnaSayfaUC());
        }
    }
}
