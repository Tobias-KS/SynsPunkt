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
        public bool NotesOrEdit { get; set; }
        public string Notes { get; set; }
        public DateTime SignupDate { get; set; }
        public int CustomerID { get; set; }
        public PopUpDataGridViewChanges(bool notesOrEdit, int customerID, string forename, string surname, string address, int phonenumber,
        string email, float strenghtleft, float strenghtright, string notes, DateTime signupdate)
        {

            InitializeComponent();
            
            this.NotesOrEdit = notesOrEdit;
            this.Notes = notes;
            
            if (NotesOrEdit == true)
            {
                richtextboxPopUpNotes.BringToFront();
                richtextboxPopUpNotes.Text = notes;
            }
            else
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

            this.NotesOrEdit = notesOrEdit;
            this.Notes = notes;

            if (NotesOrEdit == true)
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

            if (NotesOrEdit == true)
            {
                //Update notes...

                this.Close();
            }
            else
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


        }
    }
}
