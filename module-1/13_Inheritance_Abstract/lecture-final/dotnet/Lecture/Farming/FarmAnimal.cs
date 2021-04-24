using Lecture.HelperClasses;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    /// Must be inherited
    /// cannot instantiate this class directly
    public abstract class FarmAnimal : ISingable
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

        //can only exist inside an abstract
        public abstract string PutToSleep();

        //overridable method
        public abstract string MakeSound();


        //overloading MakeSound method because changed method signature - adding a parameter
        public abstract string MakeSound(int numberOfTimes);

    }
}
