using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UrunKatalog.MvcWebUı.Entity
{
    public enum EnumOrderState
    {
        [Display(Name="Onay Bekliyor")]
        Waiting,
        [Display(Name ="Tamamlandı")]
        Completed
    }
}