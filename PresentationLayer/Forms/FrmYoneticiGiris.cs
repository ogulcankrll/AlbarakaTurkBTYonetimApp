using BusinessLogicLayer.GenericRepository;
using BusinessLogicLayer.Services;
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
            YoneticiRepository yoneticiRepo= new YoneticiRepository();   
            girisServis= new GirisServis(yoneticiRepo);   
            
        }
        

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chbSifreGoster.Checked ? '\0' : '*';
            
        }

        private void btnCozumVadisiGiris_Click(object sender, EventArgs e)
        {
            FrmCozumVadisiGiris fr = new FrmCozumVadisiGiris();
            fr.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;   
            if(girisServis.YoneticiGirisi(kullaniciAdi, sifre))
            {
                frmYoneticiAnaSayfa.Show();
                this.Hide();
            }
            else
            {
               MessageBox.Show("Kullanıcı adı veya şifre hatalı","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
