using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
        }

        public static Deck CreateNewDeck()
        {
            var newDeck = new Deck();
            var suits = Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>();
            foreach (CardSuit suit in suits)
            {
                var ranks = Enum.GetValues(typeof(CardRank)).Cast<CardRank>();
                foreach (CardRank rank in ranks)
                {
                    Card card = new Card(rank, suit);
                    newDeck.Cards.Add(card);
                };
            }
            return newDeck;
        }

        public void ShuffleDeck()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList();
        }

        public Card Draw()
        {
            Card currentCard = Cards.FirstOrDefault();
            if(currentCard != null)
            {
                Cards.Remove(currentCard);
            }

            return currentCard;
        }

        public List<Card> Cards { get; set; }
    }
}
