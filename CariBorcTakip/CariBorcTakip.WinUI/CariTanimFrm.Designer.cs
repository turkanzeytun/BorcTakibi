namespace CariBorcTakip.WinUI
{
    partial class CariTanimFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.txtCariAd = new System.Windows.Forms.TextBox();
            this.btnCariSil = new System.Windows.Forms.Button();
            this.btnCariKaydet = new System.Windows.Forms.Button();
            this.btnYeniCari = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCariTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cari Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cari İsim";
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(439, 42);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(222, 20);
            this.txtCariKod.TabIndex = 20;
            // 
            // txtCariAd
            // 
            this.txtCariAd.Location = new System.Drawing.Point(439, 16);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(222, 20);
            this.txtCariAd.TabIndex = 19;
            // 
            // btnCariSil
            // 
            this.btnCariSil.Location = new System.Drawing.Point(232, 12);
            this.btnCariSil.Name = "btnCariSil";
            this.btnCariSil.Size = new System.Drawing.Size(109, 79);
            this.btnCariSil.TabIndex = 16;
            this.btnCariSil.Text = "CARİ SİL";
            this.btnCariSil.UseVisualStyleBackColor = true;
            this.btnCariSil.Click += new System.EventHandler(this.btnCariSil_Click);
            // 
            // btnCariKaydet
            // 
            this.btnCariKaydet.Location = new System.Drawing.Point(117, 12);
            this.btnCariKaydet.Name = "btnCariKaydet";
            this.btnCariKaydet.Size = new System.Drawing.Size(109, 79);
            this.btnCariKaydet.TabIndex = 17;
            this.btnCariKaydet.Text = "CARİ KAYDET";
            this.btnCariKaydet.UseVisualStyleBackColor = true;
            this.btnCariKaydet.Click += new System.EventHandler(this.btnCariKaydet_Click);
            // 
            // btnYeniCari
            // 
            this.btnYeniCari.Location = new System.Drawing.Point(2, 12);
            this.btnYeniCari.Name = "btnYeniCari";
            this.btnYeniCari.Size = new System.Drawing.Size(109, 79);
            this.btnYeniCari.TabIndex = 18;
            this.btnYeniCari.Text = "YENİ CARİ TANIMLA";
            this.btnYeniCari.UseVisualStyleBackColor = true;
            this.btnYeniCari.Click += new System.EventHandler(this.btnYeniCari_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 170);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 352);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txtCariTel
            // 
            this.txtCariTel.Location = new System.Drawing.Point(439, 68);
            this.txtCariTel.Name = "txtCariTel";
            this.txtCariTel.Size = new System.Drawing.Size(222, 20);
            this.txtCariTel.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefon No";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(439, 94);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(222, 70);
            this.txtAdres.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Adres";
            // 
            // CariTanimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtCariTel);
            this.Controls.Add(this.txtCariKod);
            this.Controls.Add(this.txtCariAd);
            this.Controls.Add(this.btnCariSil);
            this.Controls.Add(this.btnCariKaydet);
            this.Controls.Add(this.btnYeniCari);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CariTanimFrm";
            this.Text = "CARİ YÖNETİMİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.TextBox txtCariAd;
        private System.Windows.Forms.Button btnCariSil;
        private System.Windows.Forms.Button btnCariKaydet;
        private System.Windows.Forms.Button btnYeniCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCariTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
    }
}