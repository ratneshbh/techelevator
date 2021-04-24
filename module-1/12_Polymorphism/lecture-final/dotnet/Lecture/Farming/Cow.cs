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
            return "moo, yo";
        }
    }
}
