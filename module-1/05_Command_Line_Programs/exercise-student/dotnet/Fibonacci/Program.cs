using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFibonacci;
            string inputString;
            int userInputNum;

            Console.Write("Please enter the Fibonacci number: ");
            inputString = Console.ReadLine();
            userInputNum = int.Parse(inputString);
            Console.WriteLine();

            outputFibonacci = produceFibonacciNums(userInputNum);
            Console.WriteLine(outputFibonacci);

            Console.ReadLine();
            Console.Clear(); 
            
        }
    public static string produceFibonacciNums(int stopNum)
        {
            string fibonacciNum = "0, ";
            int previousFibonacciNum = 0;
            int holdCurrentNum; 

            if (stopNum != 0)
            {
                for (int i = 1; i <= stopNum;)
                {
                    fibonacciNum = fibonacciNum + i + ", ";
                    holdCurrentNum = i;
                    i += previousFibonacciNum;
                    previousFibonacciNum = holdCurrentNum;
                }
            }
            return fibonacciNum; 
        }
    }
}
