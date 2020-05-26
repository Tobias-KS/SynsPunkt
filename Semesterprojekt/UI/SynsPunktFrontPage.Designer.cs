namespace UI
{
    partial class FrontPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

      



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ButtonMailFrontPage = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CompanyName = new System.Windows.Forms.Label();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TimeToFrontPage = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MinimizeApp = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerUserControl2 = new UI.CustomerUserControl();
            this.orderUserControl1 = new UI.OrderUserControl();
            this.productsUserControl1 = new UI.ProductsUserControl();
            this.frontPageUserControl1 = new UI.FrontPageUserControl();
            this.mailUserControl1 = new UI.MailUserControl();
            this.employeesUserControl1 = new UI.EmployeesUserControl();
            this.supportUserControl1 = new UI.SupportUserControl();
            this.customerUserControl1 = new UI.ProductsUserControl();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.TimerToFrontPage = new System.Windows.Forms.Timer(this.components);
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.SidePanel.Controls.Add(this.TimeToFrontPage);
            this.SidePanel.Controls.Add(this.ButtonMailFrontPage);
            this.SidePanel.Controls.Add(this.HomeButton);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Controls.Add(this.EmployeesButton);
            this.SidePanel.Controls.Add(this.SupportButton);
            this.SidePanel.Controls.Add(this.OrdersButton);
            this.SidePanel.Controls.Add(this.ProductsButton);
            this.SidePanel.Controls.Add(this.Logo);
            this.SidePanel.Controls.Add(this.CompanyName);
            this.SidePanel.Controls.Add(this.CustomersButton);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(210, 1017);
            this.SidePanel.TabIndex = 0;
            // 
            // ButtonMailFrontPage
            // 
            this.ButtonMailFrontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonMailFrontPage.FlatAppearance.BorderSize = 0;
            this.ButtonMailFrontPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMailFrontPage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMailFrontPage.ForeColor = System.Drawing.Color.White;
            this.ButtonMailFrontPage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMailFrontPage.Image")));
            this.ButtonMailFrontPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMailFrontPage.Location = new System.Drawing.Point(0, 652);
            this.ButtonMailFrontPage.Name = "ButtonMailFrontPage";
            this.ButtonMailFrontPage.Size = new System.Drawing.Size(210, 89);
            this.ButtonMailFrontPage.TabIndex = 9;
            this.ButtonMailFrontPage.Text = "Mail";
            this.ButtonMailFrontPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonMailFrontPage.UseVisualStyleBackColor = false;
            this.ButtonMailFrontPage.Click += new System.EventHandler(this.ButtonMailFrontPage_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 177);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(210, 89);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(210, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 778);
            this.panel1.TabIndex = 2;
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.EmployeesButton.FlatAppearance.BorderSize = 0;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesButton.ForeColor = System.Drawing.Color.White;
            this.EmployeesButton.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesButton.Image")));
            this.EmployeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeesButton.Location = new System.Drawing.Point(0, 557);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(210, 89);
            this.EmployeesButton.TabIndex = 7;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeesButton.UseVisualStyleBackColor = false;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.SupportButton.FlatAppearance.BorderSize = 0;
            this.SupportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupportButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupportButton.ForeColor = System.Drawing.Color.White;
            this.SupportButton.Image = ((System.Drawing.Image)(resources.GetObject("SupportButton.Image")));
            this.SupportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupportButton.Location = new System.Drawing.Point(0, 925);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(210, 89);
            this.SupportButton.TabIndex = 6;
            this.SupportButton.Text = "Support";
            this.SupportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SupportButton.UseVisualStyleBackColor = false;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdersButton.Image")));
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersButton.Location = new System.Drawing.Point(0, 462);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(210, 89);
            this.OrdersButton.TabIndex = 5;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ProductsButton.FlatAppearance.BorderSize = 0;
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.Color.White;
            this.ProductsButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductsButton.Image")));
            this.ProductsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsButton.Location = new System.Drawing.Point(0, 367);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(210, 89);
            this.ProductsButton.TabIndex = 4;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductsButton.UseVisualStyleBackColor = false;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(160, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(64, 52);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompanyName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.ForeColor = System.Drawing.Color.White;
            this.CompanyName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompanyName.Location = new System.Drawing.Point(3, 12);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(151, 36);
            this.CompanyName.TabIndex = 2;
            this.CompanyName.Text = "SynsPunkt";
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.CustomersButton.FlatAppearance.BorderSize = 0;
            this.CustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomersButton.Image")));
            this.CustomersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersButton.Location = new System.Drawing.Point(0, 272);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(210, 89);
            this.CustomersButton.TabIndex = 0;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomersButton.UseVisualStyleBackColor = false;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.TopPanel.Controls.Add(this.MainPanel);
            this.TopPanel.Controls.Add(this.MinimizeApp);
            this.TopPanel.Controls.Add(this.CloseApp);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(210, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1700, 51);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // TimeToFrontPage
            // 
            this.TimeToFrontPage.AutoSize = true;
            this.TimeToFrontPage.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeToFrontPage.ForeColor = System.Drawing.Color.White;
            this.TimeToFrontPage.Location = new System.Drawing.Point(5, 51);
            this.TimeToFrontPage.Name = "TimeToFrontPage";
            this.TimeToFrontPage.Size = new System.Drawing.Size(81, 21);
            this.TimeToFrontPage.TabIndex = 10;
            this.TimeToFrontPage.Text = "DatoHer";
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 44);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1211, 781);
            this.MainPanel.TabIndex = 2;
            // 
            // MinimizeApp
            // 
            this.MinimizeApp.FlatAppearance.BorderSize = 0;
            this.MinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeApp.ForeColor = System.Drawing.Color.White;
            this.MinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeApp.Image")));
            this.MinimizeApp.Location = new System.Drawing.Point(1621, 3);
            this.MinimizeApp.Name = "MinimizeApp";
            this.MinimizeApp.Size = new System.Drawing.Size(36, 45);
            this.MinimizeApp.TabIndex = 3;
            this.MinimizeApp.UseVisualStyleBackColor = true;
            this.MinimizeApp.Click += new System.EventHandler(this.MinimizeApp_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.ForeColor = System.Drawing.Color.White;
            this.CloseApp.Image = ((System.Drawing.Image)(resources.GetObject("CloseApp.Image")));
            this.CloseApp.Location = new System.Drawing.Point(1663, 12);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(25, 26);
            this.CloseApp.TabIndex = 2;
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customerUserControl2);
            this.panel2.Controls.Add(this.orderUserControl1);
            this.panel2.Controls.Add(this.productsUserControl1);
            this.panel2.Controls.Add(this.frontPageUserControl1);
            this.panel2.Controls.Add(this.mailUserControl1);
            this.panel2.Controls.Add(this.employeesUserControl1);
            this.panel2.Controls.Add(this.supportUserControl1);
            this.panel2.Controls.Add(this.customerUserControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 966);
            this.panel2.TabIndex = 2;
            // 
            // customerUserControl2
            // 
            this.customerUserControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customerUserControl2.BackColor = System.Drawing.Color.White;
            this.customerUserControl2.customerAddPopUp = null;
            this.customerUserControl2.Location = new System.Drawing.Point(0, -1);
            this.customerUserControl2.Name = "customerUserControl2";
            this.customerUserControl2.Size = new System.Drawing.Size(1700, 966);
            this.customerUserControl2.TabIndex = 4;
            // 
            // orderUserControl1
            // 
            this.orderUserControl1.BackColor = System.Drawing.Color.White;
            this.orderUserControl1.Location = new System.Drawing.Point(0, -1);
            this.orderUserControl1.Name = "orderUserControl1";
            this.orderUserControl1.Size = new System.Drawing.Size(1700, 966);
            this.orderUserControl1.TabIndex = 3;
            // 
            // productsUserControl1
            // 
            this.productsUserControl1.BackColor = System.Drawing.Color.White;
            this.productsUserControl1.Location = new System.Drawing.Point(0, -1);
            this.productsUserControl1.Name = "productsUserControl1";
            this.productsUserControl1.Size = new System.Drawing.Size(1700, 966);
            this.productsUserControl1.TabIndex = 2;
            // 
            // frontPageUserControl1
            // 
            this.frontPageUserControl1.BackColor = System.Drawing.Color.White;
            this.frontPageUserControl1.Location = new System.Drawing.Point(0, -1);
            this.frontPageUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.frontPageUserControl1.Name = "frontPageUserControl1";
            this.frontPageUserControl1.Size = new System.Drawing.Size(1700, 966);
            this.frontPageUserControl1.TabIndex = 1;
            // 
            // mailUserControl1
            // 
            this.mailUserControl1.BackColor = System.Drawing.Color.White;
            this.mailUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailUserControl1.Location = new System.Drawing.Point(0, -1);
            this.mailUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.mailUserControl1.Name = "mailUserControl1";
            this.mailUserControl1.Size = new System.Drawing.Size(1700, 966);
            this.mailUserControl1.TabIndex = 8;
            // 
            // employeesUserControl1
            // 
            this.employeesUserControl1.BackColor = System.Drawing.Color.White;
            this.employeesUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesUserControl1.Location = new System.Drawing.Point(0, -1);
            this.employeesUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.employeesUserControl1.Name = "employeesUserControl1";
            this.employeesUserControl1.Size = new System.Drawing.Size(1700, 966);
            this.employeesUserControl1.TabIndex = 7;
            // 
            // supportUserControl1
            // 
            this.supportUserControl1.BackColor = System.Drawing.Color.White;
            this.supportUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportUserControl1.Location = new System.Drawing.Point(0, -1);
            this.supportUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.supportUserControl1.Name = "supportUserControl1";
            this.supportUserControl1.Size = new System.Drawing.Size(1700, 966);
            this.supportUserControl1.TabIndex = 6;
            // 
            // customerUserControl1
            // 
            this.customerUserControl1.BackColor = System.Drawing.Color.White;
            this.customerUserControl1.Location = new System.Drawing.Point(0, -1);
            this.customerUserControl1.Name = "customerUserControl1";
            this.customerUserControl1.Size = new System.Drawing.Size(1700, 966);
            this.customerUserControl1.TabIndex = 5;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TimerToFrontPage
            // 
            this.TimerToFrontPage.Tick += new System.EventHandler(this.TimerToFrontPage_Tick);
            // 
            // FrontPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1910, 1017);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynsPunkt";
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button MinimizeApp;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.PictureBox Logo;
        private new System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private ProductsUserControl customerUserControl1;
        private FrontPageUserControl frontPageUserControl1;
        private ProductsUserControl productsUserControl1;
        private OrderUserControl orderUserControl1;
        public CustomerUserControl customerUserControl2;
        private SupportUserControl supportUserControl1;
        private EmployeesUserControl employeesUserControl1;
        private System.Windows.Forms.Button ButtonMailFrontPage;
        private MailUserControl mailUserControl1;
        private System.Windows.Forms.Label TimeToFrontPage;
        private System.Windows.Forms.Timer TimerToFrontPage;
    }
}

