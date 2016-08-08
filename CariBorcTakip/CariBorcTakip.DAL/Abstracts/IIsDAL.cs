using CariBorcTakip.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.DAL.Abstracts
{
    public interface IIsDAL
    {
        void Add(Iss instance);
        void Remove(int instanceID);
        void Update(Iss instance);
        Iss GetByID(int instanceID);
        List<Iss> GetAll();

        List<Iss> GetByCariID(int instanceID);
    }
}
