using BusinessLogicLayer.Services;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class PersonelUC : UserControl
    {
        private readonly PersonelServis personelServis;
        private readonly DepartmanServis departmanServis;

        public PersonelUC()
        {
            InitializeComponent();
            personelServis = new PersonelServis();
            departmanServis = new DepartmanServis();
        }

        
        private void PersonelVerileriniYukle()
        {
            var personelVerileri = personelServis.PersonelDetayGetir();
            dataGridViewPersonel.DataSource = personelVerileri;
            dataGridViewPersonel.Columns["ID"].Visible = false; 
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
            var departmanlar = departmanServis.DepartmanlariGetir();
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "DepartmanID";
            cmbDepartman.DataSource = departmanlar;
        }

        
        private void Temizle()
        {
            txtAd.Clear();
            txtEMail.Clear();
            mskTelNo.Clear();
            txtSicilNo.Clear();
            txtId.Clear();
            txtSoyad.Clear();
            txtPozisyon.Clear();
            cmbDepartman.SelectedIndex = -1; 
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
                                p.SicilNo.Contains(aramaKriteri) ||
                                p.Pozisyon.ToLower().Contains(aramaKriteri))
                    .ToList();

                dataGridViewPersonel.DataSource = aramaSonucu;
            }
        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtSicilNo.Text) ||
                string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(mskTelNo.Text) ||
                string.IsNullOrWhiteSpace(txtEMail.Text) ||
                string.IsNullOrWhiteSpace(txtPozisyon.Text) ||
                cmbDepartman.SelectedValue == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
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
            tabControl1.SelectedTab = tabPageListe;
            Temizle();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var guncellenecekPersonel = new PersonelProfil
                {
                    ID = Convert.ToInt32(txtId.Text),
                    SicilNo = txtSicilNo.Text,
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TelefonNumarasi = mskTelNo.Text,
                    Email = txtEMail.Text,
                    Pozisyon = txtPozisyon.Text,
                    DepartmanID = (int)cmbDepartman.SelectedValue
                };

                personelServis.PersonelGuncelle(guncellenecekPersonel);

                MessageBox.Show("Personel başarıyla güncellendi.");
                PersonelVerileriniYukle();
                Temizle();
                tabControl1.SelectedTab = tabPageListe;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int personelID))
            {
                try
                {
                    personelServis.PersonelSil(personelID);
                    MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonelVerileriniYukle();
                    Temizle();
                    tabControl1.SelectedTab = tabPageListe;
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
                var personel = personelServis.PersonelBul(personelID);

                txtId.Text = personel.ID.ToString();
                txtSicilNo.Text = personel.SicilNo;
                txtAd.Text = personel.Ad;
                txtSoyad.Text = personel.Soyad;
                mskTelNo.Text = personel.TelefonNumarasi;
                txtEMail.Text = personel.Email;
                txtPozisyon.Text = personel.Pozisyon;
                cmbDepartman.SelectedValue = personel.DepartmanID;
                tabControl1.SelectedTab = tabPageDetay;
            }
        }

        private void tabPageDetay_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridViewPersonel_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
            Color renk1 = Color.LightGray;
            Color renk2 = Color.White;
           
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewPersonel.Rows[e.RowIndex].DefaultCellStyle.BackColor = renk1;
            }
            else
            {
                dataGridViewPersonel.Rows[e.RowIndex].DefaultCellStyle.BackColor = renk2;
            }
        }
    }
}
