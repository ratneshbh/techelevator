namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        3. Return the last element of the array
            TOPIC: Accessing Array Elements
        */
        public int ReturnLastElement()
        {
            int[] portNumbers = { 80, 8080, 443 };

            int portNumbersLengthIndex = portNumbers.Length - 1;
            int lastElement = portNumbers[portNumbersLengthIndex]; // this approach enables you to work with arrays of different lengths rather than the other approach that passes the test
            
            return lastElement;
        }
    }
}
//best practice is to use this approach to save it into a variable 