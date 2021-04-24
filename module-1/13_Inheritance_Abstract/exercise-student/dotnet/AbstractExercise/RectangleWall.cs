using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class RectangleWall : Wall //extending Wall
    {
        public override int GetArea() 
        {
            
            return Length * Height; //Question: could you call method using Wall.GetArea(length, height); ?
        }
        public override string ToString() 
        {
            
            return $"{Name} ({Length}x{Height}) rectangle"; 
        }  //error 0161 came up bc of adding ToString method - some errors will come up while writing a method
        public int Length { get; }  //a property without a setter is considered readonly
        public int Height { get; }   //set properties inside code body of RW constructor because these are readonly 
        public RectangleWall(string name, string color, int length, int height) : base(name, color) //here, we are setting name and color properties already via base keyword
        {
            this.Length = length;   //are the properties set here because L and H are properties of the RW?
            this.Height = height;  //here, assigning values to properties in the code body of the RW constructor
            
            

        } //constructor per Step 2 - constructor of subclass has to match constructor of base class? 
        //calling the base class constructor here so the parameters need to match what's in the base constructor

        
    }
}
