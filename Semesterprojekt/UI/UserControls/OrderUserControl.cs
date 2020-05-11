using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            var OrderAddPopUp = new AddPopUp();
            OrderAddPopUp.isCustomer = false;
            OrderAddPopUp.Show();
        }

        private void ToDateOrders_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
