using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Pengembalian
    {
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int IdPengembalian { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public DateTime? TglPengembalian { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int? IdPemimjaman { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int? IdKondisi { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int? Denda { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public Peminjaman IdPengembalian1 { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public KondisiKendaraan IdPengembalianNavigation { get; set; }
    }
}
