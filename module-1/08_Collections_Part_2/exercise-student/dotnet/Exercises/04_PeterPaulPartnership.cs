using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Modify and return the given Dictionary as follows: if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a combined contribution of a quarter of each partner's
         * current worth.
         *
         * PeterPaulPartnership({"Peter": 50000, "Paul": 100000}) → {"Peter": 37500, "Paul": 75000, "PeterPaulPartnership": 37500}
         * PeterPaulPartnership({"Peter": 3333, "Paul": 1234567890}) → {"Peter": 3333, "Paul": 1234567890}
         *
         */

        //
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            //if paul has >50 and peter has value y >100
            //create a new dictionary 

            
            if (peterPaul["Peter"] >= 50000 && peterPaul["Paul"] >= 100000)
            {
                Dictionary<string, int> newPeterPaulPartnership = new Dictionary<string, int>(); 
                int quarterOfPeter = peterPaul["Peter"] / 4;
                int quarterOfPaul = peterPaul["Paul"] / 4;
                int quarterOfBoth = quarterOfPeter + quarterOfPaul;
                
                
                newPeterPaulPartnership["Peter"] = peterPaul["Peter"] - quarterOfPeter;
                

                newPeterPaulPartnership["Paul"] = peterPaul["Paul"] - quarterOfPaul;

                newPeterPaulPartnership["PeterPaulPartnership"] = quarterOfBoth;

                return newPeterPaulPartnership;

            }

            return peterPaul;
            //if ( 5000)           //how to write PeterPaulPartnership["Peter"].value
            //{
            //    int quarterOfPeter = peterPaul["Peter"] / 4;
            //    int quarterOfPaul = peterPaul["Paul"] / 4;
            //    int quarterOfBoth = quarterOfPeter + quarterOfPaul;
            //    newPeterPaulPartnership["Peter"] -= quarterOfPeter;
            //    newPeterPaulPartnership["Paul"] -= quarterOfPaul;
            //    return newPeterPaulPartnership;
            //}

        }



        //    public Dictionary<string, int> newPeterPaulPartnership = new Dictionary<string, int>()
        //    {
        //            { "Peter", 50000},
        //            { "Paul", 100000},

        //        };

        //}

    }
}
    


