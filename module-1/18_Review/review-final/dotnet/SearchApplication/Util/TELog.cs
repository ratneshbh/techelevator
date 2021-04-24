using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SearchApplication.Util
{
    class TELog
    {
        static string logLocation = "logs/search.log";

        public static void Log(string message)
        {
            try
            {

                using(StreamWriter sw = new StreamWriter(logLocation, true))
                {
                    sw.Write(message);
                }

            }
            catch (Exception e)
            {

                throw new TELogException("idk how to log if the log is broken?", e);
            }
        }
    }
}
