using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Deck
    {
        //field because
        private int anynumber = 0;
        private List<Card> Cards { get; } = new List<Card>();

        //adding a default constructor
        public Deck()
        {
            foreach (string suit in Card.suits)
            {
                //1 to 13 values
                for (int i = 1; i <= 13; i++)
                {
                    Card c = new Card(suit, i);
                    Cards.Add(c);
                }
            }
        }

        public Card DealOne()
        {
            Card cardToDeal = null;
            
            if (Cards.Count > 0)
            {
                cardToDeal = Cards[0];
                Cards.Remove(cardToDeal);
            }
            
            return cardToDeal;
        }

        //todo implement Shuffle 
        //https://stackoverflow.com/questions/273313/randomize-a-listt

    }
}
