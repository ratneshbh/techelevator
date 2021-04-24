namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        // public int Hour { get; set; }
        public int EarnedMarks { get; set; }         // gets or sets total number of correct marks
        public int PossibleMarks { get; private set; } // gets the number of possible marks on the assignment

        public string SubmitterName { get; private set; } // gets or sets the submitter's name for the assignment
        // LetterGrade is a Derived Property 

        public string LetterGrade         

        {   
            
            get
            {
                double earnedPercentage;
                earnedPercentage = ((double) this.EarnedMarks / this.PossibleMarks) * 100;
                
                if (earnedPercentage >= 90)
                {
                    return "A";
                }
                else if (earnedPercentage >= 80)
                {
                    return "B";
                }
                else if (earnedPercentage >= 70)
                {
                    return "C";
                }
                else if (earnedPercentage >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
                 
            }

        }

        public string submitterName { get; private set; }  //get added to remove error; instructions specify no "get"
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
        //public int PossibleMarks { get; private set;  }
            this.PossibleMarks = possibleMarks;
            
            this.SubmitterName = submitterName;

            
        }

    }
}
