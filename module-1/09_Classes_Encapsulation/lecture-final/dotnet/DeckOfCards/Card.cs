using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Card
    {

        public string Suit { get; }
        //can only be set in the constructor
        public int Value { get; }
        //only can be changed in this class
        public bool FaceUp { get; private set; } = false;
        //color TODO
        public Card(string suit, int value)
        {
            //'this' references the property for the current instance 
            this.Suit = suit;
            this.Value = value;
            //setting face up default false
            //this.FaceUp = false;

        }
        //derived
        public string FaceValue
        {
            get
            {
                //where the logic happens
                return faceValue[Value];
            }
        }

        public string Color
        {
            get
            {
                string output;
                if(Suit == "Hearts" || Suit == "Diamonds") 
                    {
                    output = "Red";
                    }
                    else
                    {
                    output = "Black";
                    }
                return output;
            }
        }

        public void Flip()
        {
            //if Faceup is true set to false
            //if faceup is false set to true
            /*
            if (FaceUp)
            {
                FaceUp = false;
            } 
            else
            {
                FaceUp = true;
            }
            */

            // FaceUp = (FaceUp) ? false : true;

            FaceUp = !FaceUp;
        }

        public string Display()
        {
            return $"Card is the {FaceValue} of {Suit}, and it is {Color}";
        }

        public static List<string> suits = new List<string>()
        {
            "Hearts","Diamonds", "Spades", "Clubs"
        };

        //static values are true for ALL instances of a class
        //dont need an instance of the class to access it
 
        private static Dictionary<int, string> faceValue = new Dictionary<int, string>()
        {
            {1, "Ace" },
            {2, "Two" },
            {3, "Three" },
            {4, "Four" },
            {5, "Five" },
            {6, "Six" },
            {7, "Seven" },
            {8, "Eight" },
            {9, "Nine" },
            {10, "Ten" },
            {11, "Jack" },
            {12, "Queen" },
            {13, "King" }
        };
    }
}
