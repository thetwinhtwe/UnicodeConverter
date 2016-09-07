using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace UnicodeConverter
{
    class ExcelConverter
    {
        public static void Convert(Excel.Application excelApp, UniConversion.Converter.ConvertOption option)
        {
            Excel.Range usedRange;
            Excel.Range currentCell;
            Excel.Workbook aWorkbook = (Excel.Workbook)excelApp.ActiveWorkbook;
            Excel.Worksheet activeWorkSheet = (Excel.Worksheet)aWorkbook.ActiveSheet;
            int sheetCount = aWorkbook.Sheets.Count;
            //System.Windows.Forms.MessageBox.Show("sheet count::" + sheetCount);

            for (int sheetNo = 1; sheetNo <= sheetCount; sheetNo++)
            {
                Excel.Worksheet currentWorkSheet = (Excel.Worksheet)aWorkbook.Sheets[sheetNo];
                currentWorkSheet.Application.Cells.Activate();
                usedRange = currentWorkSheet.UsedRange;

                // get the total row and column count of used Range
                int totalRows = usedRange.Rows.Count;
                int totalColumns = usedRange.Columns.Count;
                //System.Windows.Forms.MessageBox.Show(totalRows + " , " + totalColumns);
                try
                {
                    for (int i = 1; i < totalRows; i++)
                    {
                        for (int j = 1; j < totalColumns; j++)
                        {
                            currentCell = ((Excel.Range)usedRange.Cells[i, j]);
                            if (currentCell != null)
                            {
                                //System.Windows.Forms.MessageBox.Show("converting....0");
                                if (((string)currentCell.Text) != "")
                                {
                                    string srcTxt = (string)currentCell.Text;
                                    //Console.WriteLine("Row: " + i + " is converting:2");
                                    string uniTxt = UniConversion.Converter.Convert(srcTxt, option);
                                    //Console.WriteLine("Row: " + i + " is converting:3");
                                    currentCell.Value2 = uniTxt;
                                    //currentCell.Font.Name = "Myanmar3";
                                }
                                //else
                                //{
                                //    currentCell.Value2 = "*";
                                //}
                            }
                        }
                        //Console.WriteLine("Row: " + i + " is finished converting!");
                    } // end of outer-for
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error is:::::::" + e.Message);
                    continue;
                }

                // set "Myanmar3"to default sript name
                //Console.WriteLine("Code reach end of line!");
                usedRange.Font.Name = "Myanmar3";
            }
            activeWorkSheet.Application.Cells.Activate();

        }// end of Convert()

    }
}
