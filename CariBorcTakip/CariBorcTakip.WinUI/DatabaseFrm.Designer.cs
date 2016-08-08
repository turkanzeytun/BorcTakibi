namespace CariBorcTakip.WinUI
{
    partial class DatabaseFrm
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
            this.btnDatabaseRestore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDatabaseYedekle = new System.Windows.Forms.Button();
            this.btnDatabaseSil = new System.Windows.Forms.Button();
            this.btnDatabaseCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDatabaseRestore
            // 
            this.btnDatabaseRestore.Location = new System.Drawing.Point(100, 200);
            this.btnDatabaseRestore.Name = "btnDatabaseRestore";
            this.btnDatabaseRestore.Size = new System.Drawing.Size(158, 46);
            this.btnDatabaseRestore.TabIndex = 10;
            this.btnDatabaseRestore.Text = "DATABASE RESTORE";
            this.btnDatabaseRestore.UseVisualStyleBackColor = true;
            this.btnDatabaseRestore.Click += new System.EventHandler(this.btnDatabaseRestore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "FİRMA ADI:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btnDatabaseYedekle
            // 
            this.btnDatabaseYedekle.Location = new System.Drawing.Point(101, 148);
            this.btnDatabaseYedekle.Name = "btnDatabaseYedekle";
            this.btnDatabaseYedekle.Size = new System.Drawing.Size(159, 46);
            this.btnDatabaseYedekle.TabIndex = 6;
            this.btnDatabaseYedekle.Text = "DATABASE YEDEKLE";
            this.btnDatabaseYedekle.UseVisualStyleBackColor = true;
            this.btnDatabaseYedekle.Click += new System.EventHandler(this.btnDatabaseYedekle_Click);
            // 
            // btnDatabaseSil
            // 
            this.btnDatabaseSil.Location = new System.Drawing.Point(101, 96);
            this.btnDatabaseSil.Name = "btnDatabaseSil";
            this.btnDatabaseSil.Size = new System.Drawing.Size(159, 46);
            this.btnDatabaseSil.TabIndex = 7;
            this.btnDatabaseSil.Text = "DATABASE SİL";
            this.btnDatabaseSil.UseVisualStyleBackColor = true;
            this.btnDatabaseSil.Click += new System.EventHandler(this.btnDatabaseSil_Click);
            // 
            // btnDatabaseCreate
            // 
            this.btnDatabaseCreate.Location = new System.Drawing.Point(101, 42);
            this.btnDatabaseCreate.Name = "btnDatabaseCreate";
            this.btnDatabaseCreate.Size = new System.Drawing.Size(159, 48);
            this.btnDatabaseCreate.TabIndex = 5;
            this.btnDatabaseCreate.Text = "DATABASE OLUŞTUR";
            this.btnDatabaseCreate.UseVisualStyleBackColor = true;
            this.btnDatabaseCreate.Click += new System.EventHandler(this.btnDatabaseCreate_Click);
            // 
            // DatabaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDatabaseRestore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDatabaseYedekle);
            this.Controls.Add(this.btnDatabaseSil);
            this.Controls.Add(this.btnDatabaseCreate);
            this.Name = "DatabaseFrm";
            this.Text = "DatabaseFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDatabaseRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDatabaseYedekle;
        private System.Windows.Forms.Button btnDatabaseSil;
        private System.Windows.Forms.Button btnDatabaseCreate;
    }
}