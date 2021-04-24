using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //prompt user for filepath
            Console.WriteLine("Please put in a filepath");
            string filePathOfInput = Console.ReadLine();
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filePathOfInput))
                {
                    for (int i = 1; i < 301; i++)
                    {
                        string str = i.ToString();

                        if ((i % 3 == 0) && (i % 5 == 0))
                        {
                            streamWriter.WriteLine("FizzBuzz"); //print it to a file so you don't use Console.WriteLine
                        }
                        else if ((i % 5 == 0) || (str.Contains('5')))  //5 is a character so single quotes 
                        {
                            streamWriter.WriteLine("Buzz");
                        }
                        else if ((i % 3 == 0) || (str.Contains('3')))
                        {
                            streamWriter.WriteLine("Fizz");
                        }
                        else
                        {
                            streamWriter.WriteLine(i);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Filepath wasn't valid");

                throw e;
            }
           
        }
    }
}
