﻿using BusinessLogic;
using Persistence.CRUD;
using System;
using System.Data;
using System.Windows.Forms;
using UI.UserControls;

namespace UI
{
    public partial class CustomerUserControl : UserControl
    {
        public CustomerUserControl()
        {
            InitializeComponent();

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var CustomerAddPopUp = new AddPopUp(true);
            CustomerAddPopUp.Show();
        }

        private void ButtonShowAllCustomers_Click(object sender, EventArgs e)
        {

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
            setUpDefaultDataTableCustomers();
            AddButtonColumn("Notes");
            AddButtonColumn("Edit");
            AddButtonColumn("Delete");
        }

        private void setUpDefaultDataTableCustomers()
        {
            dataGridViewCustomerUserControl.DataSource = Reader.GetCustomersDataTable();

        }

        private void PrintCustomersButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameOnFile.Text))
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
            if (e.ColumnIndex == dataGridViewCustomerUserControl.Columns["Notes"].Index && e.RowIndex >= 0)
            {
                string clickedCellNotes = Reader.LoadCustomersDataTable().Rows[e.RowIndex].Field<string>("Notes") ;
                var NotesPopUp = new PopUpDataGridViewChanges(true, clickedCellNotes);
                NotesPopUp.Show();

            }

            else if (e.ColumnIndex == dataGridViewCustomerUserControl.Columns["Edit"].Index && e.RowIndex >= 0)
            {

                var Customerstable = Reader.LoadCustomersDataTable();
                int customerID = Customerstable.Rows[e.RowIndex].Field<int>("CustomerID");
                string forename = Customerstable.Rows[e.RowIndex].Field<string>("Forename") ;
                string surname = Customerstable.Rows[e.RowIndex].Field<string>("Lastname");
                string address = Customerstable.Rows[e.RowIndex].Field<string>("Adress");
                int phonenumber = Customerstable.Rows[e.RowIndex].Field<int>("PhoneNumber");
                string email = Customerstable.Rows[e.RowIndex].Field<string>("Email");
                float strenghtRight = Customerstable.Rows[e.RowIndex].Field<float>("StrengthRight");
                float strenghtLeft = Customerstable.Rows[e.RowIndex].Field<float>("StrengthLeft");
                string notes = Customerstable.Rows[e.RowIndex].Field<string>("Notes");
                DateTime signupDate = Customerstable.Rows[e.RowIndex].Field<DateTime>("SignupDate");

                //string email, string strenghtleft, string strenghtright, string notes
                var EditPopUp = new PopUpDataGridViewChanges(false,customerID, forename,surname,address,phonenumber,email,strenghtLeft,strenghtRight,notes,signupDate);
                EditPopUp.Show();


            }
            else if (e.ColumnIndex == dataGridViewCustomerUserControl.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Delete customer?", "Customer deletion", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int clickedCellID = Reader.LoadCustomersDataTable().Rows[e.RowIndex].Field<int>("CustomerID");
                    Deleter.DeleteCustomer(clickedCellID);
                    MessageBox.Show("User deleted!");
                    setUpDefaultDataTableCustomers();

                }

            }
        }

        private void ResetfiltersButtonCustomers_Click(object sender, EventArgs e)
        {

            setUpDefaultDataTableCustomers();
            SeachTextBoxCustomerUserControl.Text = "";

        }

        private void SeachTextBoxCustomerUserControl_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCustomerUserControl.DataSource = Filter.SearchBar(Reader.GetCustomersDataTable(), SeachTextBoxCustomerUserControl.Text);
        }

    }
}
