using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Sheep : FarmAnimal
    {

        public Sheep() : base("Sheep")
        {

        }

        //polymorphism, yo
        public override string MakeSound()
        {
            return "Baaaaa";
        }

    }
}
