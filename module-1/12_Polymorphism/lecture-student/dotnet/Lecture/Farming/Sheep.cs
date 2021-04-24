using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Sheep : FarmAnimal  //FarmAnimal is base class. Sheep is derived from FarmAnimal class
    {
        public Sheep() : base("Sheep")   //satisfied base class overloaded method call now
        {
            
        }

        public override string MakeSound()
        {
            return "Baaaaa";
        }
    }
}
