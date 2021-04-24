﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given two temperatures, return true if one is less than 0 and the other is greater than 100.
         IcyHot(120, -1) → true
         IcyHot(-1, 120) → true
         IcyHot(2, 120) → false
         */
        public bool IcyHot(int temp1, int temp2)
        {
            if ( ( temp1 > 100 ) && ( temp2 < 0 ) )
            {
                return true;
            }
            if ( (temp1 < 0) && (temp2 > 100) )
            {
                return true;
            }
            if ( ( temp1 > 0) && (temp2 > 100) )
            {
                return false;
            }
            return false;
        }
    } 
}
