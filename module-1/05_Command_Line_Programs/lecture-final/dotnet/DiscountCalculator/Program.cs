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

            //enter discount
            //

            
            Console.WriteLine("Welcome to the Discount Calculator");

            // Prompt the user for a discount amount


            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage): ");
            string discountAmountAsString;
            discountAmountAsString = Console.ReadLine();

            //this ONLY works with good data
            double discountPercentage = double.Parse(discountAmountAsString);
            discountPercentage = discountPercentage * .01;

            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");
            //100 40 55
            string itemPrices;
            itemPrices = Console.ReadLine();


            //string array      = split creates a new array with all of the values
            string[] itemPricesArray = itemPrices.Split(' ');
 
            //no functionality but allows us to place a breakpoint here
            itemPricesArray = itemPricesArray;

            
            for (int i = 0; i < itemPricesArray.Length; i++)
            {

                //looping through array of string
                decimal priceAsDecimal;
                priceAsDecimal = decimal.Parse(itemPricesArray[i]);

                decimal amountOff = priceAsDecimal * (decimal)discountPercentage;
                decimal salePrice = priceAsDecimal - amountOff;
                Console.WriteLine("Discounted Price " + salePrice + " Original Price " + priceAsDecimal);
                //string interpolation
                Console.WriteLine($"Discounted Price {salePrice} Original Price {priceAsDecimal}");

            }







        }
    }
}
