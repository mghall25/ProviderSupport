using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProviderSupport.DAL;
using ProviderSupport.ViewModels;

namespace ProviderSupport.Controllers
{
    public class HomeController : Controller
    {
        private ProviderSupportContext db = new ProviderSupportContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<BirthDateGroup> data = from provider in db.Providers
                                                   group provider by provider.BirthDate into dateGroup
                                                   select new BirthDateGroup()
                                                   {
                                                       BirthDate = dateGroup.Key,
                                                       ProviderCount = dateGroup.Count()
                                                   };
            return View(data.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }        

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}