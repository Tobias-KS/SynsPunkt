using BusinessLogic;
using Persistence.CRUD;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
            SetUpDefaultDataTableOrders();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            var OrderAddPopUp = new AddPopUp(AddPopUp.WindowState.Order);
            OrderAddPopUp.Show();
        }

        public void SetUpDefaultDataTableOrders()
        {
            dataGridViewOrderUserControl.DataSource = Reader.GetOrdersDataTable();
        }

        private void SearchButtonOrderUserControl_TextChanged(object sender, EventArgs e)
        {
            dataGridViewOrderUserControl.DataSource =
                Filter.SearchBar(Reader.GetOrdersDataTable(), textboxOrderSearch.Text);
        }

        private void buttonResetFiltersOrders_Click(object sender, EventArgs e)
        {
            SetUpDefaultDataTableOrders();
            textboxOrderSearch.Text = "";
        }

        public DataTable SetUpCurrentDataTable()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridViewOrderUserControl.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGridViewOrderUserControl.Rows)
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

        private void FromDateOrders_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOrderUserControl.DataSource =
                     Filter.FilterOrdersByFromDateToDate(FromDateOrders.Text, ToDateOrders.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("There are no orders within the selected dates");
            }

        }

        private void ToDateOrders_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOrderUserControl.DataSource =
                    Filter.FilterOrdersByFromDateToDate(FromDateOrders.Text, ToDateOrders.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("There are no orders within the selected dates");
            }
        }
        private void PrintButtonOrders_Click(object sender, EventArgs e)
        {

            string fromdate = FromDateOrders.Text;
            string todate = ToDateOrders.Text;
            if (string.IsNullOrEmpty(textBoxNameOnPrintFileOrders.Text))
            {
                MessageBox.Show("Enter a filename before you print");
            }
            else
            {
                string fileName = textBoxNameOnPrintFileOrders.Text;
                TxtPrinter.Write($"{fileName}", SetUpCurrentDataTable(), true, fromdate, todate);
                MessageBox.Show("Data exported");
            }
        }
    }
}
