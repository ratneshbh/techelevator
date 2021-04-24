using ExceptionHandling.Exceptions;
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            BadCode(); 


        }

        static void BadCode()
        {
            int[] array = { 1, 2, 3 };
            Console.WriteLine(array[4]); 
       
    }
}
