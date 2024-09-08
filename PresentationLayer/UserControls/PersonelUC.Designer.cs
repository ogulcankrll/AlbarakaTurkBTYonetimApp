namespace PresentationLayer.UserControls
{
    partial class PersonelUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.mskTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSicilNo = new System.Windows.Forms.TextBox();
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 63);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel İşlemleri";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSil);
            this.tabPage2.Controls.Add(this.btnEkle);
            this.tabPage2.Controls.Add(this.btnGuncelle);
            this.tabPage2.Controls.Add(this.cmbDepartman);
            this.tabPage2.Controls.Add(this.mskTelNo);
            this.tabPage2.Controls.Add(this.txtEMail);
            this.tabPage2.Controls.Add(this.txtSoyad);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.txtSicilNo);
            this.tabPage2.Controls.Add(this.txtPozisyon);
            this.tabPage2.Controls.Add(this.txtAd);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1238, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Detay";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(585, 477);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(205, 55);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(163, 477);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(205, 55);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Güncelle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(374, 477);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(205, 55);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(459, 413);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(266, 33);
            this.cmbDepartman.TabIndex = 7;
            // 
            // mskTelNo
            // 
            this.mskTelNo.Location = new System.Drawing.Point(163, 318);
            this.mskTelNo.Mask = "(999) 000-0000";
            this.mskTelNo.Name = "mskTelNo";
            this.mskTelNo.Size = new System.Drawing.Size(266, 33);
            this.mskTelNo.TabIndex = 4;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(459, 318);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(266, 33);
            this.txtEMail.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(459, 228);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(266, 33);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(163, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(266, 33);
            this.txtId.TabIndex = 1;
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.Location = new System.Drawing.Point(163, 149);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.Size = new System.Drawing.Size(266, 33);
            this.txtSicilNo.TabIndex = 1;
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.Location = new System.Drawing.Point(163, 413);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(266, 33);
            this.txtPozisyon.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(163, 228);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(266, 33);
            this.txtAd.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(454, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Departman:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(158, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pozisyon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(454, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "E Posta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(158, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon  Numarası:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(163, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(158, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sicil Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(454, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(158, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnAra);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtArama);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1238, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Listesi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewPersonel);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(15, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 547);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(-2, -2);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.ReadOnly = true;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(1208, 551);
            this.dataGridViewPersonel.TabIndex = 0;
            this.dataGridViewPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonel_CellClick);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(710, 37);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(149, 36);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ara:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(15, 37);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(679, 33);
            this.txtArama.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 681);
            this.tabControl1.TabIndex = 3;
            // 
            // PersonelUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PersonelUC";
            this.Size = new System.Drawing.Size(1246, 744);
            this.Load += new System.EventHandler(this.PersonelUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.MaskedTextBox mskTelNo;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSicilNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.Button btnEkle;
    }
}
