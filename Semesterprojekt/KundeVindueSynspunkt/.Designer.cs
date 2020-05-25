namespace KundeVindueSynspunkt
{
    partial class Customergreet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customergreet));
            this.aNewCustomerButton = new System.Windows.Forms.Button();
            this.aSearchProductsButton = new System.Windows.Forms.Button();
            this.StorenameWelcomepage = new System.Windows.Forms.Label();
            this.TimeWelcomeToSynspunkt = new System.Windows.Forms.Label();
            this.Label1WelcomeToSynspunkt = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.BottunMaximize = new System.Windows.Forms.Button();
            this.ButtonCloseWindow = new System.Windows.Forms.Button();
            this.LogoWelcomepage = new System.Windows.Forms.PictureBox();
            this.SearchGlasses = new KundeVindueSynspunkt.SearchProducts();
            this.NewCustomerPage = new KundeVindueSynspunkt.NewCustomerPage();
            ((System.ComponentModel.ISupportInitialize)(this.LogoWelcomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // aNewCustomerButton
            // 
            this.aNewCustomerButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.aNewCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aNewCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNewCustomerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.aNewCustomerButton.Location = new System.Drawing.Point(2, 666);
            this.aNewCustomerButton.Name = "aNewCustomerButton";
            this.aNewCustomerButton.Size = new System.Drawing.Size(377, 127);
            this.aNewCustomerButton.TabIndex = 0;
            this.aNewCustomerButton.Text = "New customer";
            this.aNewCustomerButton.UseVisualStyleBackColor = true;
            this.aNewCustomerButton.Click += new System.EventHandler(this.aNewCustomerButton_Click);
            // 
            // aSearchProductsButton
            // 
            this.aSearchProductsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.aSearchProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aSearchProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSearchProductsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.aSearchProductsButton.Location = new System.Drawing.Point(1223, 666);
            this.aSearchProductsButton.Name = "aSearchProductsButton";
            this.aSearchProductsButton.Size = new System.Drawing.Size(377, 127);
            this.aSearchProductsButton.TabIndex = 1;
            this.aSearchProductsButton.Text = "Search Products";
            this.aSearchProductsButton.UseVisualStyleBackColor = false;
            this.aSearchProductsButton.Click += new System.EventHandler(this.aSearchProductsButton_Click_1);
            // 
            // StorenameWelcomepage
            // 
            this.StorenameWelcomepage.AutoSize = true;
            this.StorenameWelcomepage.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorenameWelcomepage.ForeColor = System.Drawing.SystemColors.Control;
            this.StorenameWelcomepage.Location = new System.Drawing.Point(3, 12);
            this.StorenameWelcomepage.Name = "StorenameWelcomepage";
            this.StorenameWelcomepage.Size = new System.Drawing.Size(151, 36);
            this.StorenameWelcomepage.TabIndex = 15;
            this.StorenameWelcomepage.Text = "SynsPunkt";
            // 
            // TimeWelcomeToSynspunkt
            // 
            this.TimeWelcomeToSynspunkt.AutoSize = true;
            this.TimeWelcomeToSynspunkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeWelcomeToSynspunkt.Location = new System.Drawing.Point(762, 760);
            this.TimeWelcomeToSynspunkt.Name = "TimeWelcomeToSynspunkt";
            this.TimeWelcomeToSynspunkt.Size = new System.Drawing.Size(82, 20);
            this.TimeWelcomeToSynspunkt.TabIndex = 18;
            this.TimeWelcomeToSynspunkt.Text = "Lav tid her";
            // 
            // Label1WelcomeToSynspunkt
            // 
            this.Label1WelcomeToSynspunkt.AutoSize = true;
            this.Label1WelcomeToSynspunkt.Font = new System.Drawing.Font("MS Reference Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1WelcomeToSynspunkt.ForeColor = System.Drawing.SystemColors.Control;
            this.Label1WelcomeToSynspunkt.Location = new System.Drawing.Point(328, 33);
            this.Label1WelcomeToSynspunkt.Name = "Label1WelcomeToSynspunkt";
            this.Label1WelcomeToSynspunkt.Size = new System.Drawing.Size(919, 93);
            this.Label1WelcomeToSynspunkt.TabIndex = 2;
            this.Label1WelcomeToSynspunkt.Text = "Welcome to Synspunkt";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.Image = global::KundeVindueSynspunkt.Properties.Resources.arrows__1_;
            this.ButtonMinimize.Location = new System.Drawing.Point(1480, 3);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(30, 30);
            this.ButtonMinimize.TabIndex = 21;
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // BottunMaximize
            // 
            this.BottunMaximize.BackColor = System.Drawing.SystemColors.Highlight;
            this.BottunMaximize.Image = global::KundeVindueSynspunkt.Properties.Resources.interface__1_;
            this.BottunMaximize.Location = new System.Drawing.Point(1515, 3);
            this.BottunMaximize.Name = "BottunMaximize";
            this.BottunMaximize.Size = new System.Drawing.Size(30, 30);
            this.BottunMaximize.TabIndex = 20;
            this.BottunMaximize.UseVisualStyleBackColor = false;
            this.BottunMaximize.Click += new System.EventHandler(this.BottunMaximize_Click_1);
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonCloseWindow.FlatAppearance.BorderSize = 0;
            this.ButtonCloseWindow.Image = global::KundeVindueSynspunkt.Properties.Resources._interface;
            this.ButtonCloseWindow.Location = new System.Drawing.Point(1550, 3);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(30, 30);
            this.ButtonCloseWindow.TabIndex = 19;
            this.ButtonCloseWindow.UseVisualStyleBackColor = false;
            this.ButtonCloseWindow.Click += new System.EventHandler(this.ButtonCloseWindow_Click);
            // 
            // LogoWelcomepage
            // 
            this.LogoWelcomepage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("LogoWelcomepage.ErrorImage")));
            this.LogoWelcomepage.Image = global::KundeVindueSynspunkt.Properties.Resources.Logo;
            this.LogoWelcomepage.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoWelcomepage.InitialImage")));
            this.LogoWelcomepage.Location = new System.Drawing.Point(160, 3);
            this.LogoWelcomepage.Name = "LogoWelcomepage";
            this.LogoWelcomepage.Size = new System.Drawing.Size(100, 50);
            this.LogoWelcomepage.TabIndex = 16;
            this.LogoWelcomepage.TabStop = false;
            // 
            // SearchGlasses
            // 
            this.SearchGlasses.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchGlasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchGlasses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchGlasses.Location = new System.Drawing.Point(-1, -1);
            this.SearchGlasses.Name = "SearchGlasses";
            this.SearchGlasses.Size = new System.Drawing.Size(1602, 795);
            this.SearchGlasses.TabIndex = 23;
            // 
            // NewCustomerPage
            // 
            this.NewCustomerPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewCustomerPage.BackColor = System.Drawing.SystemColors.Highlight;
            this.NewCustomerPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewCustomerPage.Location = new System.Drawing.Point(-1, -1);
            this.NewCustomerPage.Name = "NewCustomerPage";
            this.NewCustomerPage.Size = new System.Drawing.Size(1602, 795);
            this.NewCustomerPage.TabIndex = 22;
            // 
            // Customergreet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1592, 785);
            this.ControlBox = false;
            this.Controls.Add(this.SearchGlasses);
            this.Controls.Add(this.NewCustomerPage);
            this.Controls.Add(this.Label1WelcomeToSynspunkt);
            this.Controls.Add(this.ButtonMinimize);
            this.Controls.Add(this.BottunMaximize);
            this.Controls.Add(this.ButtonCloseWindow);
            this.Controls.Add(this.TimeWelcomeToSynspunkt);
            this.Controls.Add(this.LogoWelcomepage);
            this.Controls.Add(this.StorenameWelcomepage);
            this.Controls.Add(this.aSearchProductsButton);
            this.Controls.Add(this.aNewCustomerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-1, -1);
            this.Name = "Customergreet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Customergreet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoWelcomepage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aNewCustomerButton;
        private System.Windows.Forms.Button aSearchProductsButton;
        private System.Windows.Forms.Label StorenameWelcomepage;
        private System.Windows.Forms.PictureBox LogoWelcomepage;
        private System.Windows.Forms.Label TimeWelcomeToSynspunkt;
        private System.Windows.Forms.Label Label1WelcomeToSynspunkt;
        private System.Windows.Forms.Button ButtonCloseWindow;
        private System.Windows.Forms.Button BottunMaximize;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Timer Timer1;
        private NewCustomerPage NewCustomerPage;
        private SearchProducts SearchGlasses;
    }
}

