using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //*****need to create file path and directory - requires its own class like in LectureAids? NO - all in Program.cs
            Console.WriteLine("What is the word to find?");
            string strFind = Console.ReadLine();
            Console.WriteLine("What is the word to replace with?");
            string strReplace = Console.ReadLine();
            Console.WriteLine("What is the source file?");  //or does the program prompt for file path?
            string fileInput = Console.ReadLine();
            Console.WriteLine("What is the destination file?");
            string destinationFile = Console.ReadLine();

            bool isFileValid = File.Exists(fileInput);  //file.Exists returns a boolean variable 
            // string fileInput = "test.txt";  
            if (isFileValid)
            {


                try //wrap while loop in try -- using -- catch block
                {
                    using (StreamReader sourceReader = new StreamReader(fileInput))  //what goes in here as parameter if not input?
                    using (StreamWriter streamWriter = new StreamWriter(destinationFile))
                    {
                        while (!sourceReader.EndOfStream)
                        {

                            string lineOfInput;

                            lineOfInput = sourceReader.ReadLine();  //read it here
                            /*bool matchFound = lineOfInput.Contains(strFind);
                            if (matchFound)
        //.Contains is a string method that returns a bool. in an if statement, anything between () is boolean
                            {
                                streamWriter.WriteLine(lineOfInput.Replace(strFind, strReplace));
                            }
                            else
                            {
                                streamWriter.WriteLine(lineOfInput);
                            } */
                            streamWriter.WriteLine(lineOfInput.Replace(strFind, strReplace));   //.Replace method allows us to replace here

                            // 
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The destination is invalid");
                }

            }
            else
            {
                Console.WriteLine("You entered an invalid source file path");

            }
        }
    } 
    }

