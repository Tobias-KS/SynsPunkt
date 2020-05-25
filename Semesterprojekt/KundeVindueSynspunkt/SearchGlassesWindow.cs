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
    public partial class SearchGlassesWindow : UserControl
    {
        public SearchGlassesWindow()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GlassesProductsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SearchGlassesWindow_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = "" + trackBar1.Value;
        }

        
    }
}
