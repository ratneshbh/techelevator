﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end.
        The string length will be at least 2.
        Left2("Hello") → "lloHe"
        Left2("java") → "vaja"
        Left2("Hi") → "Hi"
        */
        public string Left2(string str)
        {
            string firstTwoCharsOnly;
            firstTwoCharsOnly = str.Substring(0, 2);   //create string to hold first 2 chars 
            string remainingChars;
            remainingChars = str.Remove(0, 2);// create string to hold string without first 2 chars
            return remainingChars + firstTwoCharsOnly;
        }
    }
}