using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistence.CRUD;

namespace UI
{
    public partial class PopUpDataGridViewChanges : Form
    {
        public enum EditWindowState
        {
            CustumerNotes,
            CustumerEdit,
            ProductEdit
        }

        public EditWindowState CurrentWindowState { get; set; }
        public string Notes { get; set; }
        public DateTime SignupDate { get; set; }
        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public PopUpDataGridViewChanges(EditWindowState windowState, int productID, string productName, float price, string colour, 
            string brand, string frameType, string glassType ,  string productDescription = "", int? rightLensID = null, int? leftLensID = null)
        {
            InitializeComponent();
            this.CurrentWindowState = windowState;
            editProductUserControl1.BringToFront();
            editProductUserControl1.textBoxProductName.Text = productName;
            editProductUserControl1.textBoxPrice.Text = Convert.ToString(price);
            editProductUserControl1.textBoxColour.Text = colour;
            editProductUserControl1.textBoxBrand.Text = brand;
            editProductUserControl1.textBoxFrametype.Text = frameType;
            editProductUserControl1.textBoxGLasstype.Text = glassType;
            editProductUserControl1.textboxRightlensID.Text = Convert.ToString(rightLensID);
            editProductUserControl1.textBoxLeftLensID.Text = Convert.ToString(leftLensID);
            editProductUserControl1.richTextBoxProductDescription.Text = productDescription;

            this.ProductID = productID;

        }
        public PopUpDataGridViewChanges(EditWindowState windowState, int customerID, string forename, string surname, string address, int phonenumber,
        string email, float strenghtleft, float strenghtright, string notes, DateTime signupdate)
        {

            InitializeComponent();
            
            this.CurrentWindowState = windowState;
            this.Notes = notes;
            
            if (CurrentWindowState == EditWindowState.CustumerNotes)
            {
                richtextboxPopUpNotes.BringToFront();
                richtextboxPopUpNotes.Text = notes;
            }
            else if(CurrentWindowState == EditWindowState.CustumerEdit)
            {
                editPopUpCustomerControl1.BringToFront();
                editPopUpCustomerControl1.TextboxToNameCustomerEditPopUp.Text = forename;
                editPopUpCustomerControl1.TextboxToSurnameCustomerEditPopUp.Text = surname;
                editPopUpCustomerControl1.TextBoxAddressCustomerEditPopUp.Text = address;
                editPopUpCustomerControl1.TextBoxPhoneCustomerEditPopUp.Text = phonenumber.ToString();
                editPopUpCustomerControl1.TextBoxEmailCustomerEditPopUp.Text = email;
                editPopUpCustomerControl1.TextBoxLeftStrenghtlabelCustomerEditPopUp.Text = strenghtleft.ToString();
                editPopUpCustomerControl1.TextBoxRightStrenghtlabelCustomerEditPopUp.Text = strenghtright.ToString();
                editPopUpCustomerControl1.RichTextBoxNotesCustomerEditPopUp.Text = notes;
            }

            this.CustomerID = customerID;
            this.SignupDate = signupdate;
            
        }

        public PopUpDataGridViewChanges(bool notesOrEdit, string notes)
        {

            InitializeComponent();

            this.CurrentWindowState = EditWindowState.CustumerNotes;
            this.Notes = notes;

            if (this.CurrentWindowState == EditWindowState.CustumerNotes)
            {
                richtextboxPopUpNotes.BringToFront();
                richtextboxPopUpNotes.Text = notes;
            }
            else
            {

                editPopUpCustomerControl1.BringToFront();

            }
        }

        private void CloseButtonPopUpDataGridViewChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiddelPanelPopUpDataGridViewChangesCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel, the information you entered will not be saved?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }

        private void MiddelPanelPopUpDataGridViewChangesSaveButton_Click(object sender, EventArgs e)
        {

            if (this.CurrentWindowState == EditWindowState.CustumerNotes)
            {
                //Update notes...

                this.Close();
            }
            else if (this.CurrentWindowState == EditWindowState.CustumerEdit)
            
            {
                var forename = editPopUpCustomerControl1.TextboxToNameCustomerEditPopUp.Text;
                var lastname = editPopUpCustomerControl1.TextboxToSurnameCustomerEditPopUp.Text;
                var address = editPopUpCustomerControl1.TextBoxAddressCustomerEditPopUp.Text;
                var phoneNumber = Convert.ToInt32(editPopUpCustomerControl1.TextBoxPhoneCustomerEditPopUp.Text);
                var email = editPopUpCustomerControl1.TextBoxEmailCustomerEditPopUp.Text;
                var leftStrength = (float)Convert.ToDouble(editPopUpCustomerControl1.TextBoxLeftStrenghtlabelCustomerEditPopUp.Text);
                var rightStrength = (float)Convert.ToDouble(editPopUpCustomerControl1.TextBoxRightStrenghtlabelCustomerEditPopUp.Text);
                var notes = editPopUpCustomerControl1.RichTextBoxNotesCustomerEditPopUp.Text;
                var signupDate = SignupDate;
                var customerID = CustomerID;

                Updater.AlterCustomer(CustomerID: customerID, forename: forename, lastname: lastname, adress: address, phoneNumber: phoneNumber,
                    email: email, strengthRight: leftStrength, strengthLeft: rightStrength, notes: notes,
                    signupDate: signupDate);

                this.Close();

            }
            else if (this.CurrentWindowState == EditWindowState.ProductEdit)

            {

                var productName = editProductUserControl1.textBoxProductName.Text;
                var price = (float)Convert.ToDouble(editProductUserControl1.textBoxPrice.Text);
                var colour = editProductUserControl1.textBoxColour.Text;
                var brand = editProductUserControl1.textBoxBrand.Text;
                var frameType = editProductUserControl1.textBoxFrametype.Text;
                var glassType = editProductUserControl1.textBoxGLasstype.Text;

                var rightLensID = 2;
                var leftLensID = 1;
                if (editProductUserControl1.textboxRightlensID.Text != "")
                {
                    rightLensID = Convert.ToInt32(editProductUserControl1.textboxRightlensID.Text);
                }
                if (editProductUserControl1.textBoxLeftLensID.Text != "")
                {
                    leftLensID = Convert.ToInt32(editProductUserControl1.textBoxLeftLensID.Text);
                }
                
                var productDescription = editProductUserControl1.richTextBoxProductDescription.Text;
                var productID = this.ProductID;

                Updater.AlterProduct(ProductID: productID, Productname: productName, price: price, Colour: colour, Brand: brand, FrameType: frameType, 
                    Glasstype: glassType,  RightLensID: rightLensID,  LeftLensID: leftLensID,  Productdescription: productDescription);

                this.Close();

            }


        }
    }
}
