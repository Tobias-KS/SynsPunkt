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
using Persistence.CRUD;

namespace UI
{
    public partial class ProductsUserControl : UserControl
    {
        public ProductsUserControl()
        {
            InitializeComponent();
            SetUpDefaultDataTableProducts();
        }
        public void SetUpDefaultDataTableProducts()
        {
            dataGridViewProductUserControl.DataSource = Reader.GetProductsDataTable();
        }

        private void PrintButtonProducts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameOfFileProductsUserContolPrint.Text))
            {
                MessageBox.Show("Enter a filename before you print");
            }
            else
            {
                string fileName = NameOfFileProductsUserContolPrint.Text;
                TxtPrinter.Write($"{fileName}", SetupCurrentAsDataTable());
                MessageBox.Show("Data exported");
            }
        }
        public DataTable SetupCurrentAsDataTable()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridViewProductUserControl.Columns)
            {
                dt.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dataGridViewProductUserControl.Rows)
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

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var productAddPopUp = new AddPopUp(AddPopUp.WindowState.Product);
            productAddPopUp.Show();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Delete Product?", "Checkbox", MessageBoxButtons.YesNo);
            

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var cell = this.dataGridViewProductUserControl.SelectedCells[0];

                    int clickedCellID = Reader.GetProductsDataTable().Rows[cell.RowIndex].Field<int>("ProductID");
                    Deleter.DeleteProduct(clickedCellID);
                    MessageBox.Show("Product deleted!");
                    SetUpDefaultDataTableProducts();
                }
                catch (Exception)
                {
                    MessageBox.Show("This product is part of an existing order and cannot be deleted");
                }
            }
        }

        void Edit_Form_Closed(object sender, FormClosedEventArgs e)
        {
            PopUpDataGridViewChanges editChanges = (PopUpDataGridViewChanges)sender;
            SetUpDefaultDataTableProducts();
        }
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {

            var cell = this.dataGridViewProductUserControl.SelectedCells[0];

            var productTable = Reader.GetProductsDataTable();

            int productID = productTable.Rows[cell.RowIndex].Field<int>("ProductID");
            string productName = productTable.Rows[cell.RowIndex].Field<string>("Productname");
            var price = productTable.Rows[cell.RowIndex].Field<float>("Price");
            string colour = productTable.Rows[cell.RowIndex].Field<string>("Colour");
            string brand = productTable.Rows[cell.RowIndex].Field<string>("Brand");
            string frameType = productTable.Rows[cell.RowIndex].Field<string>("FrameType");
            string glassType = productTable.Rows[cell.RowIndex].Field<string>("Glasstype");
            int? rightLensID = productTable.Rows[cell.RowIndex].Field<int?>("RightLensID");
            int? leftLensID = productTable.Rows[cell.RowIndex].Field<int?>("LeftLensID");
            string productDescription = productTable.Rows[cell.RowIndex].Field<string>("Productdescription");

            var EditPopUp = new PopUpDataGridViewChanges(PopUpDataGridViewChanges.EditWindowState.ProductEdit, productID, productName, price, colour, brand, frameType, glassType, productDescription, rightLensID, leftLensID);
            EditPopUp.FormClosed += new FormClosedEventHandler(Edit_Form_Closed);
            EditPopUp.Show();
        }

        private void textBoxSearchProducts_TextChanged(object sender, EventArgs e)
        {

            dataGridViewProductUserControl.DataSource =
                Filter.SearchBar(Reader.GetProductsDataTable(), textBoxSearchProducts.Text);
            //Search funktion here
        }

        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            SetUpDefaultDataTableProducts();
            textBoxSearchProducts.Text = "";
        }
    }
}
