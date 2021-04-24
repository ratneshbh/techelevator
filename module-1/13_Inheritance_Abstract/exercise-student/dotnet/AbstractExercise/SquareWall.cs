using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class SquareWall : RectangleWall
    {

        public int SideLength { get; } //must do this outside cons
        public override string ToString()
        {
            return $"{Name} ({Length}x{Height}) square";
        }
        public SquareWall(string name, string color, int sideLength) : base (name, color, sideLength, sideLength)
        {
                this.SideLength = sideLength;
            
            
        }
    }
}
