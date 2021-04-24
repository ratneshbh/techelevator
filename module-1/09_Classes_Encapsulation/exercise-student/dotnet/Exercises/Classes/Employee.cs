namespace Exercises.Classes
{
    public class Employee
    {
        public int EmployeeId { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; set; }

        public string FullName {    // derived property that returns "LastName, FirstName"
            get
            {
                
                //this.FirstName = firstName;

                return $"{LastName}, {FirstName}";
            }
                }

        public string Department { get; set; }

        public double AnnualSalary { get; private set; }

        public Employee(int employeeId, string firstName, string lastName, double salary) //this is the constructor - right? Test says constructor is missing 
        {
            this.EmployeeId = employeeId;          //set the properties of the Employee class here - right?
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
        }

        public void RaiseSalary (double percent)
        {
            double salary = AnnualSalary;
            
            double percentRaised;
            percentRaised = (percent * salary) / 100;
            //add percentRaised to AnnualSalary
            
            AnnualSalary = percentRaised + AnnualSalary;
            

            
        }

    }
}
