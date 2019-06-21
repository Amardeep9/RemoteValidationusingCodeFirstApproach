using RemoteValidateExCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidateExCode.Controllers
{
    public class RemotrValidateExController : Controller
    {
        // GET: RemotrValidateEx
        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(tblUser obj)
        {
            using (var db = new Model1())
            {
                if(ModelState.IsValid)
                {
                    db.tblUsers.Add(obj);
                    
                    return RedirectToAction("OK");
                }
                return View();
            }
        }

        public ActionResult OK()
        {
            return Content("OK");
        }

        public JsonResult CheckUserName(string UserName)
        {
            using (var db = new Model1())
            { 
                return Json(!db.tblUsers.Any(x=>x.UserName.ToLower()==UserName.ToLower()), JsonRequestBehavior.AllowGet);
            }
        }
    }
}