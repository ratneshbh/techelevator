using System;

namespace AbstractAndInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //abstract animal - name : makesound
            //interface makesound
            //instances of makesound interface
            Chicken chickenInstance = new Chicken();
            Chicken namedChickenInstance = new Chicken("RedBird");
            Tractor tractor = new Tractor();
            Airplane airplane = new Airplane();
            Sing(chickenInstance);
            Sing(tractor);
            Sing(airplane);


        }

        public static void Sing(ISingable thingThatSings)
        {
            thingThatSings.MakeSound();
        }
    }
}
