using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyoutAuction : Auction
    {
        //field
        private int buyoutPrice;

        public int BuyoutPrice
        {
            get
            {
                return buyoutPrice;
            }
        }

        public BuyoutAuction (int buyoutPrice, string itemForSale) 
            : base (itemForSale)
        {

            this.buyoutPrice = buyoutPrice;

        }
        
        public override bool PlaceBid(Bid offeredBid)
        {
            bool isCurrentHighBid = false;
            //if auction still going
            if (base.HasEnded)
            {
                Console.WriteLine("No more bids auction ended");
            }
            else
            {
                //if buyout price met end auction

                if (offeredBid.BidAmount >= buyoutPrice)
                {
                    //end auction
                    //set no allowed
                    // offeredBid.BidAmount = buyoutPrice;
                    Bid bid = new Bid(offeredBid.Bidder, buyoutPrice);
                    base.PlaceBid(bid);
                    base.EndAuction();
                    Console.WriteLine($"Winning bid placed by {offeredBid.Bidder}");
                }
                else
                {
                    isCurrentHighBid = base.PlaceBid(offeredBid);
                }
            }
            //else place the base.placebid
            //end the auction
            return isCurrentHighBid;

        }

    }
}
