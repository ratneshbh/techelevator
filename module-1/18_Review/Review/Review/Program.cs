using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AnAbstractClass aac = new AnAbstractClass();
            ADerivedClass aDC = new ADerivedClass();
            aDC.AValue = "";
            aDC.AValue = "test";
        }
    }
}
