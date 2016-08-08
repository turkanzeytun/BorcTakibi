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
    public partial class OdemeTanimFrm : Form
    {
        public OdemeTanimFrm()
        {
            InitializeComponent();
        }

        string islem = "Kaydet";
        byte gridNo = 0;
        public int SecilenIsID;
        private void Form2_Load(object sender, EventArgs e)
        {
            ValueLoad();
        }

        private void ValueLoad()
        {
            OdemeManager mng = new OdemeManager(new OdemelerEFDAL());
            List<Odeme> odemeList1 = new List<Odeme>();
            List<Odeme> odemeList2 = new List<Odeme>();
            odemeList1 = mng.GetCashesByIsID(SecilenIsID);
            odemeList2 = mng.GetChecksByIsID(SecilenIsID);
            dataGridView1.DataSource = odemeList1;
            dataGridView2.DataSource = odemeList2;
            //MessageBox.Show(odemeList2.First().Ceks.First().OdendiMi.ToString());
            comboBox1.SelectedItem = "NAKİT";
        }

        private void btnOdemeKaydet_Click(object sender, EventArgs e)
        {
            OdemeManager odemeMng = new OdemeManager(new OdemelerEFDAL());
            Odeme odeme = new Odeme();
            odeme.IsID = SecilenIsID;
            odeme.OdenenTutar = Convert.ToDouble(txtOdenenTutar.Text);
            odeme.Tarih = Convert.ToDateTime(dateTimePicker1.Text);
            odeme.Aciklama = txtAciklama.Text;
            odeme.OdemeTuru = comboBox1.SelectedItem.ToString();

            if (islem == "Güncelle")
            {  
                if (gridNo==1)
                {
                    odeme.OdemeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                }
                else if (gridNo == 2)
                {
                    odeme.OdemeID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);//kayıtlı ödeme çekmi?
                }

                if (odeme.OdemeTuru == "ÇEK")//kullanıcı çeki mi seçti?
                {
                    Cek cek = odemeMng.GetByID(odeme.OdemeID).Ceks.LastOrDefault();
                    if (cek != null)
                    {
                        //varolan çeki güncelle
                        cek.OdendiMi = chbOdendiMi.Checked;
                        cek.SonOdemeTarihi = Convert.ToDateTime(dateTimePicker2.Text);
                        List<Cek> cekList = new List<Cek>();
                        cekList.Add(cek);
                        odeme.Ceks = cekList;
                    }
                    else
                    {
                        //ödeme nakit olarak kaydedilmiş çeke dönüştürülüyor
                        //önce varolan nakit ödeme tablosunda türü update edicez ve cek olarak da yeni kayıt eklicez
                        Cek yeniCek = new Cek();
                        yeniCek.OdendiMi = chbOdendiMi.Checked;
                        yeniCek.SonOdemeTarihi = Convert.ToDateTime(dateTimePicker2.Text);
                        odeme.Ceks.Add(yeniCek);
                    }
                }

                odemeMng.Update(odeme);
            }
            else if (islem == "Kaydet")
            {
                if (odeme.OdemeTuru == "ÇEK")
                {
                    Cek cek = new Cek();
                    cek.OdendiMi = chbOdendiMi.Checked;
                    cek.SonOdemeTarihi = Convert.ToDateTime(dateTimePicker2.Text);
                    odeme.Ceks.Add(cek);
                }
                odemeMng.Add(odeme);
            }
            ValueLoad();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                chbOdendiMi.Visible = dateTimePicker2.Visible=label5.Visible=label6.Visible = false;
            }
            else if (comboBox1.SelectedIndex==1)
            {
                chbOdendiMi.Visible = dateTimePicker2.Visible = label5.Visible = label6.Visible = true;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            islem = "Güncelle";
            gridNo = 1;
            OdemeManager mng = new OdemeManager(new OdemelerEFDAL());
            int odemeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Odeme odeme = mng.GetByID(odemeID);
            txtAciklama.Text = odeme.Aciklama;
            txtOdenenTutar.Text = odeme.OdenenTutar.ToString();
            dateTimePicker1.Value = odeme.Tarih.Value;
            comboBox1.SelectedIndex = 0;
            dateTimePicker2.Value = DateTime.Now;
            chbOdendiMi.Checked = false;
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            islem = "Güncelle";
            gridNo = 2;
            OdemeManager mng = new OdemeManager(new OdemelerEFDAL());
            int odemeID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            Odeme odeme = mng.GetByID(odemeID);
            txtAciklama.Text = odeme.Aciklama;
            txtOdenenTutar.Text = odeme.OdenenTutar.ToString();
            dateTimePicker1.Value = odeme.Tarih.Value;
            comboBox1.SelectedIndex = 1;
            dateTimePicker2.Value = odeme.Ceks.First().SonOdemeTarihi.Value;
            chbOdendiMi.Checked = odeme.Ceks.First().OdendiMi.Value;
        }

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            islem = "Kaydet";
            gridNo = 0;
            txtAciklama.Text = txtOdenenTutar.Text = "";
            chbOdendiMi.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            OdemeManager odemeMng = new OdemeManager(new OdemelerEFDAL());
            int odemeID = 0;
            if (comboBox1.SelectedItem.ToString()=="ÇEK")
            {
                odemeID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            }
            else if (comboBox1.SelectedItem.ToString()=="NAKİT")
            {
                odemeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            }
            
            odemeMng.Remove(odemeID);
            ValueLoad();
        }
    }
}
