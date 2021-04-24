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
            int highestNumber = randomNumbers[0]; //create integer variable that holds max value
            int currentValue = 0;
            for (int i = 1; i < randomNumbers.Length; i++) //loops through all the values in the array starting with 0
            {
                currentValue = randomNumbers[i];

                if (currentValue > highestNumber)
                {
                    highestNumber = currentValue; // greatest number is equal to Max so that's what we make Max equal to    
                }
                return highestNumber;
            }
        }
    }
}
