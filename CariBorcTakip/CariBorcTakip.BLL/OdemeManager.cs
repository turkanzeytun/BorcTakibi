using CariBorcTakip.DAL.Abstracts;
using CariBorcTakip.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.BLL
{
    public class OdemeManager
    {
        public OdemeManager(IOdemeDAL odemeDAL)
        {
            _odemeDAL = odemeDAL;
        }
        IOdemeDAL _odemeDAL;

        public void Add(Odeme instance)
        {
            _odemeDAL.Add(instance);
        }

        public void Remove(int instanceID)
        {
            _odemeDAL.Remove(instanceID);
        }

        public void Update(Odeme instance)
        {
            _odemeDAL.Update(instance);
        }

        public Odeme GetByID(int instanceID)
        {
            return _odemeDAL.GetByID(instanceID);
        }

        public List<Odeme> GetAll()
        {
            return _odemeDAL.GetAll();
        }
        public List<Odeme> GetByIsID(int instanceID)
        {
            return _odemeDAL.GetByIsID(instanceID);
        }

        public List<Odeme> GetCashesByIsID(int instanceID)
        {
            return _odemeDAL.GetCashesByIsID(instanceID);
        }

        public List<Odeme> GetChecksByIsID(int instanceID)
        {
            return _odemeDAL.GetChecksByIsID(instanceID);
        }
    }
}
