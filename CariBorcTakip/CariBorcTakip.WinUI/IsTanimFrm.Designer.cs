namespace CariBorcTakip.WinUI
{
    partial class IsTanimFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlinacakTutar = new System.Windows.Forms.TextBox();
            this.txtIsTanim = new System.Windows.Forms.TextBox();
            this.btnCariSil = new System.Windows.Forms.Button();
            this.btnCariKaydet = new System.Windows.Forms.Button();
            this.btnYeniCari = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "TARİH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ALINACAK TUTAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "İŞ TANIM";
            // 
            // txtAlinacakTutar
            // 
            this.txtAlinacakTutar.Location = new System.Drawing.Point(449, 42);
            this.txtAlinacakTutar.Name = "txtAlinacakTutar";
            this.txtAlinacakTutar.Size = new System.Drawing.Size(202, 20);
            this.txtAlinacakTutar.TabIndex = 29;
            // 
            // txtIsTanim
            // 
            this.txtIsTanim.Location = new System.Drawing.Point(449, 16);
            this.txtIsTanim.Name = "txtIsTanim";
            this.txtIsTanim.Size = new System.Drawing.Size(202, 20);
            this.txtIsTanim.TabIndex = 27;
            // 
            // btnCariSil
            // 
            this.btnCariSil.Location = new System.Drawing.Point(233, 12);
            this.btnCariSil.Name = "btnCariSil";
            this.btnCariSil.Size = new System.Drawing.Size(109, 79);
            this.btnCariSil.TabIndex = 24;
            this.btnCariSil.Text = "SİL";
            this.btnCariSil.UseVisualStyleBackColor = true;
            this.btnCariSil.Click += new System.EventHandler(this.btnCariSil_Click);
            // 
            // btnCariKaydet
            // 
            this.btnCariKaydet.Location = new System.Drawing.Point(118, 12);
            this.btnCariKaydet.Name = "btnCariKaydet";
            this.btnCariKaydet.Size = new System.Drawing.Size(109, 79);
            this.btnCariKaydet.TabIndex = 25;
            this.btnCariKaydet.Text = "İŞ KAYDET";
            this.btnCariKaydet.UseVisualStyleBackColor = true;
            this.btnCariKaydet.Click += new System.EventHandler(this.btnCariKaydet_Click);
            // 
            // btnYeniCari
            // 
            this.btnYeniCari.Location = new System.Drawing.Point(3, 12);
            this.btnYeniCari.Name = "btnYeniCari";
            this.btnYeniCari.Size = new System.Drawing.Size(109, 79);
            this.btnYeniCari.TabIndex = 26;
            this.btnYeniCari.Text = "YENİ İŞ TANIMLA";
            this.btnYeniCari.UseVisualStyleBackColor = true;
            this.btnYeniCari.Click += new System.EventHandler(this.btnYeniCari_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 423);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(451, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // IsTanimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 522);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlinacakTutar);
            this.Controls.Add(this.txtIsTanim);
            this.Controls.Add(this.btnCariSil);
            this.Controls.Add(this.btnCariKaydet);
            this.Controls.Add(this.btnYeniCari);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "IsTanimFrm";
            this.Text = "İŞ YÖNETİMİ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlinacakTutar;
        private System.Windows.Forms.TextBox txtIsTanim;
        private System.Windows.Forms.Button btnCariSil;
        private System.Windows.Forms.Button btnCariKaydet;
        private System.Windows.Forms.Button btnYeniCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}