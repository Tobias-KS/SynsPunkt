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
            for (int i = 0; i < GlassesBrandCheckbox1.Items.Count; i++)
                GlassesBrandCheckbox1.SetItemCheckState(i, (false ? CheckState.Checked : CheckState.Unchecked));
            GlassesDataView.DataSource = Reader.GetProductsDataTable();

        }

        private void GlassesProductsSearchBtn_Click(object sender, EventArgs e)
        {
            /*string Brand = "Gant";
            int Price = Convert.ToInt32(GlassesPrice.Text);

            GlassesDataView.DataSource = Reader.SelectProductTest(Brand, listBoxColour.Text, Price);
            */
            string Brand = "";
            string FrameType = "";
            string Glasstype = "";
            int Price = Convert.ToInt32(GlassesPrice.Text);

            GlassesDataView.DataSource = Reader.GetProductsSpecificDataTable(Brand, listBoxColour.Text, FrameType, Glasstype, Price);
            
        }

        
    }
}
