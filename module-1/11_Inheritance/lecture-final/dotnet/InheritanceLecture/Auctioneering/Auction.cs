using System;
using System.Collections.Generic;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a general auction.
    /// </summary>
    public class Auction
    {
        /// <summary>
        /// This is an encapsulated field that holds all placed bids.
        /// </summary>
        private List<Bid> allBids = new List<Bid>();

        /// <summary>
        /// Represents the current high bid.
        /// </summary>
        public Bid CurrentHighBid { get; private set; } = new Bid("", 0);

        /// <summary>
        /// All placed bids returned as an array.
        /// </summary>
        public Bid[] AllBids
        {
            get { return allBids.ToArray(); }
        }

        public string ItemForSale { get; private set; } 

        public Auction(string itemForSale)
        {
            this.ItemForSale = itemForSale;
        }

        /// <summary>
        /// Indicates if the auction has ended yet.
        /// </summary>
        public bool HasEnded { get; private set; } = false;//not strictly necessary as bools default to false

        public void EndAuction()
        {
            //additional methods, error handling
            //if we wanted
            HasEnded = true;
        }

        /// <summary>
        /// Places a Bid on the Auction
        /// </summary>
        /// <param name="offeredBid">The bid to place.</param>
        /// <returns>True if the new bid is the current winning bid</returns>
        public virtual bool PlaceBid(Bid offeredBid)
        {
            bool isHighestBid = false;
            // Print out the bid details.
            Console.WriteLine(offeredBid.Bidder + " bid " + offeredBid.BidAmount.ToString("C"));

            // Record it as a bid by adding it to allBids

            allBids.Add(offeredBid);

            // Check to see IF the offered bid is higher than the current bid amount

            if (offeredBid.BidAmount > CurrentHighBid.BidAmount)
            {
                CurrentHighBid = offeredBid;
                isHighestBid = true;
            }
            // if yes, set offered bid as the current high bid
            // Output the current high bid
            Console.WriteLine($"The current high bid is {CurrentHighBid.BidAmount.ToString("C")} and was placed by {CurrentHighBid.Bidder}");
            // Return if this is the new highest bid
            return isHighestBid;
        }

        public override string ToString()
        {
            return "I am an Auction";
        }
    }
}
