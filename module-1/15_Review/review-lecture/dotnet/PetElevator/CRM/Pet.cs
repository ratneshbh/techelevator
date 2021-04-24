using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
    class Pet
    {

        string PetName { get; set; }
        string Species { get; set; }
        List<string> Vaccinations { get; set; } = new List<string>();

        public Pet(string petName, string species)
        {
            PetName = petName;
            Species = species;
        }
    }
}
