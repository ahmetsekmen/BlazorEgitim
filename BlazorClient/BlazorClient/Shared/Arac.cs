using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClient.Shared
{
    public class Arac
    {
        public Guid Id { get; set; }
        [Required (ErrorMessage = "Marka bilgisi girmek zorundasınız.")]
        public String Marka { get; set; }

        [StringLength(50,ErrorMessage ="50 DEN UZUN OLAMAZ")]
        public string Yorum { get; set; }
    }
}
