namespace PresentationLayer.UserControls
{
    partial class UrunKonumUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKonumUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTxtAciklama = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnArama = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.dataGridViewUrunKonum = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunKonum)).BeginInit();
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
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Konum Takip";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.richTxtAciklama);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Controls.Add(this.cmbPersonel);
            this.panel2.Controls.Add(this.lblPersonel);
            this.panel2.Controls.Add(this.cmbKonum);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbUrun);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbKategori);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(18, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 376);
            this.panel2.TabIndex = 6;
            // 
            // richTxtAciklama
            // 
            this.richTxtAciklama.Location = new System.Drawing.Point(111, 208);
            this.richTxtAciklama.Name = "richTxtAciklama";
            this.richTxtAciklama.Size = new System.Drawing.Size(994, 96);
            this.richTxtAciklama.TabIndex = 3;
            this.richTxtAciklama.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(976, 310);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(129, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(111, 157);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(994, 33);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.Visible = false;
            this.cmbPersonel.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbPersonel_Format);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.ForeColor = System.Drawing.Color.Black;
            this.lblPersonel.Location = new System.Drawing.Point(17, 160);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(88, 25);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel:";
            this.lblPersonel.Visible = false;
            // 
            // cmbKonum
            // 
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Location = new System.Drawing.Point(111, 109);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(994, 33);
            this.cmbKonum.TabIndex = 1;
            this.cmbKonum.SelectedIndexChanged += new System.EventHandler(this.cmbKonum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Konum:";
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(111, 65);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(994, 33);
            this.cmbUrun.TabIndex = 1;
            this.cmbUrun.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbUrun_Format);
            this.cmbUrun.TextChanged += new System.EventHandler(this.cmbUrun_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(111, 19);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(191, 33);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnArama);
            this.panel3.Controls.Add(this.txtArama);
            this.panel3.Controls.Add(this.dataGridViewUrunKonum);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(18, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1202, 390);
            this.panel3.TabIndex = 7;
            // 
            // btnArama
            // 
            this.btnArama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.Image = ((System.Drawing.Image)(resources.GetObject("btnArama.Image")));
            this.btnArama.Location = new System.Drawing.Point(502, 17);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(55, 28);
            this.btnArama.TabIndex = 2;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(22, 13);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(474, 33);
            this.txtArama.TabIndex = 1;
            // 
            // dataGridViewUrunKonum
            // 
            this.dataGridViewUrunKonum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUrunKonum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunKonum.Location = new System.Drawing.Point(22, 58);
            this.dataGridViewUrunKonum.Name = "dataGridViewUrunKonum";
            this.dataGridViewUrunKonum.Size = new System.Drawing.Size(1159, 315);
            this.dataGridViewUrunKonum.TabIndex = 0;
            this.dataGridViewUrunKonum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunKonum_CellClick);
            // 
            // UrunKonumUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UrunKonumUC";
            this.Size = new System.Drawing.Size(1246, 867);
            this.Load += new System.EventHandler(this.UrunKonumUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunKonum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewUrunKonum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RichTextBox richTxtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.TextBox txtArama;
    }
}
