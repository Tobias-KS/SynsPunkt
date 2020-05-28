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
            DialogResult dialogrerult = MessageBox.Show("Do you want to go back?", "This will clear page", MessageBoxButtons.YesNo);
            if(dialogrerult == DialogResult.Yes)
            {
                NewCustomerName.Text = "";
                NewCustomerSurname.Text = "";
                NewCustomerAddress.Text = "";
                NewCustomerPhonenumber.Text = "";
                NewCustomerEmail.Text = "";
                this.Hide();
            }
            else if (dialogrerult == DialogResult.No)
            {


            }
            
        }


        public void NewCustomerButtonNext_Click(object sender, EventArgs e)
        {

            DialogResult dialogresult = MessageBox.Show("You wish to continue", "Save Customer", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                 {

                string forename = NewCustomerName.Text;
                string lastname = NewCustomerSurname.Text;
                string adress = NewCustomerAddress.Text;
                int PhoneNumber = Int32.Parse(NewCustomerPhonenumber.Text);
                string email = NewCustomerEmail.Text;
                DateTime SignupDate = DateTime.Now;
                float StrengthRight = 0;
                float StrengthLeft = 0;
                string notes = "";
                AddCustomer(forename, lastname, adress, PhoneNumber, email, StrengthRight, StrengthLeft, SignupDate, notes);
                NewCustomerName.Text = "";
                NewCustomerSurname.Text = "";
                NewCustomerAddress.Text = "";
                NewCustomerPhonenumber.Text = "";
                NewCustomerEmail.Text = "";
                this.Hide();
                 }
                else if (dialogresult == DialogResult.No)
            {

            }
            

        }

    }
}
