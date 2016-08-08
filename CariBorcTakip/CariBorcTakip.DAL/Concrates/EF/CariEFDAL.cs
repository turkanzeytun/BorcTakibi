using CariBorcTakip.DAL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CariBorcTakip.Entites;
using CariBorcTakip.DAL.Concrates.EF.Contexts;

namespace CariBorcTakip.DAL.Concrates.EF
{
    public class CariEFDAL:ICariDAL
    {      
        public void Add(Cari instance)
        {
            using (var context = new BorcTakipDBContext())
            {
                instance.IsDeleted = false;
                context.Caris.Add(instance);
                context.SaveChanges();
            }
        }

        public void Remove(int instanceID)
        {
            using (var context = new BorcTakipDBContext())
            {
                Cari cari = context.Caris.Find(instanceID);
                cari.IsDeleted = true;
                //context.Caris.Remove(cari);
                context.SaveChanges();
            }
        }

        public void Update(Cari instance)
        {
            using (var context = new BorcTakipDBContext())
            {
                Cari cari = context.Caris.Find(instance.CariID);
                cari.CariAd = instance.CariAd;
                cari.CariKOD = instance.CariKOD;
                context.SaveChanges();
            }
        }

        public Cari GetByID(int instanceID)
        {
            Cari cari;
            using (var context = new BorcTakipDBContext())
            {
                cari = context.Caris.Find(instanceID);            
            }
            return cari;
        }

        public List<Cari> GetAll()
        {
            List<Cari> cariList;

            using (var context = new BorcTakipDBContext())
            {
                cariList = context.Caris.Include("Isses").Where(s => s.IsDeleted == false).OrderBy(s => s.CariAd).ToList();
                //cariList = context.Caris.ToList();
            }
            return cariList;
        }


        public List<CariOdeme> GetDebtCari()
        {
            List<CariOdeme> cariAlacakList= new List<CariOdeme>();

            using (var context = new BorcTakipDBContext())
            {
                List<Cari> cariList;
                cariList = context.Caris.Include("Isses").Where(s => s.IsDeleted == false).OrderBy(s => s.CariAd).ToList();
                foreach (Cari item in cariList)
                {
                    List<Odeme> odemeList = new List<Odeme>();
                    odemeList = context.Odemes.Include("Ceks").Where(r => r.Iss.CariID == item.CariID && r.IsDeleted == false && r.Iss.IsDeleted==false).ToList();

                    CariOdeme cariOdeme = new CariOdeme();
                    cariOdeme.CariAd = item.CariAd;
                    cariOdeme.CariID = item.CariID;
                    cariOdeme.CariKOD = item.CariKOD;

                    double odenenToplamTutar=0;
                    double toplamBozulmamisCekTutar = 0;
                    foreach (Odeme odeme in odemeList)
                    {      
                        List<Cek> cekList = odeme.Ceks.Where(s=>s.IsDeleted==false).ToList();
                        odenenToplamTutar += odeme.OdenenTutar.Value;
                        if (cekList.Count != 0)
                        {
                            if (cekList.First().OdendiMi == false)
                            {
                                toplamBozulmamisCekTutar += odeme.OdenenTutar.Value;
                            }
                        }
                    }

                    double alınacakToplamTutar = 0;
                    foreach (Iss iss in item.Isses.Where(s => s.IsDeleted == false))
                    {
                        alınacakToplamTutar += iss.AlinacakTutar.Value;
                    }

                    cariOdeme.ToplamBorc = alınacakToplamTutar;
                    cariOdeme.OdenmisBorc = odenenToplamTutar;
                    cariOdeme.KalanBorc = alınacakToplamTutar - odenenToplamTutar;
                    cariOdeme.BozdurulmamisCekTutar = toplamBozulmamisCekTutar;
                    cariAlacakList.Add(cariOdeme);
                }
            }
            return cariAlacakList;
        }      
    }
}
