using System;
using System.IO;

namespace Lecture.Aids
{
    public static class ReadingAndWritingFiles
    {
        public static void OpenAndWrite()
        {
            // Figure the full path of the input file and output file
            string directory = Environment.CurrentDirectory;
            string inputFile = "programminglanguages.txt";
            string outputFile = "programminglanguages-FIXED.txt";
            string inputFullPath = Path.Combine(directory, inputFile);
            string outputFullPath = Path.Combine(directory, outputFile);

            try
            {
                // Open the existing file with the typo using a StreamReader
                using (StreamReader sr = new StreamReader(inputFullPath))
                {
                    // Open a StreamWriter where we will output the file
                    using (StreamWriter sw = new StreamWriter(outputFullPath, true))
                    {
                        // For each line in the input file, read it in
                        while (!sr.EndOfStream)
                        {
                            // Read an individual line
                            string line = sr.ReadLine();

                            // Replace the occurence of the word langauge with language
                            string fixedLine = line.Replace("langauge", "language");
                            fixedLine = fixedLine.Replace("aaa", "bbb");

                            // Write the new line to the output file
                            sw.WriteLine(fixedLine);
                        }
                    }
                }
                //replace original file
                File.Move(outputFile, inputFile, true);
                

            }
            catch (Exception e)
            {
                Console.WriteLine("couldnt do it, sorry");
            }
        }
    }
}
