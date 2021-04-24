using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
           
            int numberOfExercises;

            numberOfExercises = 26;


            //Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
            double half;
            half = .5;
            //Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
            string name;
            name = "TechElevator";
            //Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly = 1;
            //Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage = "C#";
            //Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            decimal pi = 3.1416M;

            //OR//
            double pi = 3.1416;
            //Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            
            */
            string myNameIs = "Ratnesh Bhattacharya";
            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numberOfMouseButtons = 3;
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            double percentageOfBatteryLeft = 96.0;
            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            //% - holds the remainder//
            int difference = 121 - 27;
            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double resultOfAdding = 12.3 + 32.1; 
            /*
            12. Create a string that holds your full name.
            */
            string myFullName = "Ratnesh Bhattacharya"
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string helloName = "Hello, " + myFullName;
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            helloName = helloName + " Esquire";
            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            helloName += " Esquire";
            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string scaryMovie = "Saw" + 2;  //this will end up converting it to the string Saw2
            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            string scaryMovie = "Saw" + 2 + 0; //this will end up showing Saw20
            /*
            18. What is 4.4 divided by 2.2?
            */
            double quotient = 4.4 / 2.2;
            /*
            19. What is 5.4 divided by 2?
            */
            double nextQuotient = 5.4 / 2;
            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            //INCORRECT// double quotient3 = 5.0 / 2.0; // this outputs 2 because the numbers given were whole numbers i.e. ints
            /*
             //CORRECT// double quotientWithDoubles = 5D / 2; 
             */
            21. What is 5.0 divided by 2 ?
            */
            double quotientWithAnotherDouble = 5.0 / 2;
            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            decimal bankBalance = (decimal)1234.56; //explicit casting required here otherwise C# will default to double
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            double remainder = 5 % 2;
            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together.
                What is the result?
            */
            int three = 3;
            int billion = 1000000000;
            long largeNumber = three * (long)billion;
            /*
             *//Console.WriteLine(largeNumber) <-- this will run the above and show the output// 
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;
            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;

            // example unrelated to above - 
            double roundingError = (.1M + .2M); //M is the shorthand for decimals. Sometimes differences in numerical data are only apparent after performing mathematical operations


            Console.ReadLine();
        }
    }
}
