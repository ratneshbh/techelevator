using Lecture.HelperClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    //internal to this assembly
    internal class GardenTractor : Tractor
    {

        public GardenTractor()
        {
            NumberOfTires = 6;
        }

        //prevents any further overriding
        public sealed override void Mow()
        {
            //final form of this  method
            Print.MakeSound("Derived Mowing");
        }

    }
}
