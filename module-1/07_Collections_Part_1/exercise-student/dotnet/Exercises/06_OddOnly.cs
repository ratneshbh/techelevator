﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of Integers, return a List of Integers containing just the odd values.
        OddOnly( {112, 201, 774, 92, 9, 83, 41872} ) -> [201, 9, 83]
        OddOnly( {1143, 555, 7, 1772, 9953, 643} ) -> [1143, 555, 7, 9953, 643]
        OddOnly( {734, 233, 782, 811, 3, 9999} ) -> [233, 811, 3, 9999]
        */
        public List<int> OddOnly(int[] integerArray)
        {
            List<int> outputList = new List<int>();//create a new list
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (!(integerArray[i] % 2 == 0))                          //need an if statement here because condition of certain values in list
                {
                    outputList.Add(integerArray[i]); 
                }
            }// iterate through the array of integers using a for loop 
            // figure out how to generate odd values of integers
            // if statement with condition that the value at iterator satisfies the odd value condition 
            // return new list 
            return outputList;
        }
    }
}
