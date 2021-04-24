using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{  //namespace - stay within the brackets of the namespace otherwise errors
    public abstract class Wall //make Wall class abstract because it is never instantiated, will be base class with subclasses
    {
        public string Name { get; }   //defining aka declaring the property
        public string Color { get; }
        public Wall(string name, string color)
        {
            this.Name = name;   //setting the property 
            this.Color = color;
        }


        //constructor per Step One - constructor doesn't need to have abstract keyword
        //constructor cannot be overridden
        public abstract int GetArea();    //abstract class has public abstract method 

    }


}
