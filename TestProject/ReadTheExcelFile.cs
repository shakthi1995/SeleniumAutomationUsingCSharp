using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ReadTheExcelFile
    {
        public List<Dictionary<string, object>> ReadExcel(string fileName, string sheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            FileInfo file = new FileInfo(fileName);
            using(var package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[sheetName];

                if(workSheet == null)
                {
                    Console.Write("No Worksheet Found");
                }

                int rowCount = workSheet.Dimension.Rows;
                int colCount = workSheet.Dimension.Columns;

                List<string> columns = new List<string>();
                for(int col = 1; col <= colCount; col++)
                {
                    columns.Add(workSheet.Cells[1, col].Text);
                }

                for(int row = 2; row <= rowCount; row++)
                {
                    var rowsData = new Dictionary<string, object>();
                    
                    for(int col = 1; col <= colCount; col++)
                    {
                        rowsData[columns[col - 1]] = workSheet.Cells[row, col].Value;

                    }

                    result.Add(rowsData);
                }
            }

            return result;
        }
    }
}
