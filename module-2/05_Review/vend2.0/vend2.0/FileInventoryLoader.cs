using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace vend2._0
{
    class FileInventoryLoader : IInvertoryLoader
    {
        public Dictionary<string, Item> loadInventory()
        {

            Dictionary<string, Item> output = new Dictionary<string, Item>();

            using (StreamReader sr = new StreamReader("inventory.csv"))
            {
               
                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();


                }

            }

            return output;
        }
    }
}
