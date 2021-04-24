using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.HelperClasses
{
    static class Print
    {
        /// <summary>
        /// Static method inside of a static class
        /// cannot instaniate this class, but rather
        /// call methods directly
        /// </summary>
        /// <param name="message"></param>
        /// <returns>the string that was printed</returns>
        //public static string MakeSound(string message)
        //{
        //   // Console.Write(message);
        //    return message;
        //}
        //should be a void
        public static string MakeSound(string message, int numberOfTimes = 1)
        {
            string sounds = "";
            for (int i = 0; i < numberOfTimes; i++)
            {
                sounds += message + " ";
            }
            //TODO figure out why infinite loop
            
            //Console.WriteLine(sounds);
            return sounds;
        }
    }
}
