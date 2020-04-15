using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NarrowWebExchangeProj.Models
{
    public class Make
    {
        public int MakeId { get; set;}
        [Display(Name = "Make")]
        public string MakeName { get; set; }


    }
}
