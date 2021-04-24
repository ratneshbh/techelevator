﻿namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        5a. Sometimes we don't know how large the array is that we're given.
            Return the last element of the array from the parameter
            TOPIC: Accessing Array Elements
        */
        public int ReturnLastElementOfParam(int[] passedInArray)
        {
            int arrayLength = passedInArray.Length -1;
            int lastElement = passedInArray[arrayLength];
            return lastElement;
        }

        /*
        5b. Return the second to last element of the array from the parameters
            TOPIC: Accessing Array Elements
        */
        public int ReturnSecondToLastElementOfParam(int[] passedInArray)
        {
            int arrayLength = passedInArray.Length - 2;
            int lastElement = passedInArray[arrayLength];
            return lastElement;
        }

        /*
        5c. Set the last element in the array to 100.
            TOPIC: Setting Array Elements
        */
        public void SetLastElement(int[] passedInArray)
        {
            int indexOfLastElement = passedInArray.Length - 1;
            passedInArray[indexOfLastElement] = 100;
            return;//optional!
        }
    }
}
