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
using Persistence.CRUD.CRUDorder;

namespace UI
{
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
            SetUpDefaultDataTableCustomers();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            var OrderAddPopUp = new AddPopUp(false);
            OrderAddPopUp.Show();
        }

        public void SetUpDefaultDataTableCustomers()
        {
            dataGridViewOrderUserControl.DataSource = ReaderOrder.GetOrderDataTable();
        }



    }


}
