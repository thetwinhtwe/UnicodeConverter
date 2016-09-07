using System;
using System.Collections.Generic;
using System.Text;

namespace UnicodeConverter
{
    class Logging
    {
        public static String logger;

        public static void WriteLog()
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("C://log.txt");
            sw.WriteLine(logger);
            sw.Close();
        }

    }
}
