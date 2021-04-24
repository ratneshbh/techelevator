using System;
using System.IO;

namespace OpenAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fully Qualified Path To a File");

            
            //once you have file open and reading working ok
            // pathToFile = @"C:\test\test.txt";
            bool fileExist = false;
            while (!fileExist){
                string pathToFile = Console.ReadLine();
                fileExist = File.Exists(pathToFile);
            
                if (fileExist)
                {
                    try
                    {

                        using (StreamReader sr = new StreamReader(pathToFile))
                        {
                            ProcessLine(sr.ReadLine());
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("not good");
                        //throw;
                    }
                } 
                else
                {
                    Console.WriteLine("File not found, try again");
                }
            }
        }

        static void ProcessLine(string lineToProcess)
        {
            Console.WriteLine(lineToProcess);
        }
    }
}
