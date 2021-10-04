using Blackjack.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blackjack.Controllers
{
    public class HomeController : Controller
    {
        private static Dealer d = new Dealer();


        public ActionResult Index()
        {
            d.Generate();
            d.Randomize(d.Deck);
            Session["tabla"] = d.Deck;
            ViewBag.cantidad = d.Deck.Count();
            return View();
        }

        [HttpPost]
        public ActionResult Init()
        {
            List<Card> deck = (List<Card>)Session["tabla"];
            Card card = d.Deal(deck);
            Session["tabla"] = deck;
            ViewBag.cantidad = deck.Count();
            //return JsonConvert.SerializeObject(card);
            return Json(new
            {
                cantidad = deck.Count,
                carta = card
            }, JsonRequestBehavior.AllowGet);
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