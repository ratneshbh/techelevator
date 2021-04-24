namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string length 1 from its front, unless front is false, in which case
        return a string length 1 from its back. The string will be non-empty.
        TheEnd("Hello", true) → "H"
        TheEnd("Hello", false) → "o"
        TheEnd("oh", true) → "o"
        */
        public string TheEnd(string str, bool front)
        {


            if (front == true)
            {
                string stringFront;
                stringFront = str.Substring(0, 1);
                return stringFront;
            }
            else if (front == false)
            {
                string stringBack;
                stringBack = str.Substring(str.Length - 1, 1);
                return stringBack;
            }
            else
            {
                return null;
            }
        }
    }
}
