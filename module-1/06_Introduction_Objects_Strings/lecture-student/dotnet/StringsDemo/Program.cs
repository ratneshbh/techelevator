using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            char[] word = new char[] { 'J', 'O', 'E' };
            string joe = new string(word);
            joe = "jeux"; //changing the right side goes and changes the right side of the memory - deletes the reference?
            joe = joe;
            //immuable - read only 
            // array of chars

            char firstCharacter = name[0];
            char lastCharacter = name[name.Length - 1];

            Console.WriteLine($"The first character is {firstCharacter} and the last character is {lastCharacter}");

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            char firstCharacter = name[0];
            char lastCharacter = name[name.Length - 1];

            // Console.WriteLine("First and Last Character. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            string firstThreeCharacters = name.Substring(0, 3);

            //Console.WriteLine($"First 3 characters: {firstThreeCharacters}");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace
            string lastThreeCharacters = name.Substring(name.Length - 3);
            //Console.WriteLine("Last 3 characters: {firstThreeCharacters}{lastThreeCharacters}");

            // 4. What about the last word?
            // Output: Lovelace
            string[] word = name.Split(' ');
            Console.WriteLine($"Last Word: {word[ word.Length - 1 ]}");

            // Console.WriteLine("Last Word: ");

            // 5. Does the string contain inside of it "Love"?
            // Output: true
            bool containsLove = name.Contains("Love");  //this contains method is currently case sensitive
            //Console.WriteLine("Contains \"Love\" {containsLove}"); 

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            int locationOfLace = name.IndexOf("lace");

            Console.WriteLine($"Index of \"lace\" in Ada Lovelace: {locationOfLace}"); //case sensitive? returns -1 so Lace with cap L is not there

            // Console.WriteLine("Index of \"lace\": ");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            // only returns index of first occurrence
            // int numberOfA = name.IndexOf("a");

            // how do I count? how do keep track of things? 
            int numberOfAs = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'A') || name[i] == 'a')  // single quotes around A specifies a char eg 'char'
                {
                    numberOfAs++; 
                }
            }

            Console.WriteLine("Number of \"a's\": {numberOfAs}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            
            string updatedName = name.Replace("Ada", "Ada, Countess of Lovelace");
            // Console.WriteLine(name);

            // 9. Set name equal to null.
            name = null;
            // NOT the same thing as name = ""; because this is an empty string, not null
            // null is deleting the reference that points to the data aka the absence of data 
            // basically I have a variable, I know what it's called, but I have no reference to it
            // string is absence of chars, null is absence of value - not been assigned a value yet 
            

            // 10. If name is equal to null or "", print out "All Done".
            if (string.IsNullOrEmpty(name))
            {
                Console.Writeline("Name is null or empty string");
            }
            Console.ReadLine();
        }
    }
}