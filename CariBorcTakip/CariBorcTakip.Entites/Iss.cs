using System;
using System.Collections.Generic;

namespace CariBorcTakip.Entites
{
    public partial class Iss
    {
        public Iss()
        {
            this.Odemes = new List<Odeme>();
        }

        public int IsID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> CariID { get; set; }
        public string YapilanIsTanimi { get; set; }
        public Nullable<double> AlinacakTutar { get; set; }
        public bool IsDeleted { get; set; }
        public Cari Cari { get; set; }
        public ICollection<Odeme> Odemes { get; set; }
    }
}
