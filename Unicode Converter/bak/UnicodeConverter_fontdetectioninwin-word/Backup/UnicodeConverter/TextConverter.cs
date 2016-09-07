using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UnicodeConverter
{
    class TextConverter
    {

        public static void Convert(string desFile, UniConversion.Converter.ConvertOption convertOption)
        {
            string desTxt = UniConversion.Converter.Convert(readTxtFile(desFile), convertOption);
            writeTxtFile(desTxt, desFile);
            openTxtFile(desFile);
        }

        public static string readTxtFile(string fileName)
        {            
            StreamReader sr = new StreamReader(fileName);
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
            //string str = "";
            //while (!sr.EndOfStream)
            //{
            //    str += sr.ReadLine();
            //}
            //return str;
        }

        public static void writeTxtFile(string str2Write, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(str2Write);
            sw.Close();
        }

        public static void openTxtFile(string fileName)
        {
            System.Diagnostics.Process openingTxtFile = new System.Diagnostics.Process();
            openingTxtFile.StartInfo.FileName = fileName;
            openingTxtFile.Start();
        }
    }
}
