using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{

    //cant create an instance of an interface
    public interface ISingable
    {
        //any class that implements this interface 
        //must provide MakeSound method
        public string MakeSound();
        public string MakeSound(int numberOfTimes);
        string Name { get; }
    }
}
