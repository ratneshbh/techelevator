using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDemo
{
    class Chicken : BaseAnimal
    {
        public Chicken() : base ("Chicken") { 

        }

        public Chicken(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("cluck");
        }
    }
}
