using System;
using System.Collections.Generic;

namespace RentalKendaraan_201810140035.Models
{
    public partial class JnsKendaraan
    {
        public int JenisKendaraan { get; set; }
        public string NamaJenisKendaraan { get; set; }

        public Kendaraan JenisKendaraanNavigation { get; set; }
    }
}
