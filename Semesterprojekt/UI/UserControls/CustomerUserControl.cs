using BusinessLogic;
using Persistence.CRUD;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Persistence.Models;
using UI.UserControls;

namespace UI
{
    public partial class CustomerUserControl : UserControl
    {
        public AddPopUp customerAddPopUp { get; set; }

        public CustomerUserControl()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            customerAddPopUp = new AddPopUp(AddPopUp.WindowState.Customer);
            customerAddPopUp.FormClosed += new FormClosedEventHandler(Add_Form_Closed);
            customerAddPopUp.Show();
        }

        void Add_Form_Closed(object sender, FormClosedEventArgs e)
        {
            AddPopUp addClosed = (AddPopUp)sender;
            SetUpDefaultDataTableCustomers();
        }
        void Notes_Form_Closed(object sender, FormClosedEventArgs e)
        {
            PopUpDataGridViewChanges notesClosed = (PopUpDataGridViewChanges)sender;
            SetUpDefaultDataTableCustomers();
        }
        void Edit_Form_Closed(object sender, FormClosedEventArgs e)
        {
            PopUpDataGridViewChanges editChanges = (PopUpDataGridViewChanges)sender;
            SetUpDefaultDataTableCustomers();
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
            SetUpDefaultDataTableCustomers();
        }

        public void SetUpDefaultDataTableCustomers()
        {
            dataGridViewCustomerUserControl.DataSource = Reader.GetCustomersDataTable();
        }

        public DataTable SetupCurrentAsDataTable()
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

            return dt;
        }
        private void PrintCustomersButton_Click(object sender, EventArgs e)
        {

            string fromdate = FromDateCustomer.Text;
            string todate = ToDateCustomer.Text;

            if (string.IsNullOrEmpty(NameOnFile.Text))
            {
                MessageBox.Show("Enter a filename before you print");

            }
            else
            {
                string fileName = NameOnFile.Text;
                TxtPrinter.Write($"{fileName}", SetupCurrentAsDataTable(), fromdate:fromdate, todate:todate);
                MessageBox.Show("Data exported");
            }
        }

        private void ResetfiltersButtonCustomers_Click(object sender, EventArgs e)
        {
            SetUpDefaultDataTableCustomers();
            SeachTextBoxCustomerUserControl.Text = "";
        }

        private void SeachTextBoxCustomerUserControl_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCustomerUserControl.DataSource = Filter.SearchBar(Reader.GetCustomersDataTable(), SeachTextBoxCustomerUserControl.Text);
        }

        private void FromDateCustomer_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewCustomerUserControl.DataSource = Filter.FilterCustomers(FromDateCustomer.Text, ToDateCustomer.Text);
        }

        private void ButtonShowNotesCustomer_Click(object sender, EventArgs e)
        {
            var cell = this.dataGridViewCustomerUserControl.SelectedCells[0];

            string clickedCellNotes = Reader.LoadCustomersDataTable().Rows[cell.RowIndex].Field<string>("Notes");
            var NotesPopUp = new PopUpDataGridViewChanges(true, clickedCellNotes);
            NotesPopUp.FormClosed += new FormClosedEventHandler(Notes_Form_Closed);
            NotesPopUp.Show();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {

            var cell = this.dataGridViewCustomerUserControl.SelectedCells[0];

            var Customerstable = Reader.LoadCustomersDataTable();

            int customerID = Customerstable.Rows[cell.RowIndex].Field<int>("CustomerID");
            string forename = Customerstable.Rows[cell.RowIndex].Field<string>("Forename");
            string surname = Customerstable.Rows[cell.RowIndex].Field<string>("Lastname");
            string address = Customerstable.Rows[cell.RowIndex].Field<string>("Adress");
            int phonenumber = Customerstable.Rows[cell.RowIndex].Field<int>("PhoneNumber");
            string email = Customerstable.Rows[cell.RowIndex].Field<string>("Email");
            float strenghtRight = Customerstable.Rows[cell.RowIndex].Field<float>("StrengthRight");
            float strenghtLeft = Customerstable.Rows[cell.RowIndex].Field<float>("StrengthLeft");
            string notes = Customerstable.Rows[cell.RowIndex].Field<string>("Notes");
            DateTime signupDate = Customerstable.Rows[cell.RowIndex].Field<DateTime>("SignupDate");

            var EditPopUp = new PopUpDataGridViewChanges(PopUpDataGridViewChanges.EditWindowState.CustumerEdit, customerID, forename, surname, address, phonenumber, email, strenghtLeft, strenghtRight, notes, signupDate);
            EditPopUp.FormClosed += new FormClosedEventHandler(Edit_Form_Closed);
            EditPopUp.Show();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Delete customer?", "Checkbox", MessageBoxButtons.YesNo);
          
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var cell = this.dataGridViewCustomerUserControl.SelectedCells[0];

                    int clickedCellID = Reader.LoadCustomersDataTable().Rows[cell.RowIndex].Field<int>("CustomerID");
                    Deleter.DeleteCustomer(clickedCellID);
                    MessageBox.Show("Customer deleted!");
                    SetUpDefaultDataTableCustomers();

                }
                catch (Exception)
                {
                    MessageBox.Show("This customer have an existing order, and cannot be deleted");
                }
            }
        }
    }
}
