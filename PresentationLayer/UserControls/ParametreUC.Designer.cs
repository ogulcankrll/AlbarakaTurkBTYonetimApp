namespace PresentationLayer.UserControls
{
    partial class ParametreUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KategoriSayfasi = new System.Windows.Forms.TabPage();
            this.btnKategoriDetay = new System.Windows.Forms.Button();
            this.dataGridViewKategoriler = new System.Windows.Forms.DataGridView();
            this.btnKategoriAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKategoriArama = new System.Windows.Forms.TextBox();
            this.DepartmanSayfasi = new System.Windows.Forms.TabPage();
            this.btnDepartmanDetay = new System.Windows.Forms.Button();
            this.dataGridViewDepartmanlar = new System.Windows.Forms.DataGridView();
            this.btnDepartmanAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartmanArama = new System.Windows.Forms.TextBox();
            this.tabCtrlParemetre = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.KategoriSayfasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategoriler)).BeginInit();
            this.DepartmanSayfasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmanlar)).BeginInit();
            this.tabCtrlParemetre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parametre İşlemleri";
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
            this.panel1.TabIndex = 3;
            // 
            // KategoriSayfasi
            // 
            this.KategoriSayfasi.Controls.Add(this.btnKategoriDetay);
            this.KategoriSayfasi.Controls.Add(this.dataGridViewKategoriler);
            this.KategoriSayfasi.Controls.Add(this.btnKategoriAra);
            this.KategoriSayfasi.Controls.Add(this.label3);
            this.KategoriSayfasi.Controls.Add(this.txtKategoriArama);
            this.KategoriSayfasi.Location = new System.Drawing.Point(4, 34);
            this.KategoriSayfasi.Name = "KategoriSayfasi";
            this.KategoriSayfasi.Padding = new System.Windows.Forms.Padding(3);
            this.KategoriSayfasi.Size = new System.Drawing.Size(1238, 643);
            this.KategoriSayfasi.TabIndex = 1;
            this.KategoriSayfasi.Text = "Kategori";
            this.KategoriSayfasi.UseVisualStyleBackColor = true;
            // 
            // btnKategoriDetay
            // 
            this.btnKategoriDetay.Location = new System.Drawing.Point(278, 580);
            this.btnKategoriDetay.Name = "btnKategoriDetay";
            this.btnKategoriDetay.Size = new System.Drawing.Size(628, 45);
            this.btnKategoriDetay.TabIndex = 13;
            this.btnKategoriDetay.Text = "Detay";
            this.btnKategoriDetay.UseVisualStyleBackColor = true;
            this.btnKategoriDetay.Click += new System.EventHandler(this.btnKategoriDetay_Click);
            // 
            // dataGridViewKategoriler
            // 
            this.dataGridViewKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategoriler.Location = new System.Drawing.Point(278, 82);
            this.dataGridViewKategoriler.Name = "dataGridViewKategoriler";
            this.dataGridViewKategoriler.Size = new System.Drawing.Size(628, 492);
            this.dataGridViewKategoriler.TabIndex = 12;
            this.dataGridViewKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKategoriler_CellClick);
            // 
            // btnKategoriAra
            // 
            this.btnKategoriAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriAra.Location = new System.Drawing.Point(759, 34);
            this.btnKategoriAra.Name = "btnKategoriAra";
            this.btnKategoriAra.Size = new System.Drawing.Size(136, 27);
            this.btnKategoriAra.TabIndex = 11;
            this.btnKategoriAra.Text = "Ara";
            this.btnKategoriAra.UseVisualStyleBackColor = true;
            this.btnKategoriAra.Click += new System.EventHandler(this.btnKategoriAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(274, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kategori Ara:";
            // 
            // txtKategoriArama
            // 
            this.txtKategoriArama.Location = new System.Drawing.Point(278, 28);
            this.txtKategoriArama.Multiline = true;
            this.txtKategoriArama.Name = "txtKategoriArama";
            this.txtKategoriArama.Size = new System.Drawing.Size(628, 40);
            this.txtKategoriArama.TabIndex = 9;
            // 
            // DepartmanSayfasi
            // 
            this.DepartmanSayfasi.Controls.Add(this.btnDepartmanDetay);
            this.DepartmanSayfasi.Controls.Add(this.dataGridViewDepartmanlar);
            this.DepartmanSayfasi.Controls.Add(this.btnDepartmanAra);
            this.DepartmanSayfasi.Controls.Add(this.label2);
            this.DepartmanSayfasi.Controls.Add(this.txtDepartmanArama);
            this.DepartmanSayfasi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmanSayfasi.Location = new System.Drawing.Point(4, 34);
            this.DepartmanSayfasi.Name = "DepartmanSayfasi";
            this.DepartmanSayfasi.Padding = new System.Windows.Forms.Padding(3);
            this.DepartmanSayfasi.Size = new System.Drawing.Size(1238, 643);
            this.DepartmanSayfasi.TabIndex = 0;
            this.DepartmanSayfasi.Text = "Departman";
            this.DepartmanSayfasi.UseVisualStyleBackColor = true;
            this.DepartmanSayfasi.Click += new System.EventHandler(this.DepartmanSayfasi_Click);
            // 
            // btnDepartmanDetay
            // 
            this.btnDepartmanDetay.Location = new System.Drawing.Point(281, 579);
            this.btnDepartmanDetay.Name = "btnDepartmanDetay";
            this.btnDepartmanDetay.Size = new System.Drawing.Size(625, 45);
            this.btnDepartmanDetay.TabIndex = 8;
            this.btnDepartmanDetay.Text = "Detay";
            this.btnDepartmanDetay.UseVisualStyleBackColor = true;
            this.btnDepartmanDetay.Click += new System.EventHandler(this.btnDepartmanDetay_Click);
            // 
            // dataGridViewDepartmanlar
            // 
            this.dataGridViewDepartmanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmanlar.Location = new System.Drawing.Point(278, 81);
            this.dataGridViewDepartmanlar.Name = "dataGridViewDepartmanlar";
            this.dataGridViewDepartmanlar.Size = new System.Drawing.Size(628, 492);
            this.dataGridViewDepartmanlar.TabIndex = 7;
            this.dataGridViewDepartmanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartmanlar_CellClick);
            this.dataGridViewDepartmanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartmanlar_CellContentClick);
            // 
            // btnDepartmanAra
            // 
            this.btnDepartmanAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanAra.Location = new System.Drawing.Point(759, 34);
            this.btnDepartmanAra.Name = "btnDepartmanAra";
            this.btnDepartmanAra.Size = new System.Drawing.Size(136, 27);
            this.btnDepartmanAra.TabIndex = 6;
            this.btnDepartmanAra.Text = "Ara";
            this.btnDepartmanAra.UseVisualStyleBackColor = true;
            this.btnDepartmanAra.Click += new System.EventHandler(this.btnDepartmanAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(274, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Departman Ara:";
            // 
            // txtDepartmanArama
            // 
            this.txtDepartmanArama.Location = new System.Drawing.Point(278, 28);
            this.txtDepartmanArama.Multiline = true;
            this.txtDepartmanArama.Name = "txtDepartmanArama";
            this.txtDepartmanArama.Size = new System.Drawing.Size(628, 40);
            this.txtDepartmanArama.TabIndex = 4;
            // 
            // tabCtrlParemetre
            // 
            this.tabCtrlParemetre.Controls.Add(this.DepartmanSayfasi);
            this.tabCtrlParemetre.Controls.Add(this.KategoriSayfasi);
            this.tabCtrlParemetre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlParemetre.Location = new System.Drawing.Point(0, 63);
            this.tabCtrlParemetre.Name = "tabCtrlParemetre";
            this.tabCtrlParemetre.SelectedIndex = 0;
            this.tabCtrlParemetre.Size = new System.Drawing.Size(1246, 681);
            this.tabCtrlParemetre.TabIndex = 4;
            // 
            // ParametreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCtrlParemetre);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ParametreUC";
            this.Size = new System.Drawing.Size(1246, 744);
            this.Load += new System.EventHandler(this.ParametreUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.KategoriSayfasi.ResumeLayout(false);
            this.KategoriSayfasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategoriler)).EndInit();
            this.DepartmanSayfasi.ResumeLayout(false);
            this.DepartmanSayfasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmanlar)).EndInit();
            this.tabCtrlParemetre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage KategoriSayfasi;
        private System.Windows.Forms.Button btnKategoriDetay;
        private System.Windows.Forms.DataGridView dataGridViewKategoriler;
        private System.Windows.Forms.Button btnKategoriAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKategoriArama;
        private System.Windows.Forms.TabPage DepartmanSayfasi;
        private System.Windows.Forms.Button btnDepartmanDetay;
        private System.Windows.Forms.DataGridView dataGridViewDepartmanlar;
        private System.Windows.Forms.Button btnDepartmanAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartmanArama;
        private System.Windows.Forms.TabControl tabCtrlParemetre;
    }
}
