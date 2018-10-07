using System;
using System.Data;
using System.IO;
using System.Linq;

namespace test
{
    class Program
    {
        static string fullPath = "d:\\temp\\person100.csv";
        static DataTable myTable;

        static void Main(string[] args)
        {
            ReadCsv();
            PrintColumnNames(myTable);
            PrintTable();
        }
        static void ReadCsv()
        {
            using (StreamReader sr = new StreamReader(fullPath))
            {
                myTable = new DataTable();
                string[] headers = sr.ReadLine().Split(',');
                for (int i = 0; i < headers.Count(); i++)
                {
                    myTable.Columns.Add();
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = myTable.NewRow();
                    for (int i = 0; i < rows.Count(); i++)
                    {
                        dr[i] = rows[i];
                    }
                    myTable.Rows.Add(dr);
                }
            }
        }
        static void PrintTable()
        {
            foreach (DataRow dataRow in myTable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + ",");
                }
                Console.WriteLine();
            }
        }
        static void PrintColumnNames(DataTable table)
        {
            foreach (DataColumn column in table.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }
        }
    }
}


