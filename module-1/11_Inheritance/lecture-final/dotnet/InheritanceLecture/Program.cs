using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction("Play Station 5");
           
            generalAuction.PlaceBid(new Bid("Josh", 1));
            generalAuction.PlaceBid(new Bid("Fonz", 23));
            generalAuction.PlaceBid(new Bid("Rick Astley", 13));

            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids

            ReserveAuction reserveAuction = new ReserveAuction(50, "Nintendo Switch");

            reserveAuction.PlaceBid(new Bid("Joe", 40));
            reserveAuction.PlaceBid(new Bid("Elijah", 50));
            reserveAuction.PlaceBid(new Bid("Chris", 60));



            //  reserveAuction.



            BuyoutAuction buyoutAuction = new BuyoutAuction(50, "Playstation 5");

            buyoutAuction.PlaceBid(new Bid("Joe", 40));
            buyoutAuction.PlaceBid(new Bid("Elijah", 50));
            buyoutAuction.PlaceBid(new Bid("Chris", 60));

            // Console.ReadLine();
        }
    }
}
