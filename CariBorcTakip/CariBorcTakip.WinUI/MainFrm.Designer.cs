namespace CariBorcTakip.WinUI
{
    partial class MainFrm
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
            this.btnYeniCari = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnYeniIs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnYedekAl = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnYeniCari
            // 
            this.btnYeniCari.Location = new System.Drawing.Point(3, 12);
            this.btnYeniCari.Name = "btnYeniCari";
            this.btnYeniCari.Size = new System.Drawing.Size(109, 79);
            this.btnYeniCari.TabIndex = 1;
            this.btnYeniCari.Text = "CARİ YÖNETİMİ";
            this.btnYeniCari.UseVisualStyleBackColor = true;
            this.btnYeniCari.Click += new System.EventHandler(this.btnYeniCari_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(632, 97);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(610, 425);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // btnYeniIs
            // 
            this.btnYeniIs.Location = new System.Drawing.Point(118, 12);
            this.btnYeniIs.Name = "btnYeniIs";
            this.btnYeniIs.Size = new System.Drawing.Size(109, 79);
            this.btnYeniIs.TabIndex = 1;
            this.btnYeniIs.Text = "İŞ YÖNETİMİ";
            this.btnYeniIs.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1133, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "KAPAT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnYedekAl
            // 
            this.btnYedekAl.Location = new System.Drawing.Point(1018, 12);
            this.btnYedekAl.Name = "btnYedekAl";
            this.btnYedekAl.Size = new System.Drawing.Size(109, 79);
            this.btnYedekAl.TabIndex = 1;
            this.btnYedekAl.Text = "YEDEK AL";
            this.btnYedekAl.UseVisualStyleBackColor = true;
            this.btnYedekAl.Click += new System.EventHandler(this.btnYedekAl_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(903, 12);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(109, 79);
            this.btnRapor.TabIndex = 1;
            this.btnRapor.Text = "RAPORLAR";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 531);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnYedekAl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYeniIs);
            this.Controls.Add(this.btnYeniCari);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainFrm";
            this.Text = "CARİ BORÇ TAKİBİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYeniCari;
        private System.Windows.Forms.Button btnYeniIs;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnYedekAl;
        private System.Windows.Forms.Button btnRapor;
    }
}

