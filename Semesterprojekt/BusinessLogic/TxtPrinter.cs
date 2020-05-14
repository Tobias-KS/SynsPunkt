using System;
using System.Data;
using System.IO;

namespace BusinessLogic
{
    public class TxtPrinter
    {
        public static void TxtPrintMethod(string m)
        {

            string txt_path = AppDomain.CurrentDomain.BaseDirectory + $"//BusinessLogicResources//TxtFiles//{m}.txt";


            using (StreamWriter w = new StreamWriter(txt_path))
            {
              
            }


        }

    }
}
    