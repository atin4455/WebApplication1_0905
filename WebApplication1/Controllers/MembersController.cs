using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MemberVm vm,HttpPostedFileBase file1)
        {
            if (file1 == null || file1.ContentLength == 0)
            {
                ModelState.AddModelError("FileName","請選擇大頭照");
            }

            if (ModelState.IsValid)
            {

                //todo create record

                //redirect to index page
            }
            return View();
        }
    }
}