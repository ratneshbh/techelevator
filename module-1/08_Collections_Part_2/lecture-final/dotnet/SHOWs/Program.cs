using System;
using System.Collections.Generic;

namespace SHOWs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //C.H.O.W.s 
            //show have others watch
            //dictionary key channel name
            //values List of shows on channels other have watched

            //when the app opens show all channels
                       //key   //string list of values
            Dictionary<string, List<string>> channels = new Dictionary<string, List<string>>();
            channels["HBO"] = new List<string>() {"Band of Brothers", "The Wire", "Game of Thrones" };
            channels["Netflix"] = new List<string>() {"Queens Gambit", "The Last Airbender", "The Last Kingdom" };
            channels["PrimeTV"] = new List<string>() {"The Boys", "Man In The High Castle", "The Expanse" };
            PrintChannels(channels);

            //allow user to enter a key(channel) to see the shows others watched

            Console.WriteLine("Which channel's Shows would you like to see??");
            string userInput = Console.ReadLine();
            PrintShows(userInput, channels);


            //add a show to channel
            //delete a show from channel
            //ADD A CHANNEL

        }
               //return type name  
        static void PrintChannels(Dictionary<string, List<string>> c)
        {
            foreach (KeyValuePair<string, List<string>> channel in c)
            {
                Console.WriteLine($"Channel {channel.Key}");
            }
        }

        static void PrintShows(string userTyped, Dictionary<string, List<string>> c)
        {

            if (c.ContainsKey(userTyped)){
                //create a list to hold shows where the key matches
                List<string> shows = c[userTyped];

                foreach (string show in shows)
                {
                    Console.WriteLine($"There is a show called {show}");
                }

            }
            else
            {
                Console.WriteLine("Channel not found sorry :(");
            }

        }
    }
}
