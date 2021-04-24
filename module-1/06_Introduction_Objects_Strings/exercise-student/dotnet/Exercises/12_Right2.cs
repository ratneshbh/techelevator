namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start.
        The string length will be at least 2.
        Right2("Hello") → "loHel"
        Right2("java") → "vaja"
        Right2("Hi") → "Hi"
        */
        public string Right2(string str)
        {
            if (str.Length > 2)
            {
                string lastTwoCharsOnly = str.Substring(str.Length - 2, 2); // hold substring of last 2 chars
                //declare string variable to hold remaining chars after removal
                string remainingChars = str.Substring(0, str.Length - 2); // declare string to hold string after removal of last 2 chars
                
                return lastTwoCharsOnly + remainingChars; // return last 2 chars concatenated with remaining chars
            }
            else
            {
                return str;
            }
         
            
        }
    }
}
