using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Kendaraan
    {
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]]
        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama kendaraan wajib di isi tidak boleh kosong")]
        public string NamaKendaraan { get; set; }
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoPolisi { get; set; }
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoStnk { get; set; }
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "wajib di isi tidak boleh kosong")]
        public string Ketersediaan { get; set; }
        [Required(ErrorMessage = "wajib di isi tidak boleh kosong")]
        public JnsKendaraan JnsKendaraan { get; set; }
        [Required(ErrorMessage = "wajib di isi tidak boleh kosong")]
        public Peminjaman Peminjaman { get; set; }
    }
}
