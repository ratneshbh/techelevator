using System;

namespace vend2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //separating dependency
            //input file, file logger
            //console read/write

            //exists to satisfy dependencies of VM and instantiate class
            //  IInvertoryLoader i = new FileInventoryLoader();
            IInvertoryLoader i = new InMemoryDictionary();
            
            VendingMachine vm = new VendingMachine(i);

        }
    }
}
