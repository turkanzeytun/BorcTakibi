using CariBorcTakip.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.DAL.Abstracts
{
    public interface IOdemeDAL
    {
        void Add(Odeme instance);
        void Remove(int instanceID);
        void Update(Odeme instance);
        Odeme GetByID(int instanceID);
        List<Odeme> GetAll();
        List<Odeme> GetByIsID(int instanceID);

        List<Odeme> GetCashesByIsID(int instanceID);

        List<Odeme> GetChecksByIsID(int instanceID);
    }
}
