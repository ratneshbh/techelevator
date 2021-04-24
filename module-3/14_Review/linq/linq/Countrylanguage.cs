using System;
using System.Collections.Generic;

#nullable disable

namespace linq
{
    public partial class Countrylanguage
    {
        public string Countrycode { get; set; }
        public string Language { get; set; }
        public bool Isofficial { get; set; }
        public float Percentage { get; set; }

        public virtual Country CountrycodeNavigation { get; set; }
    }
}
