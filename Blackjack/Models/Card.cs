using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blackjack.Models
{
    public class Card
    {
        public string Suit { get; set; }
        public string Symbol { get; set; }
        public string Color { get; set; }
        public int Score { get; set; }
        public Card(string SuitParam, string SymbolParam)
        {
            this.Suit = SuitParam;
            this.Symbol = SymbolParam;

            if (SuitParam == "picas" || SuitParam == "trebol")
            {
                this.Color = "Negro";
            }
            else if (SuitParam == "corazones" || SuitParam == "diamantes")
            {
                this.Color = "Rojo";
            }


            switch (SymbolParam)
            {
                case "A":
                    this.Score = 1;
                    break;
                case "2":
                    this.Score = 2;
                    break;
                case "3":
                    this.Score = 3;
                    break;
                case "4":
                    this.Score = 4;
                    break;
                case "5":
                    this.Score = 5;
                    break;
                case "6":
                    this.Score = 6;
                    break;
                case "7":
                    this.Score = 7;
                    break;
                case "8":
                    this.Score = 8;
                    break;
                case "9":
                    this.Score = 9;
                    break;
                case "10":
                    this.Score = 10;
                    break;
                case "J":
                    this.Score = 10;
                    break;
                case "Q":
                    this.Score = 10;
                    break;
                case "K":
                    this.Score = 10;
                    break;
                default:
                    this.Score = 0;
                    break;
            }
        }
    }
}