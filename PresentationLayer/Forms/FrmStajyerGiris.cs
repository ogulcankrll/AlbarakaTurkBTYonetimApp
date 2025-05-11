using BusinessLogicLayer.Services;
using DataAccessLayer.GenericRepository;
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
    public partial class FrmStajyerGiris : Form
    {
        GirisServis GirisServis;

        public FrmStajyerGiris()
        {
            InitializeComponent();
            StajyerRepository stajyerRepository = new StajyerRepository();
            GirisServis = new GirisServis(stajyerRepository);
        }

        private void chbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chbSifreGoster.Checked ? '\0' : '*';
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            FrmYoneticiGiris frmYoneticiGiris = new FrmYoneticiGiris();
            frmYoneticiGiris.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim(); 
            string sifre = txtSifre.Text.Trim(); 

           
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

       
            int stajyerId = GirisServis.StajyerGirisi(kullaniciAdi, sifre);

            if (stajyerId > 0) 
            {
                
                FrmStajyerAnaSayfa frmStajyerAnaSayfa = new FrmStajyerAnaSayfa(stajyerId);
                frmStajyerAnaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
