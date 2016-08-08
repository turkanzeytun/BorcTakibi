using System;
using System.Collections.Generic;

namespace CariBorcTakip.Entites
{
    public partial class Odeme
    {
        public Odeme()
        {
            this.Ceks = new List<Cek>();
        }
        public int OdemeID { get; set; }
        public Nullable<int> IsID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<double> OdenenTutar { get; set; }
        public string OdemeTuru { get; set; }
        public string Aciklama { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Cek> Ceks { get; set; }
        public Iss Iss { get; set; }
    }
}
