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
        private static Player p = new Player();


        public ActionResult Index()
        {
            d.Generate();
            d.Randomize(d.Deck);
            Session["tabla"] = d.Deck;
            //Session["DealerScore"] = d.Score;
            //Session["PlayerScore"] = p.Score;
            ViewBag.cantidad = d.Deck.Count();
            return View();
        }

        [HttpPost]
        public ActionResult Init()
        {
            List<Card> deck = (List<Card>)Session["tabla"];
            Session["tabla"] = deck;
            ViewBag.cantidad = deck.Count();

            if(deck.Count() > 52)
            {
                d.Deck.Clear();
                d.Hand.Clear();
                p.Hand.Clear();

                d.Generate();
                d.Randomize(d.Deck);
                Session["tabla"] = d.Deck;
                d.Score = 0;
                p.Score = 0;
            }

            List<Card> dealerCards = d.Hand;
            List<Card> playerCards = p.Hand;

            int dealerScore = 0;
            int playerScore = 0;
            

            d.Init(deck);
            p.Init(giveCard(), giveCard());

            foreach (Card c in dealerCards)
            {
                if(c.Symbol == "A")
                {
                    dealerScore = dealerScore + 11;
                } 
                else
                {
                    dealerScore = dealerScore + c.Score;
                }
            }

            foreach (Card c in playerCards)
            {
                if (c.Symbol == "A")
                {
                    playerScore = playerScore + 11;
                }
                else
                {
                    playerScore = playerScore + c.Score;
                }
            }

            d.Score = dealerScore;
            p.Score = playerScore;


            //return JsonConvert.SerializeObject(card);
            return Json(new
            {
                cantidad = deck.Count(),
                cartasD = dealerCards,
                scoreD = dealerScore,
                cartasP = playerCards,
                scoreP = playerScore
            }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult EvaluateScore()
        {
            List<Card> deck = (List<Card>)Session["tabla"];

            Card card = giveCard();
            p.AddCard(card);

            int playerScore = 0;

            foreach (Card c in p.Hand)
            {
                if(c.Symbol == "A")
                {
                    if(p.Score + c.Score > 21)
                    {
                        playerScore = p.Score - 10;
                    }
                }
            }

            playerScore = p.Score + card.Score;

            p.Score = playerScore;

            return Json(new
            {
                cantidad = deck.Count(),
                carta = card,
                scoreP = playerScore
            }, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Stop()
        {
            List<Card> playerCards = p.Hand;
            List<Card> deck = (List<Card>)Session["tabla"];

            List<Card> deckTemporal = new List<Card>();

            Boolean dMenorQueP = true;

            if (d.Score >= p.Score)
            {
                dMenorQueP = false;
            } 
            else if(d.Score < p.Score)
            {
                while (dMenorQueP)
                {
                    Card card = giveCard();
                    d.AddCard(card);

                    if(card.Symbol == "A")
                    {
                        if (d.Score + card.Score <= 21)
                        {
                            d.Score = d.Score + 11;           
                        }
                    } 
                    else
                    {
                        d.Score = d.Score + card.Score;
                    }
                    
                    if (d.Score > p.Score || d.Score >= 21)
                    {
                        dMenorQueP = false;
                    }
                    
                }
            }
            
            return Json(new
            {
                cards = d.Hand,
                scoreD = d.Score,
                scoreP = p.Score
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Restart()
        {
            d.Deck.Clear();
            d.Hand.Clear();
            p.Hand.Clear();

            d.Generate();
            d.Randomize(d.Deck);
            Session["tabla"] = d.Deck;
            d.Score = 0;
            p.Score = 0;
            //Session["DealerScore"] = d.Score;
            //Session["PlayerScore"] = p.Score;
            ViewBag.cantidad = d.Deck.Count();

            return Json(new
            {
                result = "Succes"
            }, JsonRequestBehavior.AllowGet);
        }

        //Llama al metodo Deal de Dealer() y retorna la carta
        public Card giveCard()
        {
            Card tempCard = d.Deal(d.Deck);

            return tempCard;
        }


        
    }
}