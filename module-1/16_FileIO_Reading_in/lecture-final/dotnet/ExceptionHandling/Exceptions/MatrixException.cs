using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling.Exceptions
{
    class MatrixException : Exception
    {

        public MatrixException() : base("Error with Matrix")
        {
            Console.WriteLine("There was only one good Matrix movie, the rest are trash");
        }

        public MatrixException(string customError) : base(customError)
        {
            
        }
    }
}
