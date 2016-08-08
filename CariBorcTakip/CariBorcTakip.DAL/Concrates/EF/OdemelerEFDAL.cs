using CariBorcTakip.DAL.Abstracts;
using CariBorcTakip.DAL.Concrates.EF.Contexts;
using CariBorcTakip.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.DAL.Concrates.EF
{
    public class OdemelerEFDAL : IOdemeDAL
    {
        public void Add(Odeme instance)
        {
            using (var context = new BorcTakipDBContext())
            {
                instance.IsDeleted = false;
                context.Odemes.Add(instance);
                context.SaveChanges();
            }
        }

        public void Remove(int instanceID)
        {
            using (var context = new BorcTakipDBContext())
            {
                Odeme odeme = context.Odemes.Include("Ceks").Where(c => c.OdemeID == instanceID).FirstOrDefault();
                odeme.IsDeleted = true;
                if (odeme.OdemeTuru=="ÇEK")
                {
                    foreach (Cek cek in odeme.Ceks)
                    {
                        cek.IsDeleted = true;
                    }
                }
                //context.Odemes.Remove(odeme);
                context.SaveChanges();
            }
        }

        public void Update(Odeme instance)
        {
            using (var context = new BorcTakipDBContext())
            {
                Odeme odeme = context.Odemes.Find(instance.OdemeID);
                odeme.IsID = instance.IsID;
                odeme.OdenenTutar = instance.OdenenTutar;
                odeme.Tarih = instance.Tarih;
                odeme.OdemeTuru = instance.OdemeTuru;
                odeme.Aciklama = instance.Aciklama;
                odeme.IsDeleted = false;
                if (instance.OdemeTuru == "ÇEK")
                {
                    Cek yeniCek = instance.Ceks.Last();
                    Cek cek = context.Ceks.Find(yeniCek.CekOdemeID);
                    if (cek != null)//varolan çek değiştiriliyorsa
                    {
                        cek.OdendiMi = yeniCek.OdendiMi;
                        cek.SonOdemeTarihi = yeniCek.SonOdemeTarihi;
                        cek.IsDeleted = false;
                    }
                    else//daha önce nakit olan kayıt çeke döndürülüyorsa
                    {
                        yeniCek.IsDeleted = false;
                        odeme.Ceks.Add(yeniCek);
                    }
                }
                else if (instance.OdemeTuru == "NAKİT")
                {
                    Cek cek = context.Ceks.Where(s => s.OdemeID == instance.OdemeID && s.IsDeleted==false).First();
                    
                    //EĞER ÖNCEDEN ÇEKSE VE BU NAKİTE DÖNECEKSE ÇEK İÇİNDE SİLME İŞLEMİ YAPMAK GEREKİYOR
                    if (cek != null)
                    {
                        
                        cek.IsDeleted = true;
                    } 
                }
                context.SaveChanges();
            }
        }

        public Odeme GetByID(int instanceID)
        {
            Odeme odeme;
            using (var context = new BorcTakipDBContext())
            {
                //odeme = context.Odemes.Find(instanceID);
                odeme = context.Odemes.Include("Ceks").Where(s => s.OdemeID == instanceID && s.IsDeleted == false).First();
            }
            return odeme;
        }

        public List<Odeme> GetAll()
        {
            List<Odeme> odemeList;
            using (var context = new BorcTakipDBContext())
            {
                odemeList = context.Odemes.Where(s => s.IsDeleted == false).ToList();
            }
            return odemeList;
        }



        public List<Odeme> GetByIsID(int instanceID)
        {
            List<Odeme> odemeList;
            using (var context = new BorcTakipDBContext())
            {
                odemeList = context.Odemes.Where(r => r.IsID == instanceID && r.IsDeleted == false).ToList();
            }
            return odemeList;
        }

        public List<Odeme> GetCashesByIsID(int instanceID)
        {
            List<Odeme> odemeList;
            using (var context = new BorcTakipDBContext())
            {
                odemeList = context.Odemes.Where(r => r.IsID == instanceID && r.OdemeTuru == "NAKİT" && r.IsDeleted == false).ToList();
            }
            return odemeList;
        }

        public List<Odeme> GetChecksByIsID(int instanceID)
        {
            List<Odeme> odemeList;
            using (var context = new BorcTakipDBContext())
            {
                odemeList = context.Odemes.Include("Ceks").Where(r => r.IsID == instanceID && r.OdemeTuru == "ÇEK" && r.IsDeleted == false).ToList();
            }
            return odemeList;
        }
    }
}
