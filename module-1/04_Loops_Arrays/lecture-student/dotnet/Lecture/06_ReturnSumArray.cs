namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        6. How can we write a for loop that sums up the values in this array?
           TOPIC: For Loops
        */
        public int ReturnSumArray()
        {
            int sum = 0;  //0 1 2 3 
            int[] arrayToLoopThrough = { 3, 4, 2, 9 };
                  //init     boolean expression                i++ is same as i = i + 1 --> this is called the iterator
            for (int i = 0; i < arrayToLoopThrough.Length; i++)
            {
                sum = sum + arrayToLoopThrough[i]; //referencing the value at the index here at i; arrayToLoopThrough is an expression that evaluates to a number
            }

            return sum;
        }
    }
}
