﻿using System;
using System.Data;
using System.IO;
using System.Linq;

namespace BusinessLogic
{
    public class TxtPrinter
    {
        public static void Write(string fileName, DataTable dt, bool isOrder)
        {
            var outputFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                             $"/{fileName}.txt";

            int[] maxLengths = new int[dt.Columns.Count];

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                maxLengths[i] = dt.Columns[i].ColumnName.Length;

                foreach (DataRow row in dt.Rows)
                {
                    if (!row.IsNull(i))
                    {
                        int length = row[i].ToString().Length;

                        if (length > maxLengths[i])
                        {
                            maxLengths[i] = length;
                        }
                    }
                }
            }

            using (StreamWriter sw = File.CreateText(outputFilePath))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName.PadRight(maxLengths[i] + 2));
                }

                sw.WriteLine();

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (!row.IsNull(i))
                        {
                            sw.Write(row[i].ToString().PadRight(maxLengths[i] + 2));
                        }
                        else
                        {
                            sw.Write(new string(' ', maxLengths[i] + 2));
                        }
                    }

                    sw.WriteLine();
                }
                if (isOrder)
                {
                    var sum = dt.AsEnumerable().Sum(row => Convert.ToInt32(row.Field<string>("Price")));

                    var outputString = ($"\nSum of order prices = {sum:C}");
                    sw.WriteLine(outputString);
                }

                sw.Close();
            }
        }
    }
}