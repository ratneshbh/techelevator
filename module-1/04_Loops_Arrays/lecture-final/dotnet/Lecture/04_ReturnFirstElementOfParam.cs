namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        4a. Return the first element of the array from the parameters
            TOPIC: Accessing Array Elements
        */
        public int ReturnFirstElementOfParam(int[] passedInArray)
        {
            int firstElement = passedInArray[0];
            return firstElement;
        }

        /*
        4b. Set the first element in the array to 100.
            TOPIC: Setting Array Elements
        */
        //return type is void, returns nothing - parameter is passedInArray
        public void SetFirstElement(int[] passedInArray)
        {

            passedInArray[0] = 100;
            return; //optional because void return type

        }
    }
}
