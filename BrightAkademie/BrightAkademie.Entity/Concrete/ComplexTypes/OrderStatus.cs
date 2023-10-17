using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Entity.Concrete.ComplexTypes
{
    public enum OrderStatus
    {
        [Display(Name = "Siparişiniz alındı.")]
        Received = 0,
        [Display(Name = "Hazırlanıyor.")]
        Preparing = 1,
        [Display(Name = "Gönderildi.")]
        Sent = 2,
        [Display(Name = "Teslim edildi.")]
        Delivered = 3
    }
}
