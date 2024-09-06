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
    public partial class FrmCozumVadisiGiris : Form
    {
        GirisServis girisServis;
        public FrmCozumVadisiGiris()
        {
            InitializeComponent();
           KullaniciPersonelRepository personelRepo= new KullaniciPersonelRepository(); 
           girisServis= new GirisServis(personelRepo);
        }

        private void FrmCozumVadisiGiris_Load(object sender, EventArgs e)
        {

        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            FrmYoneticiGiris fr = new FrmYoneticiGiris();
            fr.Show();  
            this.Hide();
        }

        private void chbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chbSifreGoster.Checked ? '\0' : '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi=txtKullaniciAdi.Text;   
            string sifre=txtSifre.Text; 
            if(girisServis.PersonelGiris(kullaniciAdi, sifre))
            {
                MessageBox.Show("lkxsahonsdmka");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
