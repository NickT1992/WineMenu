using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WineMenu.DataAccessLayer;
using WineMenu.Models;

namespace WineMenu.Controllers
{
    public class HomeController : Controller
    {

        private PubContext db = new PubContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var pubs = db.JHPubs;
            return View(pubs.ToList());
        }

        public ActionResult GetPubs()
        {
            Pub p = new Pub();
            List<Pub> li = new List<Pub>();

            li = p.GetPubs();
            ViewData["Pub"] = li;
            return View(li);
        }

    }
}
