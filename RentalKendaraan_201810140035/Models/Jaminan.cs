using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Jaminan
    {
        [Required(ErrorMessage = "jaminan tidak boleh kosong")]
        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }

        public Peminjaman IdJaminanNavigation { get; set; }
    }
}
