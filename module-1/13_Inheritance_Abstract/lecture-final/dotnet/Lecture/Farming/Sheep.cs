using System;
using System.Collections.Generic;
using System.Text;
using Lecture.HelperClasses;

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
            //specific logic for the sheep class
           return Print.MakeSound("Baaaa");
        }

        public override string MakeSound(int numberOfTimes)
        {
            return  Print.MakeSound("Baaaa", numberOfTimes);
        }

        public override string PutToSleep()
        {
            throw new NotImplementedException();
        }
    }
}
