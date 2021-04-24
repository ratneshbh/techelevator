namespace Lecture
{
    public partial class LectureExample
    {
        /*
        15. Now, do it again with a different bool opeation.
        TOPIC: Logical Not !
        */
        public string ReturnAdultOrMinorAgain(int number)
        {

            string output = "Adult";
            //(number > 4) && (number < 19)


            if (  !(number >= 18) )
            {
                output = "Minor";
            }

            return output;
        }
    }
}
