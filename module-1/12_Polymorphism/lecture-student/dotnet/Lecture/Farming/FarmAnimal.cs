namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal
    {
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }


        /// <summary>
        /// The farm animal's sound
        /// </summary>
        public string Sound { get; }

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
        public virtual string MakeSound(int NumberOfTimes)
        {
            string sounds = "";
            for (int i = 0; i < NumberOfTimes; i++)
            {
                sounds += MakeSound() + " ";
            }

            return sounds;
        }
    }
}
