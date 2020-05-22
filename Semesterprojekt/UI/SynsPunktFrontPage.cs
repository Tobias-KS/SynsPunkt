using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrontPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public FrontPage()
        {
            InitializeComponent();
            TimerToFrontPage.Start();
            frontPageUserControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductsUserControl CSPage = new ProductsUserControl();
            CSPage.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(CSPage);
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void CustomersButton_Click(object sender, EventArgs e)
        {
            customerUserControl2.BringToFront();
            ChangeColors(CustomersButton);

        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            frontPageUserControl1.BringToFront();
            ChangeColors(HomeButton);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            productsUserControl1.BringToFront();
            ChangeColors(ProductsButton);
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            orderUserControl1.BringToFront();
            ChangeColors(OrdersButton);
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            supportUserControl1.BringToFront();
            ChangeColors(SupportButton);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            employeesUserControl1.BringToFront();
            ChangeColors(EmployeesButton);
        }

        private void ChangeColors(Button activeButton)
        {
            HomeButton.BackColor = Color.FromArgb(25, 118, 211);
            CustomersButton.BackColor = Color.FromArgb(25, 118, 211);
            OrdersButton.BackColor = Color.FromArgb(25, 118, 211);
            SupportButton.BackColor = Color.FromArgb(25, 118, 211);
            ProductsButton.BackColor = Color.FromArgb(25, 118, 211);
            EmployeesButton.BackColor = Color.FromArgb(25, 118, 211);
            ButtonMailFrontPage.BackColor = Color.FromArgb(25, 118, 211);
            activeButton.BackColor = Color.FromArgb(0, 191, 255);
        }

        private void ButtonMailFrontPage_Click(object sender, EventArgs e)
        {
            mailUserControl1.BringToFront();
            ChangeColors(ButtonMailFrontPage);
        }
        private void TimerToFrontPage_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            TimeToFrontPage.Text = datetime.ToString();
        }
    }
}
