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
        }
        
        public void SetUpDefaultDataTableProducts()
        {
            GlassesDataView.DataSource = Reader.GetProductsDataTable();
        }
        
        private void GlassesProductsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            GlassesPrice.Text = "" + GlassesPriceBar.Value;
        }

        private void GlassesProductsClearBtn_Click(object sender, EventArgs e)
        {
            GlassesPrice.Text = "";
        }

        private void GlassesBrandCheckbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GlassesProductsSearchBtn_Click(object sender, EventArgs e)
        {
            /*
            var ProductTable = new DataTable();
            var CheckedBrand1 = GlassesBrandCheckbox1.CheckedItems;
            
            
            // var CheckedBrand2 = GlassesBrandCheckbox2.CheckedItems;
            // var CheckedColour = GlassColourCheckbox1.CheckedItems;
           
/*
            var SortedDataTable = Reader.GetSpecificProductDataTable().AsEnumerable()
             .Where(row => CheckedBrand1.Contains(row.Field<string>("Brand")));
            
            GlassesDataView.DataSource = SortedDataTable;
            GlassesDataView.Refresh();
            */
            
            //Tjek den igennem efter 
            // Kig på den her Ragnar
            GlassesDataView.DataSource =Reader.GetSpecificProductDataTable();


            //Eventuelt til de andre vinduer

            /* //textbox 1
             .Where(row => row.Field<string>("colour") == "green")
             //textbox 2
             .Where(row => row.Field<string>("colour") == "green")
             //textbox 3
             .Where(row => row.Field<string>("colour") == "green")
             //textbox 4
             .Where(row => row.Field<string>("colour") == "green");
         //textbox 5

         // price where row  ==< værdi
              */




        }
    }
}
