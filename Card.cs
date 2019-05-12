using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Card
    {
        public Card(){}
        public Card(CardRank rank , CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public CardRank Rank { get; set; }
        public CardSuit Suit { get; set; }
    }

    public enum CardRank{Ace, Duce, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King}

    public enum CardSuit{Diamond, Club, Heart, Spade}
}

