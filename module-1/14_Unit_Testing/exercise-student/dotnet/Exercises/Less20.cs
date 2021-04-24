namespace Exercises
{
    public class Less20
    {
        /*
        Return true if the given non-negative number is 1 or 2 less than a multiple of 20. So for example 38
        and 39 return true, but 40 returns false.
        (Hint: Think "mod".)
        less20(18) → true
        less20(19) → true
        less20(20) → false

            //Less20 less20 = new Less20; 
            //bool actual = less20.IsLessThanMultipleOf20(18);
            //Assert.AreEqual(true, actual); 

            //Less20 less20two = new Less20;
            // bool actual = less20two.IsLessThanMultipleOf20(19);
            // Assert.AreEqual(true, actual); 

            // Less20 less20three = new Less20; 
            // bool actual = less20three.IsLessThanMultipleOf20(20);
            // Assert.AreEqual(false, actual); 

        
        */
        public bool IsLessThanMultipleOf20(int n)
        {
            bool oneLessThanMultipleOf20 = (n % 20 == 19);
            bool twoLessThanMultipleOf20 = (n % 20 == 18);

            return oneLessThanMultipleOf20 || twoLessThanMultipleOf20;
        }
    }
}
