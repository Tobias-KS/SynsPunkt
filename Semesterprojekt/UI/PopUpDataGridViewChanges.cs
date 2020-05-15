using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.Native;

namespace UI
{
    public partial class PopUpDataGridViewChanges : Form
    {
        public bool NotesOrEdit { get; set; }
        public String Notes { get; set; }

        public PopUpDataGridViewChanges(bool notesOrEdit, string notes)
        {

            InitializeComponent();

            this.NotesOrEdit = notesOrEdit;
            this.Notes = notes;

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

        }

        private void MainPanelPopUpDataGridViewChanges_Paint(object sender, PaintEventArgs e)
        {

        }

        public void NotesOrEditToFront()
        {
            if (NotesOrEdit == true)
            {
                notesPopUpUserControl1.BringToFront();
            }
            else
            {
               // addOrderPopUpMainPanelUserControl1.BringToFront();
            }
        }

    }
}
