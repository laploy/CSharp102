using System;
using System.IO;
using System.Data;
using System.Linq;

namespace _0110_csv
{
    class Program
    {
        static string fullPath = "d:\\temp\\person100.csv";
        static DataTable myTable;

        static void Main(string[] args)
        {
            ReadCsv();
            PrintTable();
            PrintColumnNames(myTable);
            SetColumn(myTable);
            PrintColumnNames(myTable);
        }
        static void PrintColumnNames(DataTable table)
        {
            foreach (DataColumn column in table.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }
        }
        static void SetColumn(DataTable table)
        {
            table.Columns[0].ColumnName = "Name";
            table.Columns[1].ColumnName = "City";
            table.Columns[2].ColumnName = "State";
            table.Columns[3].ColumnName = "Country";
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
        static void AddColumn(DataTable table)
        {
            DataColumn column;
            column = new DataColumn();
            column.ColumnName = "SupplierID";
            column.DataType = System.Type.GetType("System.String");
            column.Unique = true;
            column.AutoIncrement = false;
            column.Caption = "SupplierID";
            column.ReadOnly = false;
            // Add the column to the table's columns collection.
            table.Columns.Add(column);
        }
    }
}
