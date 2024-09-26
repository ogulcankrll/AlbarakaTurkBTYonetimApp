namespace PresentationLayer.UserControls
{
    partial class RaporGoruntulemeUC
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
            this.dataGridViewRaporlar = new System.Windows.Forms.DataGridView();
            this.richTxticerik = new System.Windows.Forms.RichTextBox();
            this.txtStajyer = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dtpYazimTarihi = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaporlar)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapor Görüntüleme";
            // 
            // dataGridViewRaporlar
            // 
            this.dataGridViewRaporlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaporlar.Location = new System.Drawing.Point(21, 81);
            this.dataGridViewRaporlar.Name = "dataGridViewRaporlar";
            this.dataGridViewRaporlar.Size = new System.Drawing.Size(1204, 220);
            this.dataGridViewRaporlar.TabIndex = 6;
            this.dataGridViewRaporlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRaporlar_CellClick);
            // 
            // richTxticerik
            // 
            this.richTxticerik.Enabled = false;
            this.richTxticerik.Location = new System.Drawing.Point(22, 374);
            this.richTxticerik.Name = "richTxticerik";
            this.richTxticerik.Size = new System.Drawing.Size(1203, 311);
            this.richTxticerik.TabIndex = 7;
            this.richTxticerik.Text = "";
            // 
            // txtStajyer
            // 
            this.txtStajyer.Enabled = false;
            this.txtStajyer.Location = new System.Drawing.Point(22, 326);
            this.txtStajyer.Name = "txtStajyer";
            this.txtStajyer.Size = new System.Drawing.Size(264, 33);
            this.txtStajyer.TabIndex = 9;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(1024, 700);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(201, 35);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dtpYazimTarihi
            // 
            this.dtpYazimTarihi.Enabled = false;
            this.dtpYazimTarihi.Location = new System.Drawing.Point(954, 326);
            this.dtpYazimTarihi.Name = "dtpYazimTarihi";
            this.dtpYazimTarihi.Size = new System.Drawing.Size(271, 33);
            this.dtpYazimTarihi.TabIndex = 11;
            // 
            // RaporGoruntulemeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpYazimTarihi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtStajyer);
            this.Controls.Add(this.richTxticerik);
            this.Controls.Add(this.dataGridViewRaporlar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RaporGoruntulemeUC";
            this.Size = new System.Drawing.Size(1246, 758);
            this.Load += new System.EventHandler(this.RaporGoruntulemeUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRaporlar;
        private System.Windows.Forms.RichTextBox richTxticerik;
        private System.Windows.Forms.TextBox txtStajyer;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DateTimePicker dtpYazimTarihi;
    }
}
