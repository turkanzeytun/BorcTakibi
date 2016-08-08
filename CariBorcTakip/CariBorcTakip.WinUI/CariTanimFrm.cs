using CariBorcTakip.BLL;
using CariBorcTakip.DAL.Concrates.EF;
using CariBorcTakip.Entites;
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
    public partial class CariTanimFrm : Form
    {
        public CariTanimFrm()
        {
            InitializeComponent();
        }
        string islem = "Kaydet";

        private void Form3_Load(object sender, EventArgs e)
        {
            CariGridDoldur();
        }

        private void CariGridDoldur()
        {
            CariManager cariMng = new CariManager(new CariEFDAL());
            List<Cari> cariList = cariMng.GetAll();
            dataGridView1.DataSource = cariList;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].HeaderText = "KOD";
            dataGridView1.Columns[2].HeaderText = "CARİ ADI";
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "ADRES";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[4].Width = 220;
        }

        private void btnCariKaydet_Click(object sender, EventArgs e)
        {
            CariManager cariMng = new CariManager(new CariEFDAL());
            Cari cari = new Cari { CariID=Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), CariKOD = txtCariKod.Text, CariAd = txtCariAd.Text, Adres=txtAdres.Text, Telefon=txtCariTel.Text };
            if (islem=="Kaydet")
            {
                cariMng.Add(cari);
            }
            else if (islem=="Güncelle")
            {
                cariMng.Update(cari);
            }
           
            CariGridDoldur();
        }

        private void btnYeniCari_Click(object sender, EventArgs e)
        {
            islem = "Kaydet";
            btnCariKaydet.Text = "CARİ KAYDET";
            txtCariAd.Text = txtCariKod.Text = txtCariTel.Text = txtAdres.Text = txtCariTel.Text = "";
        }

        private void btnCariSil_Click(object sender, EventArgs e)
        {
            CariManager cariMng = new CariManager(new CariEFDAL());
            cariMng.Remove(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            CariGridDoldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            islem = "Güncelle";
            btnCariKaydet.Text = "CARİ GÜNCELLE";
            txtCariAd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtCariKod.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAdres.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtCariTel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
