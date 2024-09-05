using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class C130Vm
    {
        [Display(Name ="未稅價")]
        [Required(ErrorMessage = "{0}必填")]
        [Range(1,int.MaxValue,ErrorMessage ="{0}必須大於{1}")]
        public int Price { get; set; }

        public int Tax => (int)Math.Round(Price*0.05,MidpointRounding.AwayFromZero);

        public int Total =>Price +Tax;
    }
}