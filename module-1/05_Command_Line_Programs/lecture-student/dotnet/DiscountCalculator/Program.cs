using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // pseudocode:
            // this application will allow user to enter a discount 
            // then enter some prices
            // do some math
            // return updated prices 
      

            Console.WriteLine("Welcome to the Discount Calculator");

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage): ");

            string discountAmountAsString;

            discountAmountAsString = Console.ReadLine();
            //what type? 50% will be stored as .5 is one approach. Double, decimal, or float usable. 
            double discountPercentage = double.Parse(discountAmountAsString);
            //^this ONLY works with good data i.e. good users who type good numbers 



            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");
            //100 40 55 
            string itemPrices;
            itemPrices = Console.ReadLine();
            
            //string array    = split creates a new array with all of the values
            string[] itemPricesArray = itemPrices.Split(' ');

            //no functionality but allows us to create a breakpoint here 
            itemPricesArray = itemPricesArray;

            for (int i = 0; i < length; i++)
            {
                //looping through array of string 
                decimal priceAsDecimal;
                priceAsDecimal = decimal.Parse(itemPricesArray[i]);

                decimal amountOff = priceAsDecimal * (decimal)discountPercentage;
                //what is the actual sale price?
                decimal salePrice = priceAsDecimal - amountOff;
                Console.WriteLine("Discounted Price" + salePrice + " Original Price " + priceAsDecimal);

                // another way to do line 55 above is STRING INTERPOLATION - see MS documentation
                // Console.WriteLine($"Discounted Price {salePrice} Original Price {priceAsDecimal}");




            }


        }
    }
}
