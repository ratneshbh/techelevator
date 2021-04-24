using System;

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
            return "cluck";
        }
    }
}
