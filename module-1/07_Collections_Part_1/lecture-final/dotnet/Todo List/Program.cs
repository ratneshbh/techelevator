using System;
using System.Collections.Generic;

namespace Todo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TODO 2.0");
            Console.WriteLine("Please enter items and hit <Enter>");
            Console.WriteLine("Enter <q> to quit entering items");
            //ask the user to enter some todo items

            bool running = true;
            List<string> todoListItems = new List<string>();

            while (running)
            {
                string userResponse = "";
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "q")
                {
                    running = false;
                }
                else if(userResponse == "")
                {
                    Console.WriteLine("Invalid data, try again");
                } 
                else if (todoListItems.Contains(userResponse.ToLower()))
                {
                    Console.WriteLine("To do list item already added, try again");
                }
                else
                {
                    todoListItems.Add(userResponse.ToLower());
                }
                 
            }

            int i = 1;

            Console.WriteLine($"You have {todoListItems.Count} items on your list");
            foreach(string item in todoListItems)
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }

            Console.WriteLine("Enter a To Do item to remove");
            string itemToRemove = Console.ReadLine();
            todoListItems.Remove(itemToRemove);


            //allow to remove an item
        }
    }
}
