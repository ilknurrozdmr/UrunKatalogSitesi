using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UrunKatalog.MvcWebUı.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }
        
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}