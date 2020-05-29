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
    public partial class SearchBinocularsWindow : UserControl
    {
        public SearchBinocularsWindow()
        {
            InitializeComponent();
            SetUpDefaultDataTableProducts();
            BinocularsPrice.Text = "5000";
           
        }
        public void SetUpDefaultDataTableProducts()
        {
            BinocularsDataView.DataSource = Reader.GetProductsDataTable();
        }

        private void BinocularsProductsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BinocularsPrice.Text = "" + BinocularsPriceBar.Value;
        }

        private void BinocularsProductsSearchBtn_Click(object sender, EventArgs e)
        {
            string frametype = "";
            string glasstype = "";
            int Price = Convert.ToInt32(BinocularsPrice.Text);

            //Nogle af farverne mangler, da vi ikke er har Binoculars inge i databasen så deres unikke farver er ikke med.
            //Her mangler der lidt kode til at skulle afslutte den med quantity men det er et større projekt.
            BinocularsDataView.DataSource = Reader.GetProductsSpecificDataTable(BinocularBrandList.Text, BinocularsListBoxColour.Text, frametype, glasstype, Price);

        }

        private void BinocularsProductsClearBtn_Click(object sender, EventArgs e)
        {
            BinocularsPrice.Text = "5000";
            BinocularsPriceBar.Value = 5000;
            BinocularsStrenghtText.Text = "";
            BinocularsDataView.DataSource = Reader.GetProductsDataTable();
        }
    }
}
