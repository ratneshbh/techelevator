﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
	     The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on
	     vacation. We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in.
	     SleepIn(false, false) → true
	     SleepIn(true, false) → false
	     SleepIn(false, true) → true
	     */
        public bool SleepIn(bool weekday, bool vacation)
        {
            if ((weekday == false) && (vacation == false)) 
            {
                return true;
            }
            else if ((weekday == true) && (vacation == false))
            { 
            return false;
            }
            if ((weekday == false) && (vacation == true))
            {
                return true;
            }
            return true;

        }
    }
}