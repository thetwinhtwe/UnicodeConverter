using System;
using System.Collections.Generic;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace UnicodeConverter
{
    class Conversion
    {
        public static bool Convert(string srcFile, string desFile,
            UniConversion.Converter.ConvertOption convertOption)
        {
            bool success = false;

            string fileType = srcFile.Substring(srcFile.LastIndexOf('.'));
            
            try
            {
                switch (fileType)
                {
                    case ".txt": TextConverter.Convert(desFile, convertOption);
                        success = true;
                        break;
                    case ".xml": XMLConverter.Convert(desFile, convertOption);                        
                        success = true;
                        break;
                    case ".xls": ExcelConverter.Convert(openExcel(desFile), convertOption);
                        excelApp.ActiveWorkbook.Save();
                        success = true;
                        break;
                    case ".doc": WordConverter.Convert("TempXml.xml", convertOption);
                       
                        //wordApp.ActiveDocument.Save();
                        success = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            return success;
        }

        private static Excel.Application openExcel(string excelFilePath)
        {
            excelApp = new Excel.ApplicationClass();
            excelApp.Visible = true;
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(excelFilePath,
                0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
                true, false, 0, true, false, false);

            return excelWorkbook.Application;
        }

        private static Word.Application openWord(Object wordFilePath)
        {
            Object missing = System.Reflection.Missing.Value;
            wordApp = new Word.ApplicationClass();
            wordApp.Visible = true;
            Word.Document wordDoc = wordApp.Documents.Open(ref wordFilePath,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);
             return wordDoc.Application;
        }

        private static Word.Application wordApp;
        private static Excel.Application excelApp;
    }
}