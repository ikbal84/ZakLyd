using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZakLyd.Domaine.Entities;
using ZakLyd.Infrastructure.Repository;

namespace ZakLyd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new ZakLydContext())
            {
                Agency agence = new Agency() { AgencyName = "test"};

                ctx.Agency.Add(agence);
                ctx.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}