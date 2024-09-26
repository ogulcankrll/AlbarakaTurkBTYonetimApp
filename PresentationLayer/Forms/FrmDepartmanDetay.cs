using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FrmDepartmanDetay : Form
    {
        private DepartmanServis departmanServis;
        private DepartmanDTO departmanDTO;


        public FrmDepartmanDetay(DepartmanDTO departmanDTO)
        {
            InitializeComponent();
            this.departmanDTO = departmanDTO;
            

            txtGuncelleId.Text = departmanDTO.DepartmanID.ToString();
            txtGuncelleAd.Text = departmanDTO.DepartmanAd;
            richTxtGuncelleBilgi.Text = departmanDTO.DepartmanKat;
            txtSilid.Text = departmanDTO.DepartmanID.ToString();
            txtSilAd.Text = departmanDTO.DepartmanAd;
            richTxtSilBilgi.Text = departmanDTO.DepartmanKat;
            tbCtrlDepartmanDetay.SelectedTab=tabPageDepartmanGuncelle;

        }


        public FrmDepartmanDetay()
        {
            InitializeComponent();
            departmanServis = new DepartmanServis();
            
        }

        private void FrmDepartmanDetay_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var yeniDepartman = new Departman
            {
                DepartmanAd = txtEkleAd.Text,
                DepartmanKat = richTxtEkleBilgi.Text
            };

            departmanServis.DepartmanEkle(yeniDepartman);
            MessageBox.Show("Departman başarıyla eklendi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekDepartman = new Departman
            {
                ID = Convert.ToInt32(txtGuncelleId.Text),
                DepartmanAd = txtGuncelleAd.Text,
                DepartmanKat = richTxtGuncelleBilgi.Text
            };

            departmanServis.DepartmanGuncelle(guncellenecekDepartman);
            MessageBox.Show("Departman başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int departmanID = Convert.ToInt32(txtSilid.Text);

            departmanServis.DepartmanSil(departmanID);
            MessageBox.Show("Departman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmDepartmanDetay_Load_1(object sender, EventArgs e)
        {

        }

        private void tabPageDepartmanEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
