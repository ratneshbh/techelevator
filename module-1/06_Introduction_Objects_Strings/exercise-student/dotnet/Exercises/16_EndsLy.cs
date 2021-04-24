namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if it ends in "ly".
        EndsLy("oddly") → true
        EndsLy("y") → false
        EndsLy("oddy") → false

       
        */
        public bool EndsLy(string str)
        {
            bool hasLyInIt = false; //string to hold method variable; 
            //str.Substring(str.Length - 2, 2); // generates substring "ly" for string.length >= 2

           if (str.Length >= 2 && str.Substring(str.Length - 2, 2) == "ly")  //checks whether the last 2 characters of given string str are "ly"
            {
                hasLyInIt = true;
            }
            return hasLyInIt;
           
        }
    }
}
