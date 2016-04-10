﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using ZakLyd.Caching;
using ZakLyd.Domaine.Entities;
using ZakLyd.Factory;
using ZakLyd.Helpers;
using ZakLyd.Services;

namespace ZakLyd.Controllers
{
    public class HomeController : BaseController
    {
        private ElasticService elasticService;

        public HomeController() : base()
        {
            elasticService = new ElasticService();
        }
        public ActionResult Index()
        {
            var promoList = elasticService.GetPromoList();
            return View(new ViewModelFactory().CreateHomeViewModel());
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

        public ActionResult Culture(string culture/*, string returnUrl*/)
        {
            if (CultureHelper.ValidateCulture(culture))
            {
                HttpCookie cultureCookie = new HttpCookie("_culture", culture);
                HttpContext.Response.SetCookie(cultureCookie);
            }
            return RedirectToAction("Index");
            //return Redirect(returnUrl);
        }

        public ActionResult FlushCache()
        {
            CacheManager cachMagr = new CacheManager();
            var flushResult = cachMagr.Flush();

            if (flushResult.Item1)
            { 
                ViewBag.result = "OK";
            }
            else
            {
                ViewBag.result = String.Format("Error: {0}",flushResult.Item2);
            }

            return View();
        
        }
    }
}