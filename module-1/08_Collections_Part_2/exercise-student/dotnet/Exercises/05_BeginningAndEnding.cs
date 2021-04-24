using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            
            Dictionary<string, string> wordsDictionary = new Dictionary<string, string>();
            foreach (string item in words)
            {
                string first = System.Char.ToString(item[0]);
                string last = System.Char.ToString(item[item.Length - 1]);
                //wordsDictionary[first] = last;
                wordsDictionary.Add(first, last);
            }
            // create a dictionary and return that dictionary 

            // loop through the string. Use substring. set key to first letter and value of key to last letter. loop through array of strings
            // what's return type? return type of this method is dictoinary of strings
            // what's my input? input parameter is array of strings 
            return wordsDictionary;
        }
    }
}
