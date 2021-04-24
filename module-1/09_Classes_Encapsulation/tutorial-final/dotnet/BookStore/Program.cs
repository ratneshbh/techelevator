using System;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tech Elevator Bookstore");
            Console.WriteLine();

            // Step Three: Test the properties

            Book readyPlayerOne = new Book();
            readyPlayerOne.Author = "Ernest Kline";
            readyPlayerOne.Title = "Ready Player 1";
            readyPlayerOne.Price = 24.99;

            Book cosmos = new Book("Cosmos", "Carl Sagan", 45.99);

            Console.WriteLine(cosmos.BookInfo());
            Console.WriteLine(readyPlayerOne.BookInfo());
            // Step Five: Test the Book constructor



            // Step Nine: Test the ShoppingCart class

            ShoppingCart cart = new ShoppingCart();
            cart.Add(cosmos);
            cart.Add(readyPlayerOne);
            double shoppingCartTotal = cart.TotalPrice;
            // functionality is encapsulated in the cart class
            // cart.booksToBuy.Remove(cosmos);

            Console.WriteLine(cart.PrintReceipt(true));

        }
    }
}
