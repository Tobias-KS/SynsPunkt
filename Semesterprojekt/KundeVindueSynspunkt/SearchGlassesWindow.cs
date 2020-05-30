using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Persistence;
using System.Net.NetworkInformation;
using Persistence.CRUD;


namespace KundeVindueSynspunkt
{
    public partial class SearchGlassesWindow : UserControl
    {

        public SearchGlassesWindow()
        {
            InitializeComponent();
            SetUpDefaultDataTableProducts();
            GlassesPrice.Text = "5000";
            GlassLeftStrengthText.Text = "";
            GlassRightStrengthText.Text = "";
        }
        
        public void SetUpDefaultDataTableProducts()
        {
            GlassesDataView.DataSource = Reader.GetProductsDataTable();
        }
        
        private void GlassesProductsBackBtn_Click(object sender, EventArgs e)
        {
            BrandListBox.ClearSelected();
            GlassTypeListBox.ClearSelected();
            FrameTypeListBox.ClearSelected();
            GlasseslistBoxColour.ClearSelected();

            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            GlassesPrice.Text = "" + GlassesPriceBar.Value;
        }

        private void GlassesProductsClearBtn_Click(object sender, EventArgs e)
        {
            GlassesPrice.Text = "5000";
            GlassesPriceBar.Value = 5000;
            GlassLeftStrengthText.Text = "";
            GlassRightStrengthText.Text = "";

            BrandListBox.ClearSelected();
            GlassTypeListBox.ClearSelected();
            FrameTypeListBox.ClearSelected();
            GlasseslistBoxColour.ClearSelected();
            GlassesDataView.DataSource = Reader.GetProductsDataTable();

        }

        private void GlassesProductsSearchBtn_Click(object sender, EventArgs e)
        {
            /*string Brand = "Gant";
            int Price = Convert.ToInt32(GlassesPrice.Text);

            GlassesDataView.DataSource = Reader.SelectProductTest(Brand, listBoxColour.Text, Price);
            */
            int Price = Convert.ToInt32(GlassesPrice.Text);


            //Denne måde at søge ting frem på bliver ret trels jo flere du putter på! kan være vi skal se efter en anden måde! men det er OBV LIR! :)

            //Strength er ligegyldigt da vi ikke har nogle parametre at søge efter, og gør det ret trels.
            GlassesDataView.DataSource = Reader.GetProductsSpecificDataTable(BrandListBox.Text, GlasseslistBoxColour.Text, FrameTypeListBox.Text, GlassTypeListBox.Text, Price);
            
        }

    }
}
