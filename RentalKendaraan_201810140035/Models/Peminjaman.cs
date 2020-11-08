using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Peminjaman
    {
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int IdPemimjaman { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public DateTime? TglPemimjaman { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int? IdKendaraan { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int? IdCustomer { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int? IdJaminan { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public int? Biaya { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public Kendaraan IdPemimjaman1 { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public Customer IdPemimjamanNavigation { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public Jaminan Jaminan { get; set; }
        [Required(ErrorMessage = "wajib di isi dengan angka")]
        public Pengembalian Pengembalian { get; set; }
    }
}
