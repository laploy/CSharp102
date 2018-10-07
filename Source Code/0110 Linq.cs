using System;
using System.IO;
using System.Data;
using System.Linq;

namespace test
{
    class Program
    {
        static string fullPath = "d:\\temp\\person100a.csv";
        static DataTable myTable;

        static void Main(string[] args)
        {
            ReadCsv();
            // find person who age > 30
            var q = (from v in myTable.AsEnumerable()
                     where v.Field<int>("Age") > 30
                     && v.Field<string>("Gender") == "F"
                     select v);
            foreach(DataRow r in q)
                Console.WriteLine(r["Name"]);
        }
        static void SetColumn(DataTable table)
        {
            table.Columns[0].ColumnName = "Name";
            table.Columns[1].ColumnName = "Age";
            table.Columns[1].DataType = System.Type.GetType("System.Int32");
            table.Columns[2].ColumnName = "Gender";
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
                SetColumn(myTable); // set column attribute
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
    }
}

