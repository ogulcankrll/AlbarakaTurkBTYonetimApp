using BusinessLogicLayer.GenericRepository;
using BusinessLogicLayer.Services;
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

namespace PresentationLayer
{
    public partial class FrmYoneticiGiris : Form
    {
        GirisServis girisServis;
        frmYoneticiAnaSayfa frmYoneticiAnaSayfa = new frmYoneticiAnaSayfa();

        public FrmYoneticiGiris()
        {
            InitializeComponent();
            YoneticiRepository yoneticiRepo = new YoneticiRepository();
            girisServis = new GirisServis(yoneticiRepo);
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void chbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chbSifreGoster.Checked ? '\0' : '*';
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

            
            if (girisServis.YoneticiGirisi(kullaniciAdi, sifre))
            {
                frmYoneticiAnaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStajyerGiris_Click(object sender, EventArgs e)
        {
            FrmStajyerGiris frmStajyerGiris = new FrmStajyerGiris();
            frmStajyerGiris.Show();
            this.Hide();
        }
    }
}
