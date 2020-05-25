using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundeVindueSynspunkt
{
    public partial class SearchProducts : UserControl
    {
        public SearchProducts()
        {
            InitializeComponent();
            SearchGlassesWindow.Hide();
            searchContactLensesWindow1.Hide();
            searchBinocularsWindow1.Hide();
        }

        private void NewCustomerButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void GlassesSearchButton_Click(object sender, EventArgs e)
        {
            
            SearchGlassesWindow.Show();
            SearchGlassesWindow.BringToFront();
            
        }

        private void CointactLensesSearchButton_Click(object sender, EventArgs e)
        {
            searchContactLensesWindow1.Show();
            searchContactLensesWindow1.BringToFront();
        }

        private void BinocularsSearchButton_Click(object sender, EventArgs e)
        {
            searchBinocularsWindow1.Show();
            searchBinocularsWindow1.BringToFront();
        }
    }
}
