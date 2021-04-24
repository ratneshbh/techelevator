using System;
using System.Collections.Generic;

#nullable disable

namespace linq
{
    public partial class City
    {
        public City()
        {
            Countries = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Countrycode { get; set; }
        public string District { get; set; }
        public int Population { get; set; }

        public virtual Country CountrycodeNavigation { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
    }
}
