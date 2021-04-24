﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return true if the given non-negative number is a multiple of 3 or 5, but not both.
         (Hint: Think "mod".)
         Old35(3) → true
         Old35(10) → true
         Old35(15) → false
         */
        public bool Old35(int n)
        {
            if (n > 0 && n % 3 == 0)
            {
                return true;
            }
            if (n > 0 && n % 5 == 0)
            {
                return true;
            }
            else 
            return false;
        }
    }
}