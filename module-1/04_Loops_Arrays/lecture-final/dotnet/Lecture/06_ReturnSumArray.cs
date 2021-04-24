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
            int sum = 0;                //0 1  2  3
            int[] arrayToLoopThrough = { 3, 4, 2, 9 };
            
                //init       boolean expression             iterator
            for (int i = 0; i < arrayToLoopThrough.Length; i++ )
            {
                        //reference the value of the element at this index
                sum += arrayToLoopThrough[i]; 
            }

            return sum;
        }
    }
}
