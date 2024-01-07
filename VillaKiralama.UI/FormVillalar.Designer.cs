
namespace VillaKiralama.UI
{
    partial class FormVillalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVillalar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxIlce = new System.Windows.Forms.ComboBox();
            this.comboBoxIl = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonAktifDegil = new System.Windows.Forms.RadioButton();
            this.radioButtonAktif = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxVaillaAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVillalar = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.comboBoxVillaKategori = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVillalar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVillaKategori);
            this.groupBox1.Controls.Add(this.comboBoxIlce);
            this.groupBox1.Controls.Add(this.comboBoxIl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButtonAktifDegil);
            this.groupBox1.Controls.Add(this.radioButtonAktif);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxAdres);
            this.groupBox1.Controls.Add(this.textBoxVaillaAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VİLLA BİLGİLERİ";
            // 
            // comboBoxIlce
            // 
            this.comboBoxIlce.FormattingEnabled = true;
            this.comboBoxIlce.Location = new System.Drawing.Point(520, 49);
            this.comboBoxIlce.Name = "comboBoxIlce";
            this.comboBoxIlce.Size = new System.Drawing.Size(225, 21);
            this.comboBoxIlce.TabIndex = 15;
            // 
            // comboBoxIl
            // 
            this.comboBoxIl.FormattingEnabled = true;
            this.comboBoxIl.Location = new System.Drawing.Point(520, 21);
            this.comboBoxIl.Name = "comboBoxIl";
            this.comboBoxIl.Size = new System.Drawing.Size(225, 21);
            this.comboBoxIl.TabIndex = 14;
            this.comboBoxIl.SelectedIndexChanged += new System.EventHandler(this.comboBoxIl_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "İl :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Resim Ekle:";
            // 
            // radioButtonAktifDegil
            // 
            this.radioButtonAktifDegil.AutoSize = true;
            this.radioButtonAktifDegil.Location = new System.Drawing.Point(189, 84);
            this.radioButtonAktifDegil.Name = "radioButtonAktifDegil";
            this.radioButtonAktifDegil.Size = new System.Drawing.Size(73, 17);
            this.radioButtonAktifDegil.TabIndex = 10;
            this.radioButtonAktifDegil.TabStop = true;
            this.radioButtonAktifDegil.Text = "Aktif Değil";
            this.radioButtonAktifDegil.UseVisualStyleBackColor = true;
            // 
            // radioButtonAktif
            // 
            this.radioButtonAktif.AutoSize = true;
            this.radioButtonAktif.Location = new System.Drawing.Point(89, 84);
            this.radioButtonAktif.Name = "radioButtonAktif";
            this.radioButtonAktif.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAktif.TabIndex = 9;
            this.radioButtonAktif.TabStop = true;
            this.radioButtonAktif.Text = "Aktif";
            this.radioButtonAktif.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aktiflik";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(520, 75);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(229, 79);
            this.textBoxAdres.TabIndex = 6;
            // 
            // textBoxVaillaAdi
            // 
            this.textBoxVaillaAdi.Location = new System.Drawing.Point(89, 49);
            this.textBoxVaillaAdi.Name = "textBoxVaillaAdi";
            this.textBoxVaillaAdi.Size = new System.Drawing.Size(202, 20);
            this.textBoxVaillaAdi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "İlçe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Villa Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewVillalar);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VİLLA LİSTESİ";
            // 
            // dataGridViewVillalar
            // 
            this.dataGridViewVillalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVillalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVillalar.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewVillalar.Name = "dataGridViewVillalar";
            this.dataGridViewVillalar.Size = new System.Drawing.Size(887, 315);
            this.dataGridViewVillalar.TabIndex = 0;
            this.dataGridViewVillalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVillalar_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonTemizle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1146, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonKaydet
            // 
            this.toolStripButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydet.Image")));
            this.toolStripButtonKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
            this.toolStripButtonKaydet.Size = new System.Drawing.Size(72, 24);
            this.toolStripButtonKaydet.Text = "KAYDET";
            this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(88, 24);
            this.toolStripButtonGuncelle.Text = "GÜNCELLE";
            // 
            // toolStripButtonTemizle
            // 
            this.toolStripButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTemizle.Image")));
            this.toolStripButtonTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
            this.toolStripButtonTemizle.Size = new System.Drawing.Size(76, 24);
            this.toolStripButtonTemizle.Text = "TEMİZLE";
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(46, 24);
            this.toolStripButtonSil.Text = "SİL";
            // 
            // comboBoxVillaKategori
            // 
            this.comboBoxVillaKategori.FormattingEnabled = true;
            this.comboBoxVillaKategori.Location = new System.Drawing.Point(89, 21);
            this.comboBoxVillaKategori.Name = "comboBoxVillaKategori";
            this.comboBoxVillaKategori.Size = new System.Drawing.Size(202, 21);
            this.comboBoxVillaKategori.TabIndex = 16;
            // 
            // FormVillalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 706);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVillalar";
            this.Text = "FormVillalar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVillalar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonAktifDegil;
        private System.Windows.Forms.RadioButton radioButtonAktif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxVaillaAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVillalar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.ComboBox comboBoxIlce;
        private System.Windows.Forms.ComboBox comboBoxIl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxVillaKategori;
    }
}