using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");
			//list is a collection of similar elements. Can collect from it and remove from it 

			//list of ints called numbers = new empty list of ints 
			List<int> numbers = new List<int>() { 1, 2 }; 
			numbers.Add(3);
			numbers.Add(5);

			

			List<string> adventureTimeCharacters = new List<string>() {"Marceleine", "Finn", "Jake" };
			adventureTimeCharacters.Add("Princess Bubble"); 
			//init     //condition   //iterator
			for (int i = 0; i < adventureTimeCharacters.Count ; i++)
            {
				//Console.WriteLine(adventureTimeCharacters[i]); 
            }
			//     //type of elements in collection 
			foreach (string character in adventureTimeCharacters)
            {
				Console.WriteLine(character); 
            }
			// to sort 
			foreach (string character in adventureTimeCharacters)
			{
				Console.WriteLine(character);
			}
			Console.WriteLine("After Sort:");
			adventureTimeCharacters.Sort(); 

			foreach (string character in adventureTimeCharacters)
            {
				Console.WriteLine(character);
            }

			return; 


			adventureTimeCharacters = adventureTimeCharacters; 
			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			
			

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			adventureTimeCharacters.Add("Finn");
			foreach (string character in adventureTimeCharacters)
			{
				//Console.WriteLine(character); 
			}

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			adventureTimeCharacters.Insert(2, "Ice King");  //assume we know size of list. If not know size, we do math - follow up with Joe

			foreach (string character in adventureTimeCharacters)
			{
				Console.WriteLine(character);
			}

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			adventureTimeCharacters.RemoveAt(2);  //remove Ice King - index is always an int. FIrst is 0. Last is count - 1
			foreach (string character in adventureTimeCharacters)
			{
				Console.WriteLine(character);
			}
			//adventureTimeCharacters.Remove("Finn");
			// don't modify collections as you're looping through them, unpredictable
			// use some logic, initialize a new list, character is not equal to Finn using an IF statement - create list of characters besides values that equal Finn
			// don't add or remove items as you're looping through a list 
			// create a second list to hold the one characters that are not Finn or what you needed to remove
			List<string> adventureTimeCharactersWithoutFinn = new List<string>(); //initialize new list
			foreach(string character in adventureTimeCharacters)
            {
				if (character != "Finn")
                {
					adventureTimeCharactersWithoutFinn.Add(character);
                }
            }

			return; 

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			bool isJakeInList = adventureTimeCharactersWithoutFinn.Contains("Jake");
			Console.WriteLine($"Is Jake in List: {IsJakeInList}"); 


			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			int jakesIndex = adventureTimeCharactersWithoutFinn.IndexOf("Jake")
				//Int jakesIndex = adventureTimeCharactersWithoutFinn.IndexOf("Jake");
                Console.WriteLine(	$"Jake's location is at index: {}");

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			string[] charactersAsArray = adventureTimeCharactersWithoutFinn.ToArray();

			//create list from array 
			List<string> backToList = new List<string>(charactersAsArray);

			adventureTimeCharactersWithoutFinn = new List<string>(charactersAsArray);

			adventureTimeCharactersWithoutFinn.AddRange(backToList);
			//backToList = backToList; // <-- create breakpoint here to see what happens
		}
	}
}
