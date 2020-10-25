﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        public string NamaCustomer { get; set; }
        public string Nik { get; set; }
        public string Alamat { get; set; }
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdCustomerNavigation { get; set; }
        public Peminjaman Peminjaman { get; set; }
    }
}
