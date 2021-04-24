using System;
using System.IO;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {

            // Start with the file path to input
            string directory = Environment.CurrentDirectory;
            string filename = "Output.txt";
            // Create the full path
            string fullPath = Path.Combine(directory, filename);

            try
            {
                //create a new instance of the StreamWriter Class 
                // give it the fully qualified path to the file
                // optional bool parameter to append or overwrite the file if it exist
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    //what will be written to the file
                    string lineToWrite = "hello world";
                    //puts the string in the buffer (to be written when Dispose() called)
                    sw.WriteLine(lineToWrite);
                    //optional force writing to the file
                    //normally handled by framework
                    sw.Flush();
                    //write another line
                    sw.WriteLine(lineToWrite);
                }
                // After the using statement ends, file has now been written
                // and closed for further writing
            }catch(Exception e)
            {
                Console.WriteLine("couldnt open file for writing");
            }
        }
    }
}
