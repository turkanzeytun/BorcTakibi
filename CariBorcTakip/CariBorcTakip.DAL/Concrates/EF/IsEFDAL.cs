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
    public class IsEFDAL : IIsDAL
    {
        public void Add(Iss instance)
        {
            using (var context = new BorcTakipDBContext())
            {
                instance.IsDeleted = false;
                context.Isses.Add(instance);
                context.SaveChanges();
            }
        }

        public void Remove(int instanceID)
        {
            using (var context = new BorcTakipDBContext())
            {
                Iss Is = context.Isses.Include("Odemes").Include("Odemes.Ceks").Where(c => c.IsID == instanceID).FirstOrDefault();
                Is.IsDeleted = true;
                foreach (Odeme odeme in Is.Odemes)
                {
                    odeme.IsDeleted = true;
                    if (odeme.OdemeTuru=="ÇEK")
                    {
                        foreach (Cek cek in odeme.Ceks)
                        {
                            cek.IsDeleted = true;
                        }
                    }
                }
                //context.Isses.Remove(Is);
                context.SaveChanges();
            }
        }

        public void Update(Iss instance)
        {
            using (var context = new BorcTakipDBContext())
            {
                Iss yapilanIs = context.Isses.Find(instance.IsID);
                yapilanIs.AlinacakTutar = instance.AlinacakTutar;
                yapilanIs.CariID = instance.CariID;
                yapilanIs.Tarih = instance.Tarih;
                yapilanIs.YapilanIsTanimi = instance.YapilanIsTanimi;
                context.SaveChanges();
            }
        }

        public Iss GetByID(int instanceID)
        {
            Iss yapilanIs;
            using (var context = new BorcTakipDBContext())
            {
                yapilanIs = context.Isses.Find(instanceID);
            }
            return yapilanIs;
        }

        public List<Iss> GetAll()
        {
            List<Iss> yapilanIsList;

            using (var context = new BorcTakipDBContext())
            {
                yapilanIsList = context.Isses.Where(s => s.IsDeleted == false).ToList();
            }
            return yapilanIsList;
        }

        public List<Iss> GetByCariID(int instanceID)
        {
            List<Iss> yapilanIsList;
            using (var context = new BorcTakipDBContext())
            {
                yapilanIsList = context.Isses.Include("Odemes").Include("Odemes.Ceks").Where(c => c.CariID == instanceID && c.IsDeleted == false).ToList();               
            }
            return yapilanIsList;
        }
    }
}
