using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Persistence.CRUD;
namespace UI
{
    public partial class EmployeesUserControl : UserControl
    {
        public EmployeesUserControl()
        {
            InitializeComponent();
        }

        private void ComboBoxEmplyeesSelectStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonShowSelectedItems_Click(object sender, EventArgs e)
        {
            List<string> Butikker = new List<string>();

            Butikker.Add("Hest");
            Butikker.Add("Butiksnummer");
            Butikker.Add("Hund");

            if (ComboBoxEmplyeesSelectStore.SelectedIndex == 0)
            {
                StoreInformationListBox.DataSource = Reader.SelectAllCustomers();

            }
            else if (ComboBoxEmplyeesSelectStore.SelectedIndex == 1)
            {

            }
            else if (ComboBoxEmplyeesSelectStore.SelectedIndex == 2)
            {

            }
            else if (ComboBoxEmplyeesSelectStore.SelectedIndex == 3)
            {

            }
            else if (ComboBoxEmplyeesSelectStore.SelectedIndex == 4)
            {

            }
        }
        private void StoreInformationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
