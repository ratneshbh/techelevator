namespace Lecture
{
    public partial class LectureExample
    {
        /*
        10.This method will take a number and do the following things to it:
            If addThree is true, we'll add three to that number
            If addFive is true, we'll add five to that number
            We'll then return the result
            TOPIC: Stacking Conditional Logic
        */
        public int ReturnNumberAfterAddThreeAndAddFive(int number, bool addThree, bool addFive)
        {

            int output = number;

            if (addThree)
            {
                //output = output + 3
                output += 3;
            } 

            // Why can't we use an else here?

            if (addFive)
            {
                output += 5;
            }

            return output;
        }
    }
}
