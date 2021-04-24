using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			
			Console.WriteLine();
			//keys are unique, values are not
			//unordered
						//key  //value
			Dictionary<string, string> stateCapitals = new Dictionary<string, string>(); //create dictionary

			stateCapitals.Add("KY", "Frankfort");   
			stateCapitals.Add("KY", "Lexington");   
			//preferred
			// insert OR update
			stateCapitals["KY"] = "Frankfort";   //adding the key KY and value Frankfort; can change [KY] value but not add to it

			stateCapitals["OH"] = "Columbus"; //can have duplicate data for the values? see 30 minutes into the lecture
			//                       this syntax refers to a value
			string floridaCapital = stateCapitals["FL"];

			string floridaKey = "FL";
			string floridaCapitalValue = stateCapitals[floridaKey];

			Console.WriteLine($"The capital of Florida is: {floridaCapitalValue}");

				// holds the key and value for each entry           <// key   //value>  
			foreach (KeyValuePair<string, string> stateRow in StateCapitals)
            {
				Console.WriteLine($"The key is {stateRow.Key} and the value {stateRow.Value}");
            }

			//how to know if key is present in dictionary? we have Contains keyword
			bool kyIsInDictionary = stateCapitals.ContainsKey("KY");
			Console.WriteLine($"Is Kentucky in the dictionary: {kyIsInDictionary}");

			if(!kyIsInDictionary)
            {
				stateCapitals.Add("KY", "Frankfort");
            }
            else
            {
				//update KY value to the current value concat with current value 
				string kyValue = stateCapitals["KY"];
				string updatedValue = kyValue + kyValue;
				stateCapitals["KY"] = updatedValue;
				


				string updatedValue = stateCapitals["KY"] + stateCapitals["KY"]; //same as above
				stateCapitals["KY"] = updatedValue;
            }
			//removing KY from Dictionary
			stateCapitals.Remove("KY");
			//create 2 dictionaries of key int value is string - do twice 
			Dictionary<T, T> identifier = new Dictionary<T, T>();
			Dictionary<int, string> foods = new Dictionary<int, string>() //no semicolon required
			{
				{ 1, "pizza" },


				{ 2, "cheesecake" },


				{ 3, "avocados" },


				{ 4, "grapes" }

			};

            foreach (keyValuePair<int, string> numberKeyAndValue in dictionary1)
            {
				dictionary2[numberKeyAndValue.Key] = numberKeyAndValue.Value;            //how to add key from dictionary 1 to dictionary 2?
																						 // or
				int key = numberKeyAndValue.Key;
				string value = numberKeyAndValue.Value;
				dictionary2[key] = value; 
			
			}
			// make new dictionary that's empty and loop through  

			if (dictionary2.ConstainsKey(key))
            {
				dictionary2[key] = dictionary1[key] + dictionary2[key]; 
            }
            else
            {
				dictionary2[key] = value;
            }

            foreach (KeyValuePair<int, string>         {

            }
			   
			
			Dictionary<int, string> animals = new Dictionary<int, string>();
            //add 4 rows to each dictionary
            {
				{8, "giraffe" },

				{12, "orangutan"},

				{13, "fox" },

				{15, "badger"}
				
				};
			
			
			// combine them into a single one 
			stateCapitals = stateCapitals;  //set breakpoint
