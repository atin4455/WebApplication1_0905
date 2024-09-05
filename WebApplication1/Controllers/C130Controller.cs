using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class C130Controller : Controller
    {
        // GET: C130
        public ActionResult CalcTax()
        {
            return View(new C130Vm());
        }

        [HttpPost]
        public ActionResult CalcTax(C130Vm vm)
        {
            return View(vm);
        }

    }
}