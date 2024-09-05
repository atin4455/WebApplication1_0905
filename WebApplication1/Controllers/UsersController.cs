using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Create(UserVm vm)
        {
            return View(vm);
        }        
        public ActionResult CheckAccount(string account)
        {
            bool result = account != "allen";
            return Json(result,JsonRequestBehavior.AllowGet);
        }    

        //name,account不可以相同
        public ActionResult CheckName(string account,string name)
        {
            bool result = account != name;
            return Json(result);
        }
    }
}
//