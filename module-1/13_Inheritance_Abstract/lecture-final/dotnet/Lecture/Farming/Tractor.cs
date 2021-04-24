using System;
using System.Collections.Generic;
using System.Text;
using Lecture.HelperClasses;

namespace Lecture.Farming
{
    class Tractor : ISingable
    {

        public string Name { get; } = "Tractor";

        //access in this class and also in any derived classes
        public int NumberOfTires { get; protected set; }

        public Tractor()
        {
            NumberOfTires = 10;
        }


        public virtual void Mow()
        {
            Print.MakeSound("VRROOMM");
        }

        public string MakeSound()
        {
            return Print.MakeSound("VRROOMM");
        }

        //NOT DRY COMPLIANT!!!!
        public string MakeSound(int numberOfTimes)
        {
            //calling static method
            //Print is a static helper class
            return Print.MakeSound("VRROOMM", numberOfTimes);
         
        }
    }
}
