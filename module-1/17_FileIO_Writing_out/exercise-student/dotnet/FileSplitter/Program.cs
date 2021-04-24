using System;
using System.IO;


namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where is the input file (please include the path to the file)");
            string filePathOfInput = Console.ReadLine();
            Console.WriteLine("How many lines of text(max) should there be in the split files?");
            string strLinesOfText = Console.ReadLine();

            //FileStream fileStream = new FileStream(@"c:\big-old-file.md", FileMode.Open, FileAccess.Read);
            //verify the contents of the file 
            
            
            //read the file 
            //generate List of strings 
            //need loop, then another loop --> map this out on excalidraw
            try
            {
                string fileName = @"C:\big-old-file.md"; //change this path 

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //StreamWriter.WriteLine(line);  
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
