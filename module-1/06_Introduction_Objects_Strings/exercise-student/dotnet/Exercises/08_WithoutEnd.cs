namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version without the first and last char, so "Hello" yields "ell".
        The string length will be at least 2.
        WithoutEnd("Hello") → "ell"
        WithoutEnd("java") → "av"
        WithoutEnd("coding") → "odin"
        */
        public string WithoutEnd(string str)
        {
            string newStrFirstRemoved = str.Remove(0, 1); // string that holds the string without the first char
            string newStrLastRemoved = newStrFirstRemoved.Remove(newStrFirstRemoved.Length - 1, 1); // string that holds the string without the last char
             
            return newStrLastRemoved;
            
        }
    }
}
