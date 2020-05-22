using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UI
{
    public partial class SupportUserControl : UserControl
    {
        public SupportUserControl()
        {
            InitializeComponent();
        }
        private void CustomerSupportPageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PDFOpener.SupportPdf();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PDFOpener.SupportPdf();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PDFOpener.SupportPdf();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PDFOpener.SupportPdf();
        }

        private void LinkLabelMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PDFOpener.SupportPdf();
        }
    }
}
