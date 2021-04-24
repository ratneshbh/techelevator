using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName) // key variable name is animalName
        {
            //Dictionary<T, T> identifier = new Dictionary<T, T>();
            Dictionary<string, string> animalAndName = new Dictionary<string, string>() //create dictionary
            {          //key     //value                                    //dictionary is instantiated and initialized
                {"rhino", "Crash" },
                {"giraffe", "Tower" },
                {"elephant", "Herd" },
                {"lion", "Pride" },
                {"crow", "Murder" },
                { "pigeon", "Kit"},
                { "flamingo", "Pat"},
                { "deer", "Herd"},
                { "dog", "Pack"},
                { "crocodile", "Float"}
            };
            
            string animalGroup;
            if (animalName != null && animalAndName.ContainsKey(animalName.ToLower()))      //animalAndName is the dictionary - but how I do access the group of animal name, not just an individual name?
            {
                animalGroup = animalAndName[animalName.ToLower()];
                //what is the value of the dictionary animalAndName at this key animalNameValue?
            }
                    else
                {
                    return "unknown";
                }

                

            return animalGroup;
        }
    }
}
