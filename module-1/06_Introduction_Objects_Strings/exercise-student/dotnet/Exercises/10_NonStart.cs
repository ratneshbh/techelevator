namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given 2 strings, return their concatenation, except omit the first char of each. The strings will
        be at least length 1.
        NonStart("Hello", "There") → "ellohere"
        NonStart("java", "code") → "avaode"
        NonStart("shotl", "java") → "hotlava"
        */
        public string NonStart(string a, string b)
        {
            string stringA = a; // declare string to hold string a
            string stringB = b; // declare string to hold string b 
            stringA = stringA.Remove(0, 1);
            stringB = stringB.Remove(0, 1); 
            return stringA + stringB;
        }
    }
}
