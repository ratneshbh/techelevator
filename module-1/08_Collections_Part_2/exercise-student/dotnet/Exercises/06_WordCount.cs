using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         *
         *we are passing an array of strings named words into the method 
         *we need to return a dictionary in which the keys are the strings and values are the number of times
         *each string appears in the array. 
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> dictTwo = new Dictionary<string, int>();  //dictTwo is dictionary returned at the end
            foreach (string item in words)
            {
                if (dictTwo.ContainsKey(item) == true)
                {
                    dictTwo[item] += 1;
                }
                else
                    dictTwo[item] = 1;
            }
            
            return dictTwo;
        }
    }
}
