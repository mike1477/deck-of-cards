using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            var deckOfCards = new Deck();
            char input = '-';

            while (input != 'q')
            {
                switch (input)
                {
                    case 'n':
                        deckOfCards = Deck.CreateNewDeck();
                        Console.WriteLine("New deck was created");

                        break;
                    case 's':                     
                        Console.WriteLine("Shuffling deck...");
                        Console.WriteLine("/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\");
                        deckOfCards.ShuffleDeck();
                        Console.WriteLine("Deck is shuffled. Ready to go!");
                        break;
                    case 'd':
                        Card currentCard = deckOfCards.Draw();
                        if (currentCard == null)
                        {
                            Console.WriteLine("Deck is empty. Press the n key to create another deck.");
                        }
                        else
                        {
                            Console.WriteLine($"Current card rank ** {currentCard.Rank} ** and the suit is ** {currentCard.Suit} **");
                        }
                        
                        break;
                    case 'r':
                        Console.WriteLine("Showing all cards remaining in deck. ****************************");
                        Console.WriteLine(deckOfCards.Cards.Count().ToString());
                        foreach (Card card in deckOfCards.Cards)
                        {
                            Console.WriteLine($"Current card rank ** {card.Rank} ** and the suit is ** {card.Suit} **");
                        };
                        Console.WriteLine("Done displaying cards. ****************************");
                        break;
                    default:
                        Console.WriteLine("Enter one of five keys to play the game.");
                        Console.WriteLine("q : Quit the game.");
                        Console.WriteLine("n : Create new deck.");
                        Console.WriteLine("s : Shuffle current deck.");
                        Console.WriteLine("d : Draw next card.");
                        Console.WriteLine("r : Display to console all the current cards in deck.");
                        break;
                }
                input = Console.ReadKey().KeyChar;
            }
        }
    }
}
