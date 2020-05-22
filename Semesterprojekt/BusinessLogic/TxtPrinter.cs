using System;
using System.Data;
using System.IO;

namespace BusinessLogic
{
    public class TxtPrinter
    {
        public static void WriteToTxt(string fileName, DataTable dataTable)
        {
            using (StreamWriter sw =
                File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                $"/{fileName}.txt"))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    object[] array = row.ItemArray;

                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        sw.Write(array[i] + " -- ");

                    }

                    sw.WriteLine(array[array.Length - 1].ToString());
                }
            }


        }
    }
}