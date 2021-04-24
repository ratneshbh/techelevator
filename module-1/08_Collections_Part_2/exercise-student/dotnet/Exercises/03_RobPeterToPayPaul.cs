using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Modify and return the given Dictionary as follows: if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         *
         * Note, monetary amounts are specified in cents: penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         *
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 99}) → {"Peter": 1000, "Paul": 1099}
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         *
         */
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {
            // no loop 
            int petersMoney = peterPaul["Peter"];
            int paulsMoney = peterPaul["Paul"];

            if (petersMoney > 0 && paulsMoney < 1000)
            {
                int differenceInMoney = petersMoney / 2;
                peterPaul["Peter"] -= differenceInMoney;
                peterPaul["Paul"] += differenceInMoney;
            }  
            // math multiplied by 100
            //create dictionary with key being person and value being money. types will be string and double. 
            //if statement in order to check if Peter has more than 0. In code block of if statement perform math to transfer to Paul
                // does this require creating an array? I don't know. HOw do I perform math on certain values and assign to different keys? TBD
            // set variable to hold modified keys and values 
            //return the variable that was set to return the modified dictionary 
            //run test */
            return peterPaul;
        }
    }
}
