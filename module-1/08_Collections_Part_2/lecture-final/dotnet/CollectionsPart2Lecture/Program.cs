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
            //key    //value
            Dictionary<string, string> stateCapitals = new Dictionary<string, string>()
            {
                {"IN", "Indianapolis" },//comma separated
				{"FL", "Tallahasee" }
            };

            //check if key exists before using Add()
            stateCapitals.Add("KY", "Lexington");

            //preferred
            //insert OR update
            stateCapitals["KY"] = "Frankfort";

            //key    //value
            stateCapitals["OH"] = "Columbus";

            string floridaKey = "FL";
            string floridaCapitolValue = stateCapitals[floridaKey];

            Console.WriteLine($"The capital of Florida is: {floridaCapitolValue}");

            bool kyIsInDictionary = stateCapitals.ContainsKey("KY");
            Console.WriteLine($"Is Kentucky in the dictionary: {kyIsInDictionary}");

            if (!kyIsInDictionary)
            {
                stateCapitals.Add("KY", "Frankfort");
            }
            else
            {
                //update KY value to the current value concat with current value
                string kyValue = stateCapitals["KY"];
                string updatedValue = kyValue + kyValue;
                stateCapitals["KY"] = updatedValue;
            }

            //holds the key and value for each entry
            foreach (KeyValuePair<string, string> stateRow in stateCapitals)
            {
                Console.WriteLine($"The key is {stateRow.Key} and the value {stateRow.Value}");
            }

            //simplified data structure that we can loop through
            IEnumerable<string> stateKeys = stateCapitals.Keys;
            IEnumerable<string> stateValues = stateCapitals.Values;

            foreach (string stateKey in stateKeys)
            {
                Console.WriteLine($"Key: {stateKey}");
                //Console.WriteLine($"The value is: { stateCapitals[stateKey] }");
            }
            Console.WriteLine("Removing KY from Dictionary");
            stateCapitals.Remove("KY");

            foreach (KeyValuePair<string, string> stateRow in stateCapitals)
            {
                Console.WriteLine($"The key is {stateRow.Key} and the value {stateRow.Value}");
            }

            stateCapitals = stateCapitals;
            //create 2 dictionaries of key int value is string
            //add 4 rows to each dictionary
            //combines them into a single dictionary
            //if key exist concat the 2 values

            Dictionary<int, string> dictionary1 = new Dictionary<int, string>() {
                { 1, "one"},
                { 2, "two"},
                { 3, "three"},
                { 4, "quatro"},
             };

            Dictionary<int, string> dictionary2 = new Dictionary<int, string>() {
                { 4, "four"},
                { 5, "five"},
                { 6, "six"},
                { 7, "seven"},
            };

            foreach (KeyValuePair<int, string> numberKeyAndValue in dictionary1)
            {

                int key = numberKeyAndValue.Key;
                string value = numberKeyAndValue.Value;

                if (dictionary2.ContainsKey(key))
                {
                    dictionary2[key] = dictionary1[key] + dictionary2[key];
                }
                else
                {
                    dictionary2[key] = value;
                }
            }

            foreach (KeyValuePair<int, string> kvp in dictionary2)
            {
                Console.WriteLine($"Key is {kvp.Key} value is {kvp.Value}");
            }
        }
  
    }
}
