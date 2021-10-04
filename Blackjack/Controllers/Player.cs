using Blackjack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blackjack.Controllers
{
    public class Player
    {
        private List<Card> hand= new List<Card>();
        public Player()
        {
        }

        public void Init(Card card1, Card card2)
        {
            AddCard(card1);
            AddCard(card2);
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
        }

        public List<Card> Hand { get => hand; set => hand = value; }
    }
}