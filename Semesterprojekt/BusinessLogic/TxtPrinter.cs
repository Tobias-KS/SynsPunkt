using System;
using System.Data;
using System.IO;

namespace BusinessLogic
{
    public class TxtPrinter
    {
        public static void TxtPrintMethod(string m, DataTable inputTable)
        {


           string txt_path = AppDomain.CurrentDomain.BaseDirectory + $"//BusinessLogicResources//TxtFiles//{m}.txt";

           File.Create(txt_path);

           using (StreamWriter w = new StreamWriter(txt_path))
            {
                foreach (var item in inputTable.Rows)
                {

                    w.WriteLine(item);

                }
            }


        }

    }
}
    