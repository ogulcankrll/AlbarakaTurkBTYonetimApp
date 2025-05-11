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
            tbCtrlDepartmanDetay.SelectedTab = tabPageDepartmanGuncelle;
        }

        public FrmDepartmanDetay()
        {
            InitializeComponent();
            departmanServis = new DepartmanServis();
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtEkleAd.Text) || string.IsNullOrWhiteSpace(richTxtEkleBilgi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var yeniDepartman = new Departman
                {
                    DepartmanAd = txtEkleAd.Text,
                    DepartmanKat = richTxtEkleBilgi.Text
                };

                departmanServis.DepartmanEkle(yeniDepartman);
                MessageBox.Show("Departman başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                txtEkleAd.Clear();
                richTxtEkleBilgi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtGuncelleAd.Text) || string.IsNullOrWhiteSpace(richTxtGuncelleBilgi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int departmanID = Convert.ToInt32(txtSilid.Text);

                departmanServis.DepartmanSil(departmanID);
                MessageBox.Show("Departman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
