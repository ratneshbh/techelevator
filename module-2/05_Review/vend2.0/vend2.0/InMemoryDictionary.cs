using System;
using System.Collections.Generic;
using System.Text;

namespace vend2._0
{
    class InMemoryDictionary : IInvertoryLoader
    {
        public Dictionary<string, Item> loadInventory()
        {
            Item candybar = new Item();
            candybar.Name = "test";
            candybar.Price = 1M;
            Dictionary<string, Item> dict = new Dictionary<string, Item>();

            dict.Add("A1",candybar);

            return dict;
        }
    }
}
