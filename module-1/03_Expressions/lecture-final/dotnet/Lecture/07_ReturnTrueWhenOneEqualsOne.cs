namespace Lecture
{
    public partial class LectureExample
    {
        /*
        7. This method uses an if to check to make sure that one is equal to one.
            Make sure it returns TRUE when one equals one.
            TOPIC: Boolean Expression & Conditional Logic
        */
        public bool ReturnTrueWhenOneEqualsOne()
        {
            bool output = false;
            
            if (1 == 1)
            {
                bool test = false;
                output = true;
            }
          
            return output;
        }
    }
}
