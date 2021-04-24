using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    //reserveAuction is the derived from base Auction class
    class ReserveAuction : Auction
    {
        //field 
        private int reservePrice;

        //constructor
        public ReserveAuction(int reservePrice, string itemForSale)
            : base(itemForSale)
        {
            this.reservePrice = reservePrice;
        }

        public override bool PlaceBid(Bid offereredBid)
        {
            bool isCurrentHighBid = false;

            if (offereredBid.BidAmount >= reservePrice)
            {
                Console.WriteLine("Reserve has been meet");
                //call the base class function
                isCurrentHighBid = base.PlaceBid(offereredBid);
                
            }

            return isCurrentHighBid;
        }

    }


}
