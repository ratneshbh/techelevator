using System;
using System.Collections.Generic;
using System.Linq;


namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int>{ 1, 2, 3, 4, 5, 5, 6, 2, 10 };

            IEnumerable<int> morethan3 = numbers.Where(n => n > 3);

            morethan3.ToList();
            morethan3 = morethan3;


            var dbcontext = new WorldContext();

            var countries = dbcontext.Countries.Where(n => n.Capital > 30);

            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
