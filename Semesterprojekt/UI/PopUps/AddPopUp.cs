﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class AddPopUp : Form
    {
        public bool IsCustomer { get; set; }

        public AddPopUp(bool isCustomer)
        {
            InitializeComponent();
            this.IsCustomer = isCustomer;
            CustomerOrOrder();

        }
        //Metode til at man kan flytte PopUp rundt
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //
        private void CancelButtonPopUp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
      
        private void TopPanelPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            // Her bruger jeg metoden til at flytte PopUp med musen
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void CustomerOrOrder()
        {
            if (IsCustomer == true)
            {
                addCustomerPopUpMainPanelUserControl1.BringToFront();
            }
            else
            {
                addOrderPopUpMainPanelUserControl1.BringToFront();
            }
        }

        private void TopPanelPopUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addOrderPopUpMainPanelUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void LeftPanelPopUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RightPanelPopUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveButtonPopUp_Click(object sender, EventArgs e)
        {
            try
            {
                addCustomerPopUpMainPanelUserControl1.CreateCustomerFromPopUp();
                MessageBox.Show("Customer created");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Tænkt dig lige om...");

            }
            
        }
    }
}
