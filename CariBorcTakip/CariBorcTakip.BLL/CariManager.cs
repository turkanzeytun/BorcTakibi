using CariBorcTakip.DAL.Abstracts;
using CariBorcTakip.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.BLL
{
    public class CariManager
    {
        public CariManager(ICariDAL cariDAL)
        {
            _cariDAL = cariDAL;
        }
        ICariDAL _cariDAL;

        public void Add(Cari instance)
        {
            _cariDAL.Add(instance);
        }

        public void Remove(int instanceID)
        {
            _cariDAL.Remove(instanceID);
        }

        public void Update(Cari instance)
        {
            _cariDAL.Update(instance);
        }

        public Cari GetByID(int instanceID)
        {
            return _cariDAL.GetByID(instanceID);
        }

        public List<Cari> GetAll()
        {
            return _cariDAL.GetAll();
        }

        public List<CariOdeme> GetDebtCari()
        {
            return _cariDAL.GetDebtCari();
        }
    }
}
