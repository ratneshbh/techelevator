using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will convert lengths from meter to feet and vice versa");
            Console.WriteLine("Enter a length");
            string lengthNumericInput;
            lengthNumericInput = Console.ReadLine();
            Console.WriteLine("Is this length in (m)eter, or (f)eet?");
            string lengthInputInFOrM;
            lengthInputInFOrM = Console.ReadLine();

            if (lengthInputInFOrM == "f")
            {
                double lengthInputValue;
                lengthInputValue = double.Parse(lengthNumericInput);
                double lengthOutputValueInM = (double)(lengthInputValue * .3048); // calculation  m = f * 0.3048 f = m * 3.2808399
                int roundedOutputInM;
                roundedOutputInM = (int)lengthOutputValueInM;
                Console.WriteLine(lengthNumericInput + lengthInputInFOrM + " " + "is" + " " + lengthOutputValueInM + "m");
            }
            else if (lengthInputInFOrM == "m")
            {
                double lengthInputValue;
                lengthInputValue = double.Parse(lengthNumericInput);
                double lengthOutputInF = (double)(lengthInputValue * 3.2808399);
                int roundedOutputInF;
                roundedOutputInF = (int)lengthOutputInF;
                Console.WriteLine(lengthNumericInput + lengthInputInFOrM + " " + "is" + " " + roundedOutputInF + "f");
            }
        }
    }
}
    
