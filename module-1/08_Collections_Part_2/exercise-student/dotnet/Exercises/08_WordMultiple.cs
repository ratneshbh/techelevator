using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            // generate a new dictionary dictTwo that will be returned at the end 
            // string array named words 
            // 
            Dictionary<string, bool> dictTwo = new Dictionary<string, bool>();
            foreach (string item in words)
            {
                  //dictTwo.ContainsKey(item) == true
                if (dictTwo.ContainsKey(item) == false)    //each different string is a key 
                {
                    dictTwo.Add(item, true);  
                }                             // each value is true only if that string appears 2 or more times in the array
            }
            return dictTwo;
        }
    }
}
