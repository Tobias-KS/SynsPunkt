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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MinimizeApp = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.CompanyName = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ProductsButton);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.CompanyName);
            this.panel1.Controls.Add(this.CustomersButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 825);
            this.panel1.TabIndex = 0;
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
            this.CustomersButton.Location = new System.Drawing.Point(0, 124);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(210, 89);
            this.CustomersButton.TabIndex = 0;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomersButton.UseVisualStyleBackColor = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.TopPanel.Controls.Add(this.MinimizeApp);
            this.TopPanel.Controls.Add(this.CloseApp);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(210, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1211, 51);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // MinimizeApp
            // 
            this.MinimizeApp.FlatAppearance.BorderSize = 0;
            this.MinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeApp.ForeColor = System.Drawing.Color.White;
            this.MinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeApp.Image")));
            this.MinimizeApp.Location = new System.Drawing.Point(1101, 3);
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
            this.CloseApp.Location = new System.Drawing.Point(1160, 12);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(25, 26);
            this.CloseApp.TabIndex = 2;
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
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
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(160, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(64, 52);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
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
            this.ProductsButton.Location = new System.Drawing.Point(0, 219);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(210, 89);
            this.ProductsButton.TabIndex = 4;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductsButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 89);
            this.button2.TabIndex = 5;
            this.button2.Text = "Orders";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 733);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 89);
            this.button3.TabIndex = 6;
            this.button3.Text = "Support";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 89);
            this.button1.TabIndex = 7;
            this.button1.Text = "Employees";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrontPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1421, 825);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynsPunkt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button MinimizeApp;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button button1;
    }
}

