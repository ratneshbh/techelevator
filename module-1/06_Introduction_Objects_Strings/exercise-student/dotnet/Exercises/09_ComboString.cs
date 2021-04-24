﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string
        on the outside and the longer string on the inside. The strings will not be the same length, but
        they may be empty (length 0).
        ComboString("Hello", "hi") → "hiHellohi"
        ComboString("hi", "Hello") → "hiHellohi"
        ComboString("aaa", "b") → "baaab"
        */
        public string ComboString(string a, string b)
        {
            string stringA = a;
            string stringB = b;
            if (stringA.Length > stringB.Length && stringA.Length != 0)
            {

                return (stringB + stringA + stringB);
            }
            else if (stringB.Length > stringA.Length && stringB.Length != 0)
            {

                return (stringA + stringB + stringA);
            }
            else
            {
                return null;
            }
            
            
        }
    }
}
