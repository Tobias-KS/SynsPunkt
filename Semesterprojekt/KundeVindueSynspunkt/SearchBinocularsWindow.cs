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
    public partial class SearchBinocularsWindow : UserControl
    {
        public SearchBinocularsWindow()
        {
            InitializeComponent();
        }

        private void LensesProductsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = "" + trackBar1.Value;
        }
    }
}
