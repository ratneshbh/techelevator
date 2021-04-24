using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDemo
{
    class Airplane : ISingable
    {
        public void MakeSound()
        {
            Console.WriteLine("so high");
        }
    }
}
