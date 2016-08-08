using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.Entites
{
    public class Cek
    {
        public int CekOdemeID { get; set; }
        public Nullable<int> OdemeID { get; set; }
        public Nullable<System.DateTime> SonOdemeTarihi { get; set; }
        public Nullable<bool> OdendiMi { get; set; }
        public bool IsDeleted { get; set; }
        public Odeme Odeme { get; set; }
    }
}
