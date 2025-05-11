namespace PresentationLayer.UserControls
{
    partial class EnvanterUC
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
            this.tabPageUrunler = new System.Windows.Forms.TabPage();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.btnUrunYonetim = new System.Windows.Forms.Button();
            this.dataGridViewUrunler = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPageUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 69);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Envanter İşlemleri";
            // 
            // tabPageUrunler
            // 
            this.tabPageUrunler.Controls.Add(this.btnUrunAra);
            this.tabPageUrunler.Controls.Add(this.txtUrunAra);
            this.tabPageUrunler.Controls.Add(this.btnUrunYonetim);
            this.tabPageUrunler.Controls.Add(this.dataGridViewUrunler);
            this.tabPageUrunler.Location = new System.Drawing.Point(4, 34);
            this.tabPageUrunler.Name = "tabPageUrunler";
            this.tabPageUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunler.Size = new System.Drawing.Size(1407, 809);
            this.tabPageUrunler.TabIndex = 1;
            this.tabPageUrunler.Text = "Urunler";
            this.tabPageUrunler.UseVisualStyleBackColor = true;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAra.Location = new System.Drawing.Point(648, 41);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(152, 28);
            this.btnUrunAra.TabIndex = 7;
            this.btnUrunAra.Text = "Arama";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(13, 33);
            this.txtUrunAra.Multiline = true;
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(798, 43);
            this.txtUrunAra.TabIndex = 6;
            // 
            // btnUrunYonetim
            // 
            this.btnUrunYonetim.Location = new System.Drawing.Point(1114, 36);
            this.btnUrunYonetim.Name = "btnUrunYonetim";
            this.btnUrunYonetim.Size = new System.Drawing.Size(179, 35);
            this.btnUrunYonetim.TabIndex = 5;
            this.btnUrunYonetim.Text = "Yönetim";
            this.btnUrunYonetim.UseVisualStyleBackColor = true;
            this.btnUrunYonetim.Click += new System.EventHandler(this.btnUrunYonetim_Click);
            // 
            // dataGridViewUrunler
            // 
            this.dataGridViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.Location = new System.Drawing.Point(13, 82);
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.ReadOnly = true;
            this.dataGridViewUrunler.Size = new System.Drawing.Size(1280, 643);
            this.dataGridViewUrunler.TabIndex = 0;
            this.dataGridViewUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunler_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUrunler);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1415, 847);
            this.tabControl1.TabIndex = 4;
            // 
            // EnvanterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EnvanterUC";
            this.Size = new System.Drawing.Size(1415, 916);
            this.Load += new System.EventHandler(this.EnvanterUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageUrunler.ResumeLayout(false);
            this.tabPageUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageUrunler;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.Button btnUrunYonetim;
        private System.Windows.Forms.DataGridView dataGridViewUrunler;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
