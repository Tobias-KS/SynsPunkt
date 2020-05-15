using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Persistence.CRUD;
using Persistence.Models;
using BusinessLogic;
using SortOrder = System.Windows.Forms.SortOrder;

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

        private void AddButtonColumn(string buttomName)
        {
            DataGridViewButtonColumn tempButton = new DataGridViewButtonColumn();
            tempButton.HeaderText = $"{buttomName}";
            tempButton.Name = $"{buttomName}";
            tempButton.Text = $"{buttomName}";
            tempButton.UseColumnTextForButtonValue = true;
            dataGridViewCustomerUserControl.Columns.Add(tempButton);
        }
        private void CustomerUserControl_Load(object sender, EventArgs e)
        {
            dataGridViewCustomerUserControl.DataSource = Reader.GetCustomersDataTable();

            AddButtonColumn("Notes");
            AddButtonColumn("Edit");
            AddButtonColumn("Delete");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            dataGridViewCustomerUserControl.DataSource = Filter.SearchBar(Reader.GetCustomersDataTable(), textBox1.Text);
        }

        private void PrintCustomersButton_Click(object sender, EventArgs e)
        {
          

            if (String.IsNullOrEmpty(NameOnFile.Text))
            {
                MessageBox.Show("Enter a filename before you print");

            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dataGridViewCustomerUserControl.Columns)
                {
                    dt.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dataGridViewCustomerUserControl.Rows)
                {
                    DataRow dRow = dt.NewRow();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }

                string fileName = NameOnFile.Text;
                TxtPrinter.WriteToTxt($"{fileName}", dt);
                MessageBox.Show("Data exported");

            }

        }


        private void dataGridViewCustomerUserControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCustomerUserControl.Columns["Notes"].Index)
            {
                string clickedCellNotes = Reader.LoadCustomersDataTable().Rows[e.RowIndex].Field<string>("Notes");
                MessageBox.Show(clickedCellNotes);
            }
            else if (e.ColumnIndex == dataGridViewCustomerUserControl.Columns["Edit"].Index)
            {
                MessageBox.Show("Edit");
            }
            else if (e.ColumnIndex == dataGridViewCustomerUserControl.Columns["Delete"].Index)
            {
                MessageBox.Show("Delete");
            }
        }
    }
}
