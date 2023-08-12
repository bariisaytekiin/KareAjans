using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KareAjans.Entity.Enums
{
    public enum Beden
    {
        [Display(Name = "Xxs")]
        Xxs ,
        [Display(Name = "Xs")]
        Xs,
        [Display(Name = "S")]
        S,
        [Display(Name = "M")]
        M,
        [Display(Name = "L")]
        L,
        [Display(Name = "Xl")]
        Xl,
        [Display(Name = "Xxl")]
        Xxl,

    }
}
