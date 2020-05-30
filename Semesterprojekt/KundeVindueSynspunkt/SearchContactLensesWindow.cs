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

namespace KundeVindueSynspunkt
{
    public partial class SearchContactLensesWindow : UserControl
    {
        public SearchContactLensesWindow()
        {
            InitializeComponent();
            SetUpDefaultDataTableProducts();
            LensePrice.Text = "5000";
            LensStrengthLeftText.Text = "";
            LensStrengthRightText.Text = "";
        }
        public void SetUpDefaultDataTableProducts()
        {
            LensesDataView.DataSource = Reader.GetProductsDataTable();
        }

        private void LensesProductsBackBtn_Click(object sender, EventArgs e)
        {
            BrandLensListBox.ClearSelected();

            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            LensePrice.Text = "" + LensPriceBar.Value;
        }

        private void LensProductsSearchBtn_Click(object sender, EventArgs e)
        {
            string colour = "";
            string frametype = "";
            string glasstype = "";  

            int Price = Convert.ToInt32(LensePrice.Text);


           //Her mangler der lidt kode til at skulle afslutte den med quantity men det er et større projekt.
            LensesDataView.DataSource = Reader.GetProductsSpecificDataTable(BrandLensListBox.Text, colour, frametype, glasstype, Price);
        }

        private void LensProductsClearBtn_Click(object sender, EventArgs e)
        {
            LensePrice.Text = "5000";
            LensPriceBar.Value = 5000;
            LensStrengthLeftText.Text = "";
            LensStrengthRightText.Text = "";

            BrandLensListBox.ClearSelected();

            LensesDataView.DataSource = Reader.GetProductsDataTable();
        }

        private void LensBrandCheckbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
