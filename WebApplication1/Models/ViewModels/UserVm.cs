using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace WebApplication1.Models.ViewModels
{
    public class UserVm:IValidatableObject
    {

        [Display(Name = "姓名")]
        [Required(ErrorMessage = "請輸入{0}")]
        [Remote("CheckName", "Users", ErrorMessage = "姓名,帳號不可以相同", AdditionalFields ="Account" ,HttpMethod ="POST")]
        public string Name { get; set; }

        [Display(Name = "帳號")]
        [Required(ErrorMessage = "請輸入{0}")]
        [Remote("CheckAccount","Users", ErrorMessage = "{0}已存在")]
        public string Account { get; set; }

        [Display(Name = "密碼")]
        [Required(ErrorMessage = "請輸入{0}")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "確認密碼")]
        [Required(ErrorMessage = "請輸入{0}")]
        [Compare(nameof(Password), ErrorMessage= "{0}必須與密碼相同")]
        [DataType(DataType.Password)]
        public string Confirmedpassword { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(this.Name.Length+this.Password.Length%2 != 0)
            {
                yield return new ValidationResult("Name + Password 長度必須為偶數");
            }           
            if(this.Account.Length+this.Password.Length%2 != 0)
            {
                yield return new ValidationResult("Account + Password 長度必須為偶數");
            }
        }
    }
}