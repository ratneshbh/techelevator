using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDemo
{
    class Tractor : ISingable
    {
        public void MakeSound()
        {
            Console.WriteLine("just tractor things");
        }
    }
}
