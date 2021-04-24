namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int highestNumber = randomNumbers[0];
            int currentValue;

            for (int i = 1; i < randomNumbers.Length; i++)
            {

                currentValue = randomNumbers[i];

                if (currentValue > highestNumber)
                {
                    highestNumber = currentValue;
                }
            }

            return highestNumber;
        }
    }
}
