namespace _06.ExcellentKnowledge
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using Microsoft.Office.Interop.Excel;

    public class ExcellentKnowledge
    {
        public static void Main()
        {
            Application excelApp = new Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(@"D:\SoftUni\2.1.Tech-Module-Programming-Fundamentals\Лекции и Упражения\10. Programming-Fundamentals-Objects-Classes-Files-and-Exceptions-More-Exercises-Resources\sample_table.xlsx");
            _Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            Range excelRange = excelWorksheet.UsedRange;

            string result = string.Empty;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    //new line
                    if (j == 1 && i != 1)
                    {
                        result += "\r\n";
                    }

                    //write the value to the console
                    if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                    {
                        result += excelRange.Cells[i, j].Value2.ToString() + "|";
                    }
                }
            }

            File.WriteAllText("output.txt", result);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(excelRange);
            Marshal.ReleaseComObject(excelWorksheet);

            excelWorkbook.Close();
            Marshal.ReleaseComObject(excelWorkbook);

            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }
    }
}
