using System;
using System.IO;
using System.Collections.Generic;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the fully qualified name of the file to read in for quiz questions?");
            string pathToFile = Console.ReadLine();
            //string dataFilePath = @"C:\Users\Student\workspace\rbhattacharya-c\module-1\16_FileIO_Reading_in\exercise-student\dotnet\sample-file-quiz.txt";
            //string currentDirectory = Directory.GetCurrentDirectory();
            //Console.WriteLine(currentDirectory);
            try
            {
                using (StreamReader dataInput = new StreamReader(pathToFile))
                {
                    int totalQuestion = 0, correctAnswers = 0; 
                    while (!dataInput.EndOfStream)
                    {   
                        string line = dataInput.ReadLine();
                        //Console.WriteLine(line);
                        string[] lineList = line.Split("|");
                        string question = lineList[0];
                        string answer = "", opion = "", index = "";
                        int i = -1; 
                        foreach (string item in lineList)
                        {
                            i++;
                            if (item[item.Length - 1] == '*')
                            {
                                
                                answer = item;
                                index = i.ToString();
                                opion = item.Substring(0, item.Length - 1);
                            }
                        }
                        Console.WriteLine(question);
                        if (lineList[1] != answer)
                        {
                            Console.WriteLine("1. " + lineList[1]);
                        }
                        else
                        {
                            Console.WriteLine("1. " + opion);
                        }

                        if (lineList[2] != answer)
                        {
                            Console.WriteLine("2. " + lineList[2]);
                        }
                        else
                        {
                            Console.WriteLine("2. " + opion);
                        }

                        if (lineList[3] != answer)
                        {
                            Console.WriteLine("3. " + lineList[3]);
                        }
                        else
                        {
                            Console.WriteLine("3. " + opion);
                        }

                        if (lineList[4] != answer)
                        {
                            Console.WriteLine("4. " + lineList[4]);
                        }
                        else
                        {
                            Console.WriteLine("4. " + opion);
                        }
                        Console.WriteLine("Your answer: ");
                        string choice = Console.ReadLine();
                        
                        if (choice == index)
                        {
                            correctAnswers++;
                            Console.WriteLine("RIGHT!");
                        }
                        else
                        {
                            Console.WriteLine("WRONG!");
                        }

                        totalQuestion++;
                        // Console.WriteLine(lineList);

                    }

                    Console.WriteLine("You got " + correctAnswers + " answer(s) correct out of the " + totalQuestion + " questions asked.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file does not exist.");
                Console.WriteLine(ex.Message);
            }
            //StreamReader has opened the file 
            
            //List<string> lines = File.ReadAllLines(filePath).ToList(); //read all lines in text file and convert to List variable
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.ReadLine();

            //Console.WriteLine({quizQuestionA})
            //Console.WriteLine({quizQuestionB})

        }
}
}
