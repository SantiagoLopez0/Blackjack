using Blackjack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blackjack.Controllers
{
    public class Dealer
    {
        private List<Card> deck = new List<Card>();

        private List<Card> hand = new List<Card>();

        private int score = new int();

        public Dealer()
        {
        }

        public void Init(List<Card> deck)
        {
            for (int i = 0; i <= 1; i++)
            {
                Card card = this.Deal(deck);
                AddCard(card);
            }
            
        }

        public void Generate()
        {
            string[] suit = new string[] { "corazones", "diamantes", "picas", "trebol" };
            string[] symbol = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (string s in suit)
            {
                foreach (string sym in symbol)
                {
                    Card card = new Card(s, sym);
                    this.deck.Add(card);
                }
            }
        }

        public void Randomize(List<Card> deckParam)
        {
            List<Card> deck = deckParam;
            List<Card> newDeck = new List<Card>();

            Random randNum = new Random();
            while (deck.Count > 0)
            {
                int val = randNum.Next(0, deck.Count);
                newDeck.Add(deck[val]);
                deck.RemoveAt(val);
            }

            this.deck = newDeck;

        }

        public Card Deal(List<Card> deck)
        {
            Card card = this.deck.Last();
            this.deck.RemoveAt(this.deck.Count() - 1);
            return card;
        }

        public void AddCard(Card cardToGive)
        {
            this.hand.Add(cardToGive);
        }

        public List<Card> Deck { get => deck; set => deck = value; }
        public List<Card> Hand { get => hand; set => hand = value; }
        public int Score { get => score; set => score = value; }
    }
}
