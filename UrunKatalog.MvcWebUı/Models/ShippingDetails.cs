using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UrunKatalog.MvcWebUı.Models
{
    public class ShippingDetails
    {
        public string Username { get; set; }

        [Required(ErrorMessage ="Lüfen adres tanımı giriniz.")]
        public string AdresBasligi { get; set; }

        [Required(ErrorMessage = "Lüfen bir adres giriniz.")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Lüfen şehir giriniz.")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Lüfen semt giriniz.")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Lüfen mahalle giriniz.")]
        public string Mahalle { get; set; }

        public string PostaKodu { get; set; }

    }
}