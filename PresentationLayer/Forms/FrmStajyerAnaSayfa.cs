using EntityLayer.Models;
using PresentationLayer.UserControls;
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
    public partial class FrmStajyerAnaSayfa : Form
    {
        private int stajyerID;
        public FrmStajyerAnaSayfa(int id)
        {
            InitializeComponent();
            stajyerID = id;

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
        public void UserControlYukle(UserControl userControl)
        {
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void pctMenuButon_Click(object sender, EventArgs e)
        {
            MenuGecisi.Start();
        }

    

       

        private void btnEnvanter_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.EnvanterUC());
        }

        private void btnUrunKonum_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.UrunKonumUC());   
        }

        private void btnRaporYaz_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.RaporYazmaUC(stajyerID));  
        }

        private void FrmStajyerAnaSayfa_Load(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.AnaSayfaUC());
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (dialogResult == DialogResult.Yes)
            {
                FrmStajyerGiris frmStajyerGiris = new FrmStajyerGiris();
                frmStajyerGiris.Show();
                this.Hide();  
            }
           
        }

        private void btnAnaSyafa_Click(object sender, EventArgs e)
        {
            UserControlYukle(new UserControls.AnaSayfaUC());
        }
    }
}
