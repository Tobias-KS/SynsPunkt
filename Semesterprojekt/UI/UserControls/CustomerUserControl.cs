using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistence.CRUD;

namespace UI
{
    public partial class CustomerUserControl : UserControl
    {
        public CustomerUserControl()
        {
            InitializeComponent();
        }

        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SortByDropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var CustomerAddPopUp = new AddPopUp(true);
            CustomerAddPopUp.Show();
        }

        private void ButtonShowAllCustomers_Click(object sender, EventArgs e)
        {


        }
    }
}
