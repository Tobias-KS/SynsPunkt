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
    }
}
