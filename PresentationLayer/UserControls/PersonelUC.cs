using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class PersonelUC : UserControl
    {
        private PersonelServis personelServis;
        public PersonelUC()
        {
            InitializeComponent();
            personelServis = new PersonelServis();
        }
        
        private void PersonelVerileriniYukle()
        {
            var personelVerileri = personelServis.PersonelDetayGetir();
            dataGridViewPersonel.DataSource = personelVerileri;
           
            dataGridViewPersonel.Columns["SicilNo"].HeaderText = "Sicil Numarası";
            dataGridViewPersonel.Columns["Ad"].HeaderText = "Ad";
            dataGridViewPersonel.Columns["Soyad"].HeaderText = "Soyad";
            dataGridViewPersonel.Columns["TelNo"].HeaderText = "Telefon Numarası";
            dataGridViewPersonel.Columns["Mail"].HeaderText = "Email";
            dataGridViewPersonel.Columns["Pozisyon"].HeaderText = "Pozisyon";
            dataGridViewPersonel.Columns["DepartmanAdi"].HeaderText = "Departman";
        }

        private void DepartmanlariGetir()
        {
            var departmanServis = new DepartmanServis();
            var departmanlar = departmanServis.DepartmanlariGetir();

            cmbDepartman.DisplayMember = "DepartmanAd"; 
            cmbDepartman.ValueMember = "DepartmanID"; 
            cmbDepartman.DataSource = departmanlar;
        }
        private void PersonelUC_Load(object sender, EventArgs e)
        {
            PersonelVerileriniYukle();
            DepartmanlariGetir();

        }
         
        private void btnAra_Click(object sender, EventArgs e)
        {
            var personelListesi = personelServis.PersonelDetayGetir();
            string aramaKriteri = txtArama.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaKriteri))
            {
                
                dataGridViewPersonel.DataSource = personelListesi;
            }
            else
            {
                
                var aramaSonucu = personelListesi
                    .Where(p => p.Ad.ToLower().Contains(aramaKriteri) ||
                                p.Soyad.ToLower().Contains(aramaKriteri) ||
                                p.SicilNo.ToString().Contains(aramaKriteri) ||
                                p.Pozisyon.ToLower().Contains(aramaKriteri))
                    .ToList();

                dataGridViewPersonel.DataSource = aramaSonucu;
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
           
            PersonelProfil yeniPersonel = new PersonelProfil
            {
                SicilNo = txtSicilNo.Text,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TelefonNumarasi = mskTelNo.Text,
                Email = txtEMail.Text,
                Pozisyon = txtPozisyon.Text,
                DepartmanID = (int)cmbDepartman.SelectedValue, 
                BaslangicTarihi = DateTime.Now 
            };

            
            var personelServis = new PersonelServis();
            personelServis.PersonelEkle(yeniPersonel);

            MessageBox.Show("Personel başarıyla eklendi.");
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PersonelProfil guncellenecekPersonel = new PersonelProfil
            {
                ID = Convert.ToInt32(txtId.Text),
                SicilNo = txtSicilNo.Text,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TelefonNumarasi = mskTelNo.Text,
                Email = txtEMail.Text,
                Pozisyon = txtPozisyon.Text,
                DepartmanID = (int)cmbDepartman.SelectedValue,

            };

            personelServis.PersonelGuncelle(guncellenecekPersonel);

            MessageBox.Show("Personel başarıyla güncellendi.");
            PersonelVerileriniYukle();
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtId.Text, out int personelID))
            {
               
                var personelServis = new PersonelServis();

                try
                {
                   
                    personelServis.PersonelSil(personelID);

                   
                    MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    PersonelVerileriniYukle();
                    tabControl1.SelectedTab = tabPage1;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
              
                MessageBox.Show("Geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int personelID = Convert.ToInt32(dataGridViewPersonel.Rows[e.RowIndex].Cells["ID"].Value);
                PersonelProfil personel =personelServis.PersonelBul(personelID);
                txtId.Text = Convert.ToString(personel.ID);
                txtSicilNo.Text = personel.SicilNo;
                txtAd.Text = personel.Ad;
                txtSoyad.Text = personel.Soyad;
                mskTelNo.Text = personel.TelefonNumarasi;
                txtEMail.Text = personel.Email;
                txtPozisyon.Text = personel.Pozisyon;
                cmbDepartman.SelectedValue = personel.DepartmanID;

                tabControl1.SelectedTab = tabPage2;

            }

        }
    }
}
