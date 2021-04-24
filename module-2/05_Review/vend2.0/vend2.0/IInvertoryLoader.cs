using System;
using System.Collections.Generic;
using System.Text;

namespace vend2._0
{
    public interface IInvertoryLoader
    {
        Dictionary<string, Item> loadInventory();
    }
}
