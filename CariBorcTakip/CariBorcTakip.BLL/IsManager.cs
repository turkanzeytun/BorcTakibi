using CariBorcTakip.DAL.Abstracts;
using CariBorcTakip.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.BLL
{
    public class IsManager
    {
        public IsManager(IIsDAL isDAL)
        {
            _isDAL = isDAL;
        }
        IIsDAL _isDAL;

        public void Add(Iss instance)
        {
            _isDAL.Add(instance);
        }

        public void Remove(int instanceID)
        {
            _isDAL.Remove(instanceID);
        }

        public void Update(Iss instance)
        {
            _isDAL.Update(instance);
        }

        public Iss GetByID(int instanceID)
        {
            return _isDAL.GetByID(instanceID);
        }

        public List<Iss> GetAll()
        {
            return _isDAL.GetAll();
        }
        public List<Iss> GetByCariID(int instanceID)
        {
            return _isDAL.GetByCariID(instanceID);
        }
        
    }
}
