namespace PresentationLayer.Forms
{
    partial class FrmDepartmanDetay
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartmanDetay));
            this.tbCtrlDepartmanDetay = new System.Windows.Forms.TabControl();
            this.tabPageDepartmanEkle = new System.Windows.Forms.TabPage();
            this.btnEkle = new System.Windows.Forms.Button();
            this.richTxtEkleBilgi = new System.Windows.Forms.RichTextBox();
            this.txtEkleAd = new System.Windows.Forms.TextBox();
            this.txtEkleID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDepartmanGuncelle = new System.Windows.Forms.TabPage();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.richTxtGuncelleBilgi = new System.Windows.Forms.RichTextBox();
            this.txtGuncelleAd = new System.Windows.Forms.TextBox();
            this.txtGuncelleId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageDepartmanSil = new System.Windows.Forms.TabPage();
            this.btnSil = new System.Windows.Forms.Button();
            this.richTxtSilBilgi = new System.Windows.Forms.RichTextBox();
            this.txtSilAd = new System.Windows.Forms.TextBox();
            this.txtSilid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCtrlDepartmanDetay.SuspendLayout();
            this.tabPageDepartmanEkle.SuspendLayout();
            this.tabPageDepartmanGuncelle.SuspendLayout();
            this.tabPageDepartmanSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlDepartmanDetay
            // 
            this.tbCtrlDepartmanDetay.Controls.Add(this.tabPageDepartmanEkle);
            this.tbCtrlDepartmanDetay.Controls.Add(this.tabPageDepartmanGuncelle);
            this.tbCtrlDepartmanDetay.Controls.Add(this.tabPageDepartmanSil);
            this.tbCtrlDepartmanDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlDepartmanDetay.Location = new System.Drawing.Point(0, 0);
            this.tbCtrlDepartmanDetay.Name = "tbCtrlDepartmanDetay";
            this.tbCtrlDepartmanDetay.SelectedIndex = 0;
            this.tbCtrlDepartmanDetay.Size = new System.Drawing.Size(496, 488);
            this.tbCtrlDepartmanDetay.TabIndex = 0;
            // 
            // tabPageDepartmanEkle
            // 
            this.tabPageDepartmanEkle.Controls.Add(this.btnEkle);
            this.tabPageDepartmanEkle.Controls.Add(this.richTxtEkleBilgi);
            this.tabPageDepartmanEkle.Controls.Add(this.txtEkleAd);
            this.tabPageDepartmanEkle.Controls.Add(this.txtEkleID);
            this.tabPageDepartmanEkle.Controls.Add(this.label3);
            this.tabPageDepartmanEkle.Controls.Add(this.label2);
            this.tabPageDepartmanEkle.Controls.Add(this.label1);
            this.tabPageDepartmanEkle.Location = new System.Drawing.Point(4, 30);
            this.tabPageDepartmanEkle.Name = "tabPageDepartmanEkle";
            this.tabPageDepartmanEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartmanEkle.Size = new System.Drawing.Size(488, 454);
            this.tabPageDepartmanEkle.TabIndex = 0;
            this.tabPageDepartmanEkle.Text = "Departman Ekle";
            this.tabPageDepartmanEkle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(151, 305);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(230, 46);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // richTxtEkleBilgi
            // 
            this.richTxtEkleBilgi.Location = new System.Drawing.Point(151, 156);
            this.richTxtEkleBilgi.Name = "richTxtEkleBilgi";
            this.richTxtEkleBilgi.Size = new System.Drawing.Size(230, 126);
            this.richTxtEkleBilgi.TabIndex = 2;
            this.richTxtEkleBilgi.Text = "";
            // 
            // txtEkleAd
            // 
            this.txtEkleAd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkleAd.Location = new System.Drawing.Point(151, 95);
            this.txtEkleAd.Name = "txtEkleAd";
            this.txtEkleAd.Size = new System.Drawing.Size(230, 35);
            this.txtEkleAd.TabIndex = 1;
            // 
            // txtEkleID
            // 
            this.txtEkleID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkleID.Location = new System.Drawing.Point(151, 36);
            this.txtEkleID.Name = "txtEkleID";
            this.txtEkleID.Size = new System.Drawing.Size(108, 35);
            this.txtEkleID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(116, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kat Bilgisi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Departma Adı:";
            // 
            // tabPageDepartmanGuncelle
            // 
            this.tabPageDepartmanGuncelle.Controls.Add(this.btnGuncelle);
            this.tabPageDepartmanGuncelle.Controls.Add(this.richTxtGuncelleBilgi);
            this.tabPageDepartmanGuncelle.Controls.Add(this.txtGuncelleAd);
            this.tabPageDepartmanGuncelle.Controls.Add(this.txtGuncelleId);
            this.tabPageDepartmanGuncelle.Controls.Add(this.label4);
            this.tabPageDepartmanGuncelle.Controls.Add(this.label5);
            this.tabPageDepartmanGuncelle.Controls.Add(this.label6);
            this.tabPageDepartmanGuncelle.Location = new System.Drawing.Point(4, 30);
            this.tabPageDepartmanGuncelle.Name = "tabPageDepartmanGuncelle";
            this.tabPageDepartmanGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartmanGuncelle.Size = new System.Drawing.Size(488, 454);
            this.tabPageDepartmanGuncelle.TabIndex = 1;
            this.tabPageDepartmanGuncelle.Text = "Departman Güncelle";
            this.tabPageDepartmanGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(151, 305);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(230, 46);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // richTxtGuncelleBilgi
            // 
            this.richTxtGuncelleBilgi.Location = new System.Drawing.Point(151, 156);
            this.richTxtGuncelleBilgi.Name = "richTxtGuncelleBilgi";
            this.richTxtGuncelleBilgi.Size = new System.Drawing.Size(230, 126);
            this.richTxtGuncelleBilgi.TabIndex = 2;
            this.richTxtGuncelleBilgi.Text = "";
            // 
            // txtGuncelleAd
            // 
            this.txtGuncelleAd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelleAd.Location = new System.Drawing.Point(151, 95);
            this.txtGuncelleAd.Name = "txtGuncelleAd";
            this.txtGuncelleAd.Size = new System.Drawing.Size(230, 35);
            this.txtGuncelleAd.TabIndex = 1;
            // 
            // txtGuncelleId
            // 
            this.txtGuncelleId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelleId.Location = new System.Drawing.Point(151, 36);
            this.txtGuncelleId.Name = "txtGuncelleId";
            this.txtGuncelleId.Size = new System.Drawing.Size(108, 35);
            this.txtGuncelleId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(116, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kat Bilgisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Departma Adı:";
            // 
            // tabPageDepartmanSil
            // 
            this.tabPageDepartmanSil.Controls.Add(this.btnSil);
            this.tabPageDepartmanSil.Controls.Add(this.richTxtSilBilgi);
            this.tabPageDepartmanSil.Controls.Add(this.txtSilAd);
            this.tabPageDepartmanSil.Controls.Add(this.txtSilid);
            this.tabPageDepartmanSil.Controls.Add(this.label7);
            this.tabPageDepartmanSil.Controls.Add(this.label8);
            this.tabPageDepartmanSil.Controls.Add(this.label9);
            this.tabPageDepartmanSil.Location = new System.Drawing.Point(4, 30);
            this.tabPageDepartmanSil.Name = "tabPageDepartmanSil";
            this.tabPageDepartmanSil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartmanSil.Size = new System.Drawing.Size(488, 454);
            this.tabPageDepartmanSil.TabIndex = 2;
            this.tabPageDepartmanSil.Text = "DepartmanSil";
            this.tabPageDepartmanSil.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(151, 305);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(230, 46);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // richTxtSilBilgi
            // 
            this.richTxtSilBilgi.Enabled = false;
            this.richTxtSilBilgi.Location = new System.Drawing.Point(151, 156);
            this.richTxtSilBilgi.Name = "richTxtSilBilgi";
            this.richTxtSilBilgi.Size = new System.Drawing.Size(230, 126);
            this.richTxtSilBilgi.TabIndex = 27;
            this.richTxtSilBilgi.Text = "";
            // 
            // txtSilAd
            // 
            this.txtSilAd.Enabled = false;
            this.txtSilAd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilAd.Location = new System.Drawing.Point(151, 95);
            this.txtSilAd.Name = "txtSilAd";
            this.txtSilAd.Size = new System.Drawing.Size(230, 35);
            this.txtSilAd.TabIndex = 25;
            // 
            // txtSilid
            // 
            this.txtSilid.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilid.Location = new System.Drawing.Point(151, 36);
            this.txtSilid.Name = "txtSilid";
            this.txtSilid.Size = new System.Drawing.Size(108, 35);
            this.txtSilid.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(116, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(48, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Kat Bilgisi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(8, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Departma Adı:";
            // 
            // FrmDepartmanDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(496, 488);
            this.Controls.Add(this.tbCtrlDepartmanDetay);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDepartmanDetay";
            this.Text = "Departman Detay";
            this.tbCtrlDepartmanDetay.ResumeLayout(false);
            this.tabPageDepartmanEkle.ResumeLayout(false);
            this.tabPageDepartmanEkle.PerformLayout();
            this.tabPageDepartmanGuncelle.ResumeLayout(false);
            this.tabPageDepartmanGuncelle.PerformLayout();
            this.tabPageDepartmanSil.ResumeLayout(false);
            this.tabPageDepartmanSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtrlDepartmanDetay;
        private System.Windows.Forms.TabPage tabPageDepartmanEkle;
        private System.Windows.Forms.TabPage tabPageDepartmanGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox richTxtEkleBilgi;
        private System.Windows.Forms.TextBox txtEkleAd;
        private System.Windows.Forms.TextBox txtEkleID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageDepartmanSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.RichTextBox richTxtGuncelleBilgi;
        private System.Windows.Forms.TextBox txtGuncelleAd;
        private System.Windows.Forms.TextBox txtGuncelleId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RichTextBox richTxtSilBilgi;
        private System.Windows.Forms.TextBox txtSilAd;
        private System.Windows.Forms.TextBox txtSilid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}