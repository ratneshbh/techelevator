using System;
using System.IO;

namespace Amortization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //USER interaction
            //ask principal
            //ask interest rate
            //assumed 30 year fixed
            //calculate data value
            //print the schedule to a file

            //happy path approach

            Console.WriteLine("Please enter the loan amount:");
            string principleAsString = Console.ReadLine();

            Console.WriteLine("Please enter the interest rate (as a whole number):");
            string interestRateAsString = Console.ReadLine();

            Console.WriteLine($"Calculating Schedule for {principleAsString} at {interestRateAsString}%");

            double principle = Double.Parse(principleAsString);
            double interestRate = Double.Parse(interestRateAsString);

            double monthlyInterestRate = (interestRate / 1200.0);
            double numberOfPayments = 360;
            double monthlyPayment = principle * monthlyInterestRate / (1 - System.Math.Pow((1 + monthlyInterestRate), -(numberOfPayments)));

            Console.WriteLine($"Monthly Payment will be: {monthlyPayment:C2}");
            for (int i = 0; i < numberOfPayments; i++)
            {
                double monthlyInterest = principle * monthlyInterestRate;
                double monthlyPrincipal = monthlyPayment - monthlyInterest;
                principle -= monthlyPrincipal;
                string lineItem = $"Payment # {i+1}:Interest Amount: {monthlyInterest:C2}, Principle Amount {monthlyPrincipal:C2}, remaining balance {principle:C2}";
               // Console.WriteLine(lineItem);
                string directory = Environment.CurrentDirectory;
                string filename = "Amortization-Schedule.txt";
                // Create the full path
                string fullPath = Path.Combine(directory, filename);
                try
                { //not good for performance
                    using (StreamWriter sw = new StreamWriter(fullPath, true))
                    {
                        sw.WriteLine(lineItem);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("couldnt open file for writing");
                }
            }
        }
    }
}
