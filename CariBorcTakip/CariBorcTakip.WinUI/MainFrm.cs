using CariBorcTakip.BLL;
using CariBorcTakip.DAL.Abstracts;
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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnCariOdemeler_Click(object sender, EventArgs e)
        {

        }

        private void btnYeniCari_Click(object sender, EventArgs e)
        {
            CariTanimFrm frm = new CariTanimFrm();
            frm.ShowDialog();
            ValueLoad();
            OdemelerGridLoad();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValueLoad();
        }

        private void ValueLoad()
        {
            CariManager mng = new CariManager(new CariEFDAL());
            List<CariOdeme> cariList = mng.GetDebtCari();
            dataGridView1.DataSource = cariList;
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OdemeTanimFrm frmOdemeYap = new OdemeTanimFrm();
            frmOdemeYap.SecilenIsID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            frmOdemeYap.ShowDialog();
            ValueLoad();
            OdemelerGridLoad();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OdemelerGridLoad();            
        }

        private void OdemelerGridLoad()
        {
            //SEÇİLEN CARİYE YAPILAN İŞLER DATAGRİD2 DE LİSTELENECEK
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            IsManager mng = new IsManager(new IsEFDAL());
            List<Iss> issList = mng.GetByCariID(id);
            List<IssOdeme> issOdemeLsit = new List<IssOdeme>();

            foreach (Iss iss in issList)
            {
                List<Odeme> odemeList = iss.Odemes.Where(s=>s.IsDeleted == false).ToList();
                double isdeToplamOdenenTutar = 0;
                double isdeToplamBozulmamisCekTutar = 0;

                foreach (Odeme odeme in odemeList)
                {
                    List<Cek> cekList = odeme.Ceks.Where(s => s.IsDeleted == false).ToList();
                    isdeToplamOdenenTutar += odeme.OdenenTutar.Value;
                    if (cekList.Count != 0)
                    {
                        if (cekList.First().OdendiMi == false)
                        {
                            isdeToplamBozulmamisCekTutar += odeme.OdenenTutar.Value;
                        }
                    }
                }

                IssOdeme isOdeme = new IssOdeme();
                isOdeme.IsID = iss.IsID;
                isOdeme.CariID = iss.CariID.Value;                
                isOdeme.Tarih = iss.Tarih.Value;
                isOdeme.YapilanIsTanimi = iss.YapilanIsTanimi;
                isOdeme.AlinacakTutar = iss.AlinacakTutar.Value;
                isOdeme.OdenenTutar = isdeToplamOdenenTutar;
                isOdeme.KalanTutar = iss.AlinacakTutar.Value - isdeToplamOdenenTutar;
                isOdeme.BozdurulmamisCekTutar = isdeToplamBozulmamisCekTutar;
                issOdemeLsit.Add(isOdeme);
            }
            dataGridView2.DataSource = issOdemeLsit;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
        }



        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporFrm frm = new RaporFrm();

            frm.Show();
            
        }

        private void btnYedekAl_Click(object sender, EventArgs e)
        {

        }
    }
}
