using System;
using System.Collections.Generic;

namespace CariBorcTakip.Entites
{
    public partial class Cari
    {
        public Cari()
        {
            this.Isses = new List<Iss>();
        }

        public int CariID { get; set; }
        public string CariKOD { get; set; }
        public string CariAd { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Iss> Isses { get; set; }
    }
}
