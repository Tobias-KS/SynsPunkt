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
            frontPageUserControl1.BringToFront();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductsUserControl CSPage = new ProductsUserControl();
            CSPage.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(CSPage);
        }


        private void CustomerButton_Click(object sender, EventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            customerUserControl1.BringToFront();

        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            frontPageUserControl1.BringToFront();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            productsUserControl1.BringToFront();
        }
    }
}
