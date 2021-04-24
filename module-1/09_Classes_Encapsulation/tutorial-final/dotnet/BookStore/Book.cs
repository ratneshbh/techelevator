using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class Book
    {
        //get set control access
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        //default constructor
        //you dont need to create unless you plan to change behavior
        public Book()
        {

        }

        //constructor method matched the classname
        //constructor overload applied
        //no return types
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string BookInfo()
        {
            return $"The book {Title} was written by {Author} and it costs {Price}";
        }
    }
}
