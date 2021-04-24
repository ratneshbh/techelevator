namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : ISingable
    {
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name)
        {
            Name = name;
        }

        //overridable method
        public virtual string MakeSound()
        {
            return "hello I am a generic animal";
        }

        //overloading MakeSound method because changed method signature - adding a parameter
        public string MakeSound(int numberOfTimes)
        {
            string sounds ="";
            for (int i = 0; i < numberOfTimes; i++)
            {
                sounds += MakeSound() + " ";
            }
            //TODO figure out why infinite loop
            return sounds;
        }
    }
}
