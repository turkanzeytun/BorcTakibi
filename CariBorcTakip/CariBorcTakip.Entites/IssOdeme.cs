using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.Entites
{
    public class IssOdeme
    {
        public int IsID { get; set; }
        public int CariID { get; set; }
        public DateTime Tarih { get; set; }
        public string YapilanIsTanimi { get; set; }
        public double AlinacakTutar { get; set; }
        public double OdenenTutar { get; set; }
        public double KalanTutar { get; set; }
        public double BozdurulmamisCekTutar { get; set; }

    }
}
