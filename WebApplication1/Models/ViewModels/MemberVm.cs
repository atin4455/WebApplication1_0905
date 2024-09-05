using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class MemberVm
    {
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "{0}必填")]
        public string Name {get; set; }

        [Display(Name = "大頭照")]
        //[Required(ErrorMessage = "{0}必填")]
        public string FileName { get; set; }

    }
}