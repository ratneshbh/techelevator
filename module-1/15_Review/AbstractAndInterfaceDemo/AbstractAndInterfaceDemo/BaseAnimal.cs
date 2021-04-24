using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDemo
{
    abstract class BaseAnimal : ISingable
    {
        public string Name { get; set; }

        public BaseAnimal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();

    }
}
