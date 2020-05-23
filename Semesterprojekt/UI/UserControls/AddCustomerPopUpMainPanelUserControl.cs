using System;
using System.Windows.Forms;
using static Persistence.CRUD.Creator;

namespace UI
{
    public partial class AddCustomerPopUpMainPanelUserControl : UserControl
    {
        public AddCustomerPopUpMainPanelUserControl()
        {
            InitializeComponent();

        }

        public void CreateCustomerFromPopUp()
        {
            int PhoneNumber = Convert.ToInt32(TextBoxPhoneCustomerAddPopUp.Text);
            float StrenghtRight = (float)Convert.ToDouble(TextBoxRightStrenghtlabelCustomerAddPopUp.Text);
            float StrenghtLeft = (float)Convert.ToDouble(TextBoxLeftStrenghtlabelCustomerAddPopUp.Text);

            AddCustomer(TextboxToForeNameCustomerAddPopUp.Text, TextboxToSurnameCustomerAddPopUp.Text,
            TextBoxAddressCustomerAddPopUp.Text, PhoneNumber, TextBoxEmailCustomerAddPopUp.Text,
            StrenghtRight, StrenghtLeft, DateTime.Now, RichTextBoxNotesCustomerAddPopUp.Text);

            //Reload datagridview..
        }
    }
}
