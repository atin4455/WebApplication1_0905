using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models.ViewModels
{
    public class StudentVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [AllowHtml]
        public string Email { get; set; }
    }
}