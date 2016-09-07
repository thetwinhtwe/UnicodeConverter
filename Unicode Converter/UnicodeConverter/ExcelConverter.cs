using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office;
using Excel = Microsoft.Office.Interop.Excel;

//using ExcelCtrl = Microsoft.Office.Tools.Excel;

namespace UnicodeConverter
{
    class ExcelConverter
    {
        public static void Convert(Excel.Application excelApp)
        {
            object misValue = System.Reflection.Missing.Value;
            Excel.Range usedRange;
            Excel.Range currentCell;
            Excel.Workbook aWorkbook = (Excel.Workbook)excelApp.ActiveWorkbook;
            //Excel.Worksheet activeWorkSheet = (Excel.Worksheet)aWorkbook.ActiveSheet;
            int sheetCount = aWorkbook.Sheets.Count;
            //System.Windows.Forms.MessageBox.Show("sheet count::" + sheetCount);
           
            for (int sheetNo = 1; sheetNo <= sheetCount; sheetNo++)
            {
                Excel.Worksheet currentWorkSheet;
                try
                {
                    currentWorkSheet = (Excel.Worksheet)aWorkbook.Sheets[sheetNo];
                    currentWorkSheet.Activate();
                    currentWorkSheet.Application.Cells.Activate();
                    usedRange = currentWorkSheet.UsedRange;

                    // get the total row and column count of used Range
                    int totalRows = usedRange.Rows.Count;
                    int totalColumns = usedRange.Columns.Count;

                    for (int i = 1; i <= totalRows; i++)
                    {
                        for (int j = 1; j <= totalColumns; j++)
                        {
                            //currentWorkSheet.
                            //ExcelCtrl.AddNamedRange();
                            currentCell = ((Excel.Range)usedRange.Cells[i, j]);
                            //Console.WriteLine("detecting...0" + currentCell.Text);
                            UnicodeConverter.Converter.ConvertOption option = detectFont(currentCell);
                            //Console.WriteLine("detecting...finished   " + currentCell.Text + "   " + option);
                            if (currentCell != null && option != UnicodeConverter.Converter.ConvertOption.OTHER)
                            {
                                //Console.WriteLine("converting...0");
                                Object currentCellData = currentCell.Text;
                                if (currentCellData != null && ((string)currentCell.Text) != "")
                                {
                                    //Console.WriteLine("converting...inner not empty if");
                                    string srcTxt = (string)currentCell.Text;
                                    //Console.WriteLine("converting...getting data" + srcTxt + "   its formula:: " + currentCell.Formula.ToString());
                                    string uniTxt = UnicodeConverter.Converter.Convert(srcTxt, option);      
                                    currentCell.Value2 = uniTxt + "";                                    
                                    //Console.WriteLine("converting...finished" + uniTxt);
                                    //Console.WriteLine("converting...replaced");
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
                    Console.WriteLine("ExcelConverter.Convert() Error :--> " + e.Message);
                    continue;
                }
                // set "Myanmar3"to default sript name
                //Console.WriteLine("Code reach end of line!");
                usedRange.Font.Name = "Myanmar3";
            }
            //activeWorkSheet.Application.Cells.Activate();
            ((Excel.Worksheet)aWorkbook.Sheets[1]).Activate();
           
        }// end of Convert()

        private static Converter.ConvertOption detectFont(Excel.Range currentCell)
        {
            UnicodeConverter.Converter.ConvertOption option;
            try
            {
                if (currentCell.Font.Name != System.DBNull.Value && !currentCell.Formula.ToString().StartsWith("="))
                {
                    String fontName = (String)currentCell.Font.Name;
                    if(fontName.Contains("Academy"))
                    {
                        option =UnicodeConverter .Converter .ConvertOption .Academy2Uni ;
                    }
                    else if (fontName.Contains("Amyanmar"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Amyanmar2Uni;
                    }
                    //else if (fontName.Contains("A_Type Writer"))
                    //{
                    //    option = UnicodeConverter.Converter.ConvertOption.ATypeWriter2Uni;
                    //}
                    else if (fontName.Contains("Avaforever"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Ava2Uni;
                    }
                    else if (fontName.Contains("Ayar"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Ayar2Uni;
                    }
                    else if (fontName.Contains("CE"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.CE2Uni;  //edit
                        //option = UniConversion.Converter.ConvertOption.Win2Uni;
                    }
                    //else if (fontName.Substring(0,2).Equals("CE"))    
                    //{
                    //    option = UniConversion.Converter.ConvertOption.CE2Uni;  //edit
                    //    Console.WriteLine("Fontname  :"+fontName);
                    //}
                    else if (fontName == "I")
                    {
                        option = UnicodeConverter.Converter.ConvertOption.I2Uni;
                    }
                    else if (fontName == "A_Type Writer")
                    {
                        option = UnicodeConverter.Converter.ConvertOption.ATypeWriter2Uni;
                    }
                    else if(fontName.Contains("Metrix"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Metrix2Uni;
                    }
                    else if ( fontName.Contains("Gandamar")|| fontName == "Gandamar-Letter1" || fontName == "Gandamar-WhiteBold"|| fontName == "Gandamar-HeadLine1"|| fontName == "Gandamar-Handwriting"|| fontName == "Gandamar-Bold"||fontName == "Gandamar-Letter2" || fontName == "Gandamar-Letter3" || fontName == "Gandamar-Royal" || fontName == "Gandamar-Square1" || fontName == "Gandamar-VerticalBold2")
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Gandamar2Uni;
                    }
                    else if (fontName == "Metrix-1"|| fontName.Contains("Metrix"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Metrix2Uni;
                    }
                    else if (fontName.Contains("M-Myanmar"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.MMyanmar2Uni;
                    }
                    else if (fontName == "Myanmar1")
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Myanmar12Uni;
                    }
                    else if (fontName == "MyaZedi")
                    {
                        option = UnicodeConverter.Converter.ConvertOption.MyaZedi2Uni;
                    }
                    else if (fontName.Contains("Pinny"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Pinny52Uni;
                    }
                    else if (fontName.Contains("Win") || fontName.Contains("Win---Researcher") || fontName.Contains("WinInnwa"))
                    {
                        //Console.WriteLine("Current cell data: " + currentCell.Text);
                        option = UnicodeConverter.Converter.ConvertOption.Win2Uni;
                    }
                    else if (fontName.Contains("Zawgyi"))
                    {
                        option = UnicodeConverter.Converter.ConvertOption.Zawgyi2Uni;
                    }
                    else
                    {
                        option = UnicodeConverter.Converter.ConvertOption.OTHER;
                    }
                }
                else
                {
                    if (currentCell.Font.Name == System.DBNull.Value)
                    {
                        //Microsoft.Office.Tools.Excel.NamedRange
                        //currentCell.Application.
                        //NameRange 
                    }
                    //Console.WriteLine("current cell formula::: " + currentCell.Formula.ToString());
                    option = UnicodeConverter.Converter.ConvertOption.OTHER;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ExcelConverter.DetectFont() Error :-> " + e.Message);
                option = UnicodeConverter.Converter.ConvertOption.OTHER;
            }
            return option;
            
        }

    }
}
