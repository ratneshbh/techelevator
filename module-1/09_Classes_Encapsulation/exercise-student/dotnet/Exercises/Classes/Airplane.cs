namespace Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; private set; }
        
        public int TotalFirstClassSeats  //property giving access to private field
        { get; private set; }
           
        

        
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats) 
        {
            if (forFirstClass == true)
            {
                BookedFirstClassSeats += totalNumberOfSeats;

            }
            else if (forFirstClass == false)
            {
                BookedCoachSeats += totalNumberOfSeats;

            }
            if (totalNumberOfSeats >= BookedFirstClassSeats + BookedCoachSeats)
            {
                return true;
            }
            return false;
            
        }

        
        public int BookedFirstClassSeats
            { get; private set; }
        

     


    public int AvailableFirstClassSeats  //derived property - you can use properties directly - no need to use variables 
    {
        get
        {
            return TotalFirstClassSeats - BookedFirstClassSeats;
        }

    }
    //totalFirstClassSeats - bookedFirstClassSeats; }   // derived property



    public int TotalCoachSeats { get; private set; }

    public int BookedCoachSeats { get; private set; }

  
    public int AvailableCoachSeats
        {
            get
            {
                
                return TotalCoachSeats - BookedCoachSeats;
            }
        }
        

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats) 
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        
        }

       
    }
}
