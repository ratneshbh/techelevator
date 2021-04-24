﻿using SearchApplication.Search;
using SearchApplication.Util;
using System;
using System.Collections.Generic;

namespace SearchApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Step Two: Create TELog, and log the start of the application.
                //
                TELog.Log("Search application started");


                // Step Four: Instantiate a Search Domain
                //
                SearchDomain sd = new SearchDomain("data");
                TELog.Log("Indexed files:\n" + sd.ToString());

                // Step Six: Single word search
                //



                // Step Seven: Multiple word search
                //



            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception occurred:\n" + ex.StackTrace);
            }
        }
    }
}
