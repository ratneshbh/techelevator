using System;

namespace Todo_List
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("To do List!");
            Console.WriteLine("Enter some things you would like to do");
            Console.WriteLine("Enter 'done' when done");

            //ask the user to enter a single item
            //keep asking until they type 'n'
            //display the list 1,2,3 etc
            bool running = true;
            string[] todoArray = new string[1];

            while (running)
            {

               string[] userTodos = CreateArray(todoArray);
                

                string userTyped;
                userTyped = Console.ReadLine();

                if (userTyped == "done")
                {
                    running = false;
                }

                //add user input to an array
                todoArray[0] = userTyped;

            }
        }

        static string[] CreateArray(string[] originalArray )
        {
            //test data
            //test data [empty element]
            string[] newTodoArray = new string[originalArray.Length + 1];
            int i = 1;
            return newTodoArray;
        }

    }
}
