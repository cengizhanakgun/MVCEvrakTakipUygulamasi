using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEvrakTakipUygulamasi.Models;

namespace MVCEvrakTakipUygulamasi.Controllers
{
    public class LoginController : Controller
    {
        MVCEvrakTakipDBEntities1 entities1 = new MVCEvrakTakipDBEntities1();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}