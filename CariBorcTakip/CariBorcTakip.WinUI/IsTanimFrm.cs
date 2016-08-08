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
    public partial class IsTanimFrm : Form
    {
        public IsTanimFrm()
        {
            InitializeComponent();
        }
        string islem = "Kaydet";
        public int SecilenCariID;
        private void btnCariKaydet_Click(object sender, EventArgs e)
        {
            IsManager isMng = new IsManager(new IsEFDAL());
            Iss iss = new Iss { CariID = SecilenCariID, AlinacakTutar = Convert.ToDouble(txtAlinacakTutar.Text), Tarih = Convert.ToDateTime(dateTimePicker1.Text), YapilanIsTanimi = txtIsTanim.Text };
            if (islem == "Güncelle")
            {
                iss.IsID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                isMng.Update(iss);
            }
            else if (islem == "Kaydet")
            {
                isMng.Add(iss);
            }                    
            IsGridLoad();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            IsGridLoad();
        }

        private void IsGridLoad()
        {
            IsManager isMng = new IsManager(new IsEFDAL());
            List<Iss> isList = isMng.GetByCariID(SecilenCariID);
            dataGridView1.DataSource = isList;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[1].HeaderText = "TARİH";
            dataGridView1.Columns[3].HeaderText = "İŞ TANIMI";
            dataGridView1.Columns[4].HeaderText = "TUTAR";
            dataGridView1.Columns[3].Width = 400;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            islem = "Güncelle";
            btnCariKaydet.Text = "İŞ GÜNCELLE";
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            IsManager isMng = new IsManager(new IsEFDAL());
            Iss iss = isMng.GetByID(id);
            txtIsTanim.Text = iss.YapilanIsTanimi;
            txtAlinacakTutar.Text = iss.AlinacakTutar.ToString();
            dateTimePicker1.Value = iss.Tarih.Value;
        }

        private void btnYeniCari_Click(object sender, EventArgs e)
        {
            islem = "Kaydet";
            btnCariKaydet.Text = "İŞ KAYDET";
            txtAlinacakTutar.Text = txtIsTanim.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCariSil_Click(object sender, EventArgs e)
        {
            IsManager isMng = new IsManager(new IsEFDAL());
            isMng.Remove(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            IsGridLoad();
        }
    }
}
