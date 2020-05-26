using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Persistence.CRUD.Creator;
using System.Runtime.InteropServices;

namespace KundeVindueSynspunkt
{
    public partial class NewCustomerPage : UserControl
    {

        public NewCustomerPage()
        {
            InitializeComponent();
        }

        private void NewCustomerButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void CreateCustomerCustomerProgram()
        {
            int PhoneNumber = Convert.ToInt32(NewCustomerPhonenumber.Text);
            float StrengthRight = 0;
            float StrengthLeft = 0;
            AddCustomer(NewCustomerName.Text, NewCustomerSurname.Text,
                NewCustomerAddress.Text, PhoneNumber, NewCustomerEmail.Text,
                StrengthRight, StrengthLeft, DateTime.Now);
        }

        public void NewCustomerButtonNext_Click(object sender, EventArgs e)
        {
            

            CreateCustomerCustomerProgram();

            NewCustomerName.Text = "";
            NewCustomerSurname.Text = "";
            NewCustomerAddress.Text = "";
            NewCustomerPhonenumber.Text = "";
            NewCustomerEmail.Text = "";
            this.Hide();
        }
    }
}
