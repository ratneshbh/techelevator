using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
     class ShoppingCart
    {
        //we only modify booksToBuy in this class
        private List<Book> booksToBuy = new List<Book>();
        public void Add(Book newBook)
        {
            //is it instock
            //
            booksToBuy.Add(newBook);
        }
        //derived property
        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (Book book in booksToBuy)
                {
                    total += book.Price;
                }
                return total;
            }
        }

        public string PrintReceipt()
        {
            string receipt = "\nReceipt\n";
            foreach (Book book in booksToBuy)
            {
                receipt += book.BookInfo();
                receipt += "\n";
            }

            receipt += "\nTotal: $" + TotalPrice;

            return receipt;
        }

        public string PrintReceipt(bool upper)
        {
            string receipt = "\nReceipt\n".ToUpper();
            foreach (Book book in booksToBuy)
            {
                receipt += book.BookInfo().ToUpper();
                receipt += "\n";
            }

            receipt += "\nTotal: $".ToUpper() + TotalPrice;

            return receipt;
        }

    }
}
