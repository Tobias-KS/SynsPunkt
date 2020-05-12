using System;
using System.Collections.Generic;
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
            OpenPdfFil("SynsPunktSupport.pdf.pdf");
        }
        

    }
}
