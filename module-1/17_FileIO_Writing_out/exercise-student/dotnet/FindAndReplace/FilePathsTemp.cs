using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FindAndReplace
{
    class FilePathsTemp //*****can I use base keyword here to create inheritance relationship with ReadingAndWriting class?
    {
        public static void UsingPathToCombineTwoFilePaths()
        {
            string path1 = @"C:\Temp\Directory";
            string sourceFileIdentity = @"test.txt";

            string fullPath = Path.Combine(sourceFileIdentity, path1); 
        }


    }
}
