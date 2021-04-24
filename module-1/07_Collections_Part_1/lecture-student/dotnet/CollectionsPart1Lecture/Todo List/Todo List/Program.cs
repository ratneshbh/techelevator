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
            Console.WriteLine("Enter <q> to quit");
            //ask the user to enter some todo items

            //while condition is true, keep looping through here
            bool running = true; //this is a default condition bool here
            List<string> todoListItems = new List<string>(); // left side matches the right side wrt List<string> portion
            while (running)
            {
                string userResponse = ""; //create variable to keep track of that string
                userResponse = Console.ReadLine(); //return type on readline method is STRING 
                if (userResponse.ToLower() == "q")
                {
                    running = false;
                }// first, handle the getting out of the loop
                else if(userResponse == "")
                {
                    Console.WriteLine("Invalid data, try again");
                }
                else if (todoListItems.Contains(userResponse))
                {
                    Console.WriteLine("To do list item already added, try again");
                }
                else
                {
                    todoListItems.Add(userResponse);
                }

                todoListItems.Add(userResponse);

            }
            //loop and allow for them to add multiple items
            //don't allow duplicate items

            //display the items 
            int i = 1;

            Console.WriteLine($"You have {todoListItems.Count} items on your list");
            foreach(string item in todoListItems)
            {
                Console.WriteLine($"{i}. {item}");
                i++; 
            }
            //allow to remove an item 
            Console.WriteLine("Enter a To Do item to remove");
            string itemToRemove = Console.ReadLine(); //set up variable to capture the result of calling that method
            todoListItems.Remove(itemToRemove);
        }
    }
}
