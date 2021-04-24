using ExceptionHandling.Exceptions;
using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {

        //global variable
        //not encapsulated
        static List<string> matrixMoview = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //handling run time exception
            try
            {
                //CouldCauseProblems();
                //1 never gets run if error
                //2
                //3
                //4

            } 
            
            catch ( DivideByZeroException dBZ)
            {
                Console.WriteLine("no no");
            }
            catch( IndexOutOfRangeException iOORE)
            {
                Console.WriteLine("Index was too high, pick a smaller number");
            }
            catch (Exception e)
            {
                //log the error to database
                // Console.WriteLine(e.Message);
                //handle any errors

                Console.WriteLine("Couldnt process at this time, please try again");
            }

            finally
            {
                //this get executed
                //closing files, undo action
            }
            //running


            try
            {
                AddToList("The Matrix Revolutions");
                
            } catch (Exception e)
            {

               // Console.WriteLine(e.Message);
            }
            AddToList("The Matrix");
            Console.WriteLine("Program Finished");

        } 

        static void AddToList(string movie)
        {

            if(movie != "The Matrix")
            {
                throw new MatrixException();
            }

            matrixMoview.Add(movie);

        }

        static void CouldCauseProblems()
        {

            int[] array = { 1, 0, 3 };
            //Console.WriteLine(array[4]);
            Console.WriteLine(10 / array[1]);
        }
    }
}
