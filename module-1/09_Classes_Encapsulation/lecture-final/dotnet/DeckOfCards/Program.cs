using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //class for deck
            //collection of cards
            //deal()
            //shuffle()
            //Card aceOfSpades = new Card("Spades", 1);
            //string faceValue = aceOfSpades.FaceValue;

            //static property
            //string clubs = Card.suits[0];

            Deck deckOfCards = new Deck();
            Card firstCard = deckOfCards.DealOne();
            firstCard = firstCard;
            Console.WriteLine(firstCard.Display());
            
        }
    }
}
