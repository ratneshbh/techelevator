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

            Book book = new Book();
            book.Author = "Ernest Kline";
            book.Title = "Ready Player 1";
            book.Price = 24.99;

            book = book;

            Book cosmos = new Book("Cosmos", "Carl Sagan", 45.99);

            // Step Five: Test the Book constructor



            // Step Nine: Test the ShoppingCart class

            ShoppingCart cart = new ShoppingCart();
            cart.Add(cosmos);                      // adding a book to new instance of cart
            cart.Add(book);                     // we've added 2 books 
            double shoppingCartTotal = cart.TotalPrice; 


        }
    }
}
