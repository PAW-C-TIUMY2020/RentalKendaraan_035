using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class JnsKendaraan
    {
        [Required(ErrorMessage = "jenis kendaraan tidak boleh kosong")]
        public int JenisKendaraan { get; set; }
        [Required(ErrorMessage = "Nama jenis kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public Kendaraan JenisKendaraanNavigation { get; set; }
    }
}
