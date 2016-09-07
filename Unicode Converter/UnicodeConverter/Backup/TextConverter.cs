using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UnicodeConverter
{
    class TextConverter
    {
        public static void Convert(string desFile, UnicodeConverter.Converter.ConvertOption convertOption)
        {
            //UniConversion.Converter.ConvertOption.
            StreamReader sr = new StreamReader(desFile);
            StringBuilder resultStrBil = new StringBuilder();
            string desTxt = string.Empty;
            while((desTxt=sr.ReadLine())!=null)
            {
                resultStrBil.Append(UnicodeConverter.Converter.Convert(desTxt, convertOption)+"\r\n");
            }
            sr.Close();
            //desTxt = UnicodeConverter.Converter.Convert(readTxtFile(desFile), convertOption);
            writeTxtFile(resultStrBil, desFile);
            openTxtFile(desFile);
        }

        public static void ConvertSql(string desFile, UnicodeConverter.Converter.ConvertOption convertOption)
        {
            //UniConversion.Converter.ConvertOption.
            StreamReader sr = new StreamReader(desFile);
            StringBuilder resultStrBil = new StringBuilder();
            string desTxt = string.Empty;
            while ((desTxt = sr.ReadLine()) != null)
            {
                resultStrBil.Append(UnicodeConverter.Converter.Convert(desTxt, convertOption));
            }
            sr.Close();
            //desTxt = UnicodeConverter.Converter.Convert(readTxtFile(desFile), convertOption);
            writeTxtFile(resultStrBil, desFile);
            //openTxtFile(desFile);
        }
        public static string readTxtFile(string fileName)
        {            
            StreamReader sr = new StreamReader(fileName);
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
     
        }

        public static void writeTxtFile(StringBuilder str2Write, string fileName)
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
