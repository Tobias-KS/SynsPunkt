using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistence.CRUD;
using Persistence.Models;

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

        private void SortButtonCustomers_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCustomerUserControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerUserControl_Load(object sender, EventArgs e)
        {

            var result = Reader.GetCustomersDataTable().Rows
                .Cast<DataRow>()
                .Where(c => c.Field<string>("Forename") == "Homer");

            dataGridViewCustomerUserControl.DataSource = result.CopyToDataTable<DataRow>();

        }

        
    }
}
