using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundeVindueSynspunkt
{
    public partial class Customergreet : Form
    {
        public Customergreet()
        {
            InitializeComponent();
            newCustomerPage1.Hide();
            this.FormBorderStyle = 0;

        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;


        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BottunMaximize_Click_1(object sender, System.EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void Customergreet_Load(object sender, EventArgs e)
        {

            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            TimeWelcomeToSynspunkt.Text = datetime.ToString();
        }

        private void ButtonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aNewCustomerButton_Click(object sender, EventArgs e)
        {
            newCustomerPage1.Show();
            newCustomerPage1.BringToFront();
            TimeWelcomeToSynspunkt.BringToFront();
            /*
            aNewCustomerButton.Hide();
            aSearchGlassesButton.Hide();
            Label1WelcomeToSynspunkt.Hide();
            LogoWelcomepage.Hide();
            StorenameWelcomepage.Hide();
           */

        }


        private void aSearchProductsButton_Click_1(object sender, EventArgs e)
        {
            aNewCustomerButton.Hide();
            aSearchProductsButton.Hide();
            TimeWelcomeToSynspunkt.BringToFront();
        }
    }

}
