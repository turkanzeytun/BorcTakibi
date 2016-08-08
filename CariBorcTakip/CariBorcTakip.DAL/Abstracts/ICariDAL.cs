using CariBorcTakip.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.DAL.Abstracts
{
    public interface ICariDAL
    {
        void Add(Cari instance);
        void Remove(int instanceID);
        void Update(Cari instance);
        Cari GetByID(int instanceID);
        List<Cari> GetAll();

        List<CariOdeme> GetDebtCari();
    }
}
