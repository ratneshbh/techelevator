using System;
using System.Collections.Generic;
using System.Text;

namespace vend2._0
{
    public class VendingMachine
    {

        private Dictionary<string, Item> inventory = new Dictionary<string, Item>();

        public VendingMachine(IInvertoryLoader inventoryLoader)
        {
            inventory = inventoryLoader.loadInventory();
        }
    }
}
