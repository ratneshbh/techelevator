using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a series of decimal values (separated by spaces): ");
            string userDecimalsAsString;
            userDecimalsAsString = Console.ReadLine();
            string[] userInputAsArray = userDecimalsAsString.Split(' ');

            int numberBeingConverted;

            string output;

            for (int i = 0; i < userInputAsArray.Length; i++)
            {
                numberBeingConverted = int.Parse(userInputAsArray[i]);

                output = $"{numberBeingConverted} in binary is ";

                string numberAddedToOutput = ""; 

                while (numberBeingConverted > 0)
                {
                    int digitBeingAdded;
                    digitBeingAdded = numberBeingConverted % 2;
                    numberBeingConverted = numberBeingConverted / 2;
                    numberAddedToOutput = $"{digitBeingAdded}{numberAddedToOutput}"; 
                }

                output += numberAddedToOutput;

                Console.WriteLine(output);
            }
        }
    }
}
