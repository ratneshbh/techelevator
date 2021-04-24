namespace Exercises
{
    public class Lucky13
    {
        /*
        Given an array of ints, return true if the array contains no 1's and no 3's.
        GetLucky([0, 2, 4]) → true
        GetLucky([1, 2, 3]) → false
        GetLucky([1, 2, 4]) → false

        //int[] Lucky13 = new int[3];  //probably need to instantiate array object - int[] array1 = new int[]
            //bool actual = Lucky13.GetLucky[0, 2, 4]; 
            //Assert.AreEqual(true, actual);
        
        */
        public bool GetLucky(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1 || nums[i] == 3)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
