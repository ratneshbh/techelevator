namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version without both the first and last char of the string. The string
        may be any length, including 0.
        WithoutEnd2("Hello") → "ell"
        WithoutEnd2("abc") → "b"
        WithoutEnd2("ab") → ""
        */
        public string WithoutEnd2(string str)
        {
            if (str.Length == 0)  //edge case if length is 0 then isn't a blank space returned?
            {
                return "";
            }
            else if (str.Length == 1)
            {
                return "";
            }
            else  // string variable for a larger length 
            {
                string withoutFirstAndLastChar;
                withoutFirstAndLastChar = str.Substring(1, str.Length - 2);
                return withoutFirstAndLastChar;
            }
            
        }
    }
}
