using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PopUpDataGridViewChanges : Form
    {
        public bool NotesOrEdit { get; set; }
        public string Notes { get; set; }

        public PopUpDataGridViewChanges(bool notesOrEdit, string forename, string surname, string address, string phonenumber,
        string email, string strenghtleft, string strenghtright, string notes, string signupdate)
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
      

    }
}
