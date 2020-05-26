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
    }
}
