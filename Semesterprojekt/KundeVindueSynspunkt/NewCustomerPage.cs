using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundeVindueSynspunkt
{
    public partial class NewCustomerPage : UserControl
    {

        public NewCustomerPage()
        {
            InitializeComponent();
        }

        private void NewCustomerButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
