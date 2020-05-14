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
using BusinessLogic;

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
            //Sort Method
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


            Filter.FilterCustomers();

        }

        private void CustomerUserControl_Load(object sender, EventArgs e)
        {

            dataGridViewCustomerUserControl.DataSource = Reader.GetCustomersDataTable();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            dataGridViewCustomerUserControl.DataSource = Filter.SearchBar(Reader.GetCustomersDataTable(), textBox1.Text);
        }

        private void PrintCustomersButton_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)(dataGridViewCustomerUserControl.DataSource);
            TxtPrinter.TxtPrintMethod("Test", data);
        }
    }
}
