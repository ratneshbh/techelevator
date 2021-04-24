using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore   //namespace by default
{
    class ShoppingCart  //class name is ShoppingCart
    {
        private List<Book> booksToBuy = new List<Book>();

        public void Add(Book newBook)
        {
            booksToBuy.Add(newBook);        //booksToBuy is our private data structure, the list up top
        }


    }
}
