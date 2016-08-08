using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.Entites
{
    public class CariOdeme
    {
        public int CariID { get; set; }
        public string CariKOD { get; set; }
        public string CariAd { get; set; }
        public double ToplamBorc { get; set; }
        public double OdenmisBorc { get; set; }
        public double KalanBorc { get; set; }
        public double BozdurulmamisCekTutar { get; set; }
    }
}
