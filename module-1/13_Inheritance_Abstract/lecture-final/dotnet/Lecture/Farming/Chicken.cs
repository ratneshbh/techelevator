using System;
using Lecture.HelperClasses;

namespace Lecture.Farming
{
    //can only inherit from a single class(Single Inheritance) BUT can implement multiple interfaces
    public class Chicken : FarmAnimal, IEggProducer
    {
        public Chicken() : base("Chicken")
        {
        }

        public void LayEgg()
        {
            Console.WriteLine("Chicken laid an egg!");
        }
        public override string MakeSound()
        {
            //specific logic for the sheep class
            return Print.MakeSound("cluck");
        }

        public override string MakeSound(int numberOfTimes)
        {
            return Print.MakeSound("cluck", numberOfTimes);
        }

        public override string PutToSleep()
        {
          return Print.MakeSound("Zzzzz");
        }
    }
}
