using System.IO;
using System;

namespace WordSearch
{
    
        public class Program
        {
            public static void Main(string[] args)
            {
                //1. Ask the user for the file path
                Console.WriteLine("What is the fully qualified name of the file that should be searched?");
                string pathToFile = Console.ReadLine();
                Console.WriteLine("What is the search word you are looking for?");
                string str = Console.ReadLine();
                Console.WriteLine("Should the search be case-sensitive? (Y\\N)");    //are escape clauses needed here?
                string yOrNo = Console.ReadLine();
                
                                                                    //yOrNo = char.Parse(yOrN); not sure about this approach - input isn't a string 
                                                                    //bool inputIsY = true;     //created bool variable for situation when user inputs Y happens 
            




                //capture user input into a string 
                //2. Ask the user for the search string

                //create a counter; 
                StreamReader file = new StreamReader(pathToFile);
                int counter = 0;
                string line;
                while (!file.EndOfStream)
                {
                    counter++;
                    line = file.ReadLine();
                    if (line.Contains(str) )
                    {
                        //print line number
                        Console.WriteLine($"{counter}{line}");
                    }
                else if (yOrNo == "Y" && line.Contains(str, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine($"{counter}{line}"); 
                }
                {

                }

                
            }

            //line.Contains(str, StringComparison.CurrentCultureIgnoreCase)

            // for case insensitive - use ToLower()
            //try
            //    { 
            //    }
            //    catch(Exception)
            //    {


            //    }
            //3. Open the file
            // test file is here: string filePath = @"C:\Users\Student\workspace\rbhattacharya-c\module-1\16_FileIO_Reading_in\exercise-student\dotnet\alices_adventures_in_wonderland.txt";    
            //4. Loop through each line in the file





            //5. If the line contains the search string, print it out along with its line number
        }
    }
    
}
