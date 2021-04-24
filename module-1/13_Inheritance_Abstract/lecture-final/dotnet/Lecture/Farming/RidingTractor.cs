using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class RidingTractor : GardenTractor
    {
        public RidingTractor()
        {
            NumberOfTires = 8;
            
        }
        ////cannot override sealed method
        //public override void Mow()
        //{
        //    //Print.MakeSound("Derived Mowing");
        //}
    }
}
