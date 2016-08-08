namespace CariBorcTakip.WinUI
{
    partial class OdemeTanimFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdenenTutar = new System.Windows.Forms.TextBox();
            this.btnOdemeSil = new System.Windows.Forms.Button();
            this.btnOdemeKaydet = new System.Windows.Forms.Button();
            this.btnYeniOdeme = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.chbOdendiMi = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 183);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ÖDENEN TUTAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "TARİH";
            // 
            // txtOdenenTutar
            // 
            this.txtOdenenTutar.Location = new System.Drawing.Point(889, 33);
            this.txtOdenenTutar.Name = "txtOdenenTutar";
            this.txtOdenenTutar.Size = new System.Drawing.Size(210, 20);
            this.txtOdenenTutar.TabIndex = 11;
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Location = new System.Drawing.Point(232, 11);
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(109, 79);
            this.btnOdemeSil.TabIndex = 8;
            this.btnOdemeSil.Text = "ÖDEME SİL";
            this.btnOdemeSil.UseVisualStyleBackColor = true;
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // btnOdemeKaydet
            // 
            this.btnOdemeKaydet.Location = new System.Drawing.Point(117, 11);
            this.btnOdemeKaydet.Name = "btnOdemeKaydet";
            this.btnOdemeKaydet.Size = new System.Drawing.Size(109, 79);
            this.btnOdemeKaydet.TabIndex = 9;
            this.btnOdemeKaydet.Text = "ÖDEME KAYDET";
            this.btnOdemeKaydet.UseVisualStyleBackColor = true;
            this.btnOdemeKaydet.Click += new System.EventHandler(this.btnOdemeKaydet_Click);
            // 
            // btnYeniOdeme
            // 
            this.btnYeniOdeme.Location = new System.Drawing.Point(2, 11);
            this.btnYeniOdeme.Name = "btnYeniOdeme";
            this.btnYeniOdeme.Size = new System.Drawing.Size(109, 79);
            this.btnYeniOdeme.TabIndex = 10;
            this.btnYeniOdeme.Text = "YENİ ÖDEME TANIMLA";
            this.btnYeniOdeme.UseVisualStyleBackColor = true;
            this.btnYeniOdeme.Click += new System.EventHandler(this.btnYeniOdeme_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(889, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ÖDEME TÜRÜ";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(889, 115);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(210, 58);
            this.txtAciklama.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(762, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "AÇIKLAMA";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NAKİT",
            "ÇEK"});
            this.comboBox1.Location = new System.Drawing.Point(889, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ÇEK ÖDEME TARİHİ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(889, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(561, 183);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(538, 292);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // chbOdendiMi
            // 
            this.chbOdendiMi.AutoSize = true;
            this.chbOdendiMi.Location = new System.Drawing.Point(889, 98);
            this.chbOdendiMi.Name = "chbOdendiMi";
            this.chbOdendiMi.Size = new System.Drawing.Size(15, 14);
            this.chbOdendiMi.TabIndex = 17;
            this.chbOdendiMi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ÖDENDİ Mİ";
            // 
            // OdemeTanimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 477);
            this.Controls.Add(this.chbOdendiMi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtOdenenTutar);
            this.Controls.Add(this.btnOdemeSil);
            this.Controls.Add(this.btnOdemeKaydet);
            this.Controls.Add(this.btnYeniOdeme);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OdemeTanimFrm";
            this.Text = "ÖDEME YÖNETİMİ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdenenTutar;
        private System.Windows.Forms.Button btnOdemeSil;
        private System.Windows.Forms.Button btnOdemeKaydet;
        private System.Windows.Forms.Button btnYeniOdeme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox chbOdendiMi;
        private System.Windows.Forms.Label label6;
    }
}