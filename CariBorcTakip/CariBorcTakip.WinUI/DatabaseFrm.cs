using CariBorcTakip.DAL.Concrates.AdoNet;//dal ile bağlantı kopacak
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariBorcTakip.WinUI
{
    public partial class DatabaseFrm : Form
    {
        public DatabaseFrm()
        {
            InitializeComponent();
        }

        private void btnDatabaseSil_Click(object sender, EventArgs e)
        {
            DatabaseManager mng = new DatabaseManager();
            string sonuc = mng.DropDB(textBox1.Text);
            MessageBox.Show(sonuc);
        }

        private void btnDatabaseYedekle_Click(object sender, EventArgs e)
        {
            DatabaseManager mng = new DatabaseManager();
            string sonuc = mng.BackUpDB(textBox1.Text);
            MessageBox.Show(sonuc);
        }

        private void btnDatabaseRestore_Click(object sender, EventArgs e)
        {
            DatabaseManager mng = new DatabaseManager();
            string sonuc = mng.RestoreDB(textBox1.Text);
            MessageBox.Show(sonuc);
        }

        private void btnDatabaseCreate_Click(object sender, EventArgs e)
        {
            DatabaseManager mng = new DatabaseManager();
            string sonuc = mng.CreateDB(textBox1.Text);
            MessageBox.Show(sonuc);
        }
    }
}
