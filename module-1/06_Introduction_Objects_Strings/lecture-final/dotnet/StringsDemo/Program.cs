using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";


            char[] aName = new char[] {'J','O','E' };//always need to use single quotes
            string joe = new string(aName);
            joe = "jeux";
            joe = joe;
            //immutable - read only
            // array of chars



            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            // Console.WriteLine("First and Last Character. ");
            
            char firstCharacter = name[0];
            char lastCharacter = name[name.Length - 1];

          //  Console.WriteLine($"The first character is {firstCharacter} and the last character is {lastCharacter}");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            string firstThreeCharacters = name.Substring(0, 3);

             //Console.WriteLine($"First 3 characters: {firstThreeCharacters}");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            string lastThreeCharacters = name.Substring(name.Length - 3);

            //Console.WriteLine($"First 3 characters: {firstThreeCharacters}{lastThreeCharacters}");

            // 4. What about the last word?
            // Output: Lovelace

            string[] word = name.Split(' ');

            // Console.WriteLine($"Last Word: {word[ word.Length-1 ]}");

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            bool containsLove = name.Contains("love");

            // Console.WriteLine($"Contains \"Love\" {containsLove}");

            // 6. Where does the string "lace" show up in name?
            // Output: 8
            //returns -1 if not found
            int locationOfLace = name.IndexOf("Lace");

             //Console.WriteLine($"Index of \"lace\" in Ada Lovelace: {locationOfLace}");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            //only returns index of first occurence
            //int numberOfA = name.IndexOf("a");

            int numberOfAs = 0;

            for (int i = 0; i < name.Length; i++)
            {

                if (name[i] == 'A' || name[i] == 'a')
                {
                    numberOfAs++;
                }

            }

           //  Console.WriteLine($"Number of \"a's\": {numberOfAs}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            string updatedName = name.Replace("Ada", "Ada, Countess of Lovelace");

            //Console.WriteLine(updatedName);

            // 9. Set name equal to null.
            name = "";
            // 10. If name is equal to null or "", print out "All Done".

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is null or empty string");
            }

            Console.ReadLine();
        }
    }
}