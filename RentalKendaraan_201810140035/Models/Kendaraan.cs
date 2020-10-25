using System;
using System.Collections.Generic;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public string NoPolisi { get; set; }
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        public string Ketersediaan { get; set; }

        public JnsKendaraan JnsKendaraan { get; set; }
        public Peminjaman Peminjaman { get; set; }
    }
}
