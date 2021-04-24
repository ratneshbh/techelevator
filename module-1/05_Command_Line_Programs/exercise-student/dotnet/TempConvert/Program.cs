using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will convert temperature from Fahrenheit to Celsius and vice versa");
            Console.WriteLine("Please enter a temperature.");
            string temperatureInputValue; //this is a STRING
            temperatureInputValue = Console.ReadLine(); // declare variable to hold user numeric input in string
            
            Console.WriteLine("Fahrenheit type F, or if Celsius type C");
            string temperatureInput; //declare variable to hold user input whether F or C in string format
            temperatureInput = Console.ReadLine(); //get user input for F or C - currently in string format

            if ( temperatureInput == "F" ) //condition to check whether user input F - which variable holds this input?
            {
                double temperatureInputValueDouble; //holds value converted to double from STRING input
                temperatureInputValueDouble = double.Parse(temperatureInputValue);
                double temperatureOutputInC = (temperatureInputValueDouble - 32) / 1.8;
                Console.WriteLine(temperatureOutputInC + "is your temperature in Celsius");
            }

            else if ( temperatureInput == "C" )  //condition to check user input includes C character in string format
            {
                double temperatureInputValueDouble; 
                temperatureInputValueDouble = double.Parse(temperatureInputValue);
                double temperatureOutputInF = (temperatureInputValueDouble * 1.8) + 32;
                Console.WriteLine("Your temperature in Fahrenheit is " + temperatureOutputInF);
            }
        
        }
    }
}
