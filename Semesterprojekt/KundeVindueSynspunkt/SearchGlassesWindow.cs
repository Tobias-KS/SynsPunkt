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

            SqlConnection conn = new SqlConnection();
            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from products", conn);
            DataTable GlassesDataView = new DataTable();

            adapter.Fill(GlassesDataView);
                       
        }
    }
}
