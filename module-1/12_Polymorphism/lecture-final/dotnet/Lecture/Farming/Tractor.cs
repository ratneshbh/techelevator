using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Tractor : ISingable
    {

        public string Name { get; } = "Tractor";

        public string MakeSound()
        {
            return "VROOOOOOM";
        }

        //NOT DRY COMPLIANT!!!!
        public string MakeSound(int numberOfTimes)
        {
            string sounds = "";
            for (int i = 0; i < numberOfTimes; i++)
            {
                sounds += MakeSound() + " ";
            }
            //TODO figure out why infinite loop
            return sounds;
        }
    }
}
