namespace Exercises
{
    public class FrontTimes
    {
        /*
        Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
        whatever is there if the string is less than length 3. Return n copies of the front;
        frontTimes("Chocolate", 2) → "ChoCho"
        frontTimes("Chocolate", 3) → "ChoChoCho"
        frontTimes("Abc", 3) → "AbcAbcAbc"

        //[TestMethod]
        //FrontTimes frontTimes = new FrontTimes(); 
        //string actual = frontTimes.GenerateString("Chocolate", 2);
        //Assert.AreEqual("ChoCho", actual); 

        //FrontTimes frontTimes2 = new FrontTimes(); 
        //string actual = frontTimes2.GenerateString("Chocolate", 3);
        //Assert.AreEqual("ChoChoCho", actual); 

        //FrontTimes frontTimes3 = new FrontTimes(); 
        //string actual = frontTimes3.GenerateString("Abc", 3);
        //Assert.AreEqual("AbcAbcAbc", actual); 
        */
        public string GenerateString(string str, int n)
        {
            string result = "";
            if (str.Length <= 3)
            {
                for (int i = 0; i < n; i++)
                {
                    result += str;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    result += str.Substring(0, 3);
                }
            }
            return result;
        }
    }
}
