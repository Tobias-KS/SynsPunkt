using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UI
{
    public partial class ProductsUserControl : UserControl
    {
        public ProductsUserControl()
        {
            InitializeComponent();
        }

        private void PrintButtonProducts_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameOfFileProductsUserContolPrint.Text))
            {
                MessageBox.Show("Enter a filename before you print");

            }
            else
            {
                //Print metode her

            }
        }
        
    }
}
