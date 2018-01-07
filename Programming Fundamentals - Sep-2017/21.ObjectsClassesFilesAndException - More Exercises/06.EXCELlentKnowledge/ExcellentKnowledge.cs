using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace EXCELlentKnowledge
{
    class ExcellentKnowledge
    {

        static void Main()
        {
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\raiders\Documents\Visual Studio 2015\Projects\Sep2017-ObjectsClassesFilesAndExcep-More\EXCELlentKnowledge\sample_table.xlsx");
            Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            File.WriteAllText(@"..\\..\\output.txt", string.Empty);
            for (int i = 1; i <= 5; i++)
            {
                string result = string.Empty;
                for (int j = 1; j <= 5; j++)
                {
                    result += $"{xlRange.Cells[i, j].Value + "|"}";
                }
                File.AppendAllText(@"..\\..\\output.txt", result + Environment.NewLine);
            }
        }
    }
}
