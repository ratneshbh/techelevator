using Exercises.Classes;
using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // HomeworkAssignment ha = new HomeworkAssignment(60, "Brad", 80);
            // Console.WriteLine("Print {0}, grade", ha.ObtainedGrade);

            FruitTree fa = new FruitTree("apple", 16);
            Console.WriteLine("Fruit available {0} ", fa.PickFruit(20));

        }
    }
}
