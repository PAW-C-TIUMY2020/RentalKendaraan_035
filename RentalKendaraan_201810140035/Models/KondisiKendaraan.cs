using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class KondisiKendaraan
    {
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int IdKondisi { get; set; }
        [Required(ErrorMessage = "Nama kondisi wajib di isi tidak boleh kosong")]
        public string NamaKondisi { get; set; }
        [Required(ErrorMessage = "Pengembalian wajib di isi tidak boleh kosong")]
        public Pengembalian Pengembalian { get; set; }
    }
}
