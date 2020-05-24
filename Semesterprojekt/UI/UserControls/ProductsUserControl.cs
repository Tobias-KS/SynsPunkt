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
            dataGridViewProductUserControl.DataSource = Reader.LoadProductTable();
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
                TxtPrinter.WriteToTxt($"{fileName}", SetupCurrentAsDataTable());
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
            var productAddPopUp = new AddPopUp(AddPopUp.WindowState.ProductAdd);
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

                    int clickedCellID = Reader.LoadProductTable().Rows[cell.RowIndex].Field<int>("ProductID");
                    Deleter.DeleteProduct(clickedCellID);
                    MessageBox.Show("Product deleted!");
                    SetUpDefaultDataTableProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("This product is part of an existing order and cannot be deleted");
                }
                
            }

        }
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {


        }
    }
}
