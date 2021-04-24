using System;
using System.Collections.Generic;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            QueueDemo();
            StackDemo();
            HashSetDemo();
        }

        //void methods dont return anything
        static void QueueDemo()
        {

            //First In First Out
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // A queue can be enumerated without disturbing its contents.
            DisplayCollection(numbers);

            string whatWillBeNext = numbers.Peek();
            string nextNumber = numbers.Dequeue();

            Console.WriteLine($"the next number will be {whatWillBeNext}");
            Console.WriteLine($"next in line {nextNumber}");

            DisplayCollection(numbers);

        }

        static void StackDemo()
        {
            //Last In First Out
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            // A stack can be enumerated without disturbing its contents.
            DisplayCollection(numbers);

            string whatWillBeNext = numbers.Peek();
            string nextNumber = numbers.Pop();

            Console.WriteLine($"the next number will be {whatWillBeNext}");
            Console.WriteLine($"next in line {nextNumber}");

            DisplayCollection(numbers);
        }

        static void HashSetDemo()
        {
            HashSet<string> goodProgrammingLanguages = new HashSet<string>();
            HashSet<string> weirdProgrammingLanguages = new HashSet<string>();

            goodProgrammingLanguages.Add("C#");
            goodProgrammingLanguages.Add("Java");
            goodProgrammingLanguages.Add("Javascript");

            weirdProgrammingLanguages.Add("COBOL");
            weirdProgrammingLanguages.Add("Clojure");
            weirdProgrammingLanguages.Add("Javascript");

            HashSet<string> union = new HashSet<string>(goodProgrammingLanguages);
            HashSet<string> intersect = new HashSet<string> (goodProgrammingLanguages);
            HashSet<string> except = new HashSet<string> (goodProgrammingLanguages);

            union.UnionWith(weirdProgrammingLanguages);
            //DisplayCollection(goodProgrammingLanguages);

            intersect.IntersectWith(weirdProgrammingLanguages);
            //DisplayCollection(intersect);

            except.ExceptWith(weirdProgrammingLanguages);
            DisplayCollection(except);

        }

        static void DisplayCollection(IEnumerable<string> collection)
        {
            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
