using System;
using System.Collections.Generic;

#nullable disable

namespace linq
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
            Countrylanguages = new HashSet<Countrylanguage>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public float Surfacearea { get; set; }
        public short? Indepyear { get; set; }
        public int Population { get; set; }
        public float? Lifeexpectancy { get; set; }
        public decimal? Gnp { get; set; }
        public decimal? Gnpold { get; set; }
        public string Localname { get; set; }
        public string Governmentform { get; set; }
        public string Headofstate { get; set; }
        public int? Capital { get; set; }
        public string Code2 { get; set; }

        public virtual City CapitalNavigation { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Countrylanguage> Countrylanguages { get; set; }
    }
}
