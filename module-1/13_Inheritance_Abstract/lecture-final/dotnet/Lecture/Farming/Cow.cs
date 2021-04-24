using Lecture.HelperClasses;

namespace Lecture.Farming


{
    public class Cow : FarmAnimal
    {

        public Cow() : base("Cow")
        {
        }
        
        //polymorphism, yo


        public override string MakeSound()
        {
            return Print.MakeSound("Mooo");
        }

        public override string MakeSound(int numberOfTimes)
        {
            return Print.MakeSound("Mooo", numberOfTimes);
        }

        public override string PutToSleep()
        {
            throw new System.NotImplementedException();
        }
    }
}
