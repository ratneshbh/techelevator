namespace Lecture
{
    public partial class LectureExample
    {
        /*
          8.This method checks a parameter passed to the method to see if it's
            greater than 5 and returns true if it is.
            TOPIC: Comparison Operators & Conditional Logic
        */
        // bool                                // 1 parameter
        public bool ReturnTrueWhenGreaterThanFive(int number)
        {

            bool result;
            
            if (number > 5)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
