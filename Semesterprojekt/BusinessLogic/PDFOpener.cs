using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace BusinessLogic
{
    public class PDFOpener
    {
        public static void OpenPdfFil(string pdf)
        {
            System.Diagnostics.Process.Start(pdf);
        }

        public static void SupportPdf()
        {
            string pdf_path=
                AppDomain.CurrentDomain.BaseDirectory + "//BusinessLogicResources//PdfFiles//SynsPunktSupport.pdf";
            
            OpenPdfFil(pdf_path);
        }

       
    }
}
