namespace KundeVindueSynspunkt
{
    partial class SearchProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProducts));
            this.label5 = new System.Windows.Forms.Label();
            this.NewCustomer = new System.Windows.Forms.Label();
            this.ProductTable = new System.Windows.Forms.TableLayoutPanel();
            this.BinocularsSearchButton = new System.Windows.Forms.Button();
            this.CointactLensesSearchButton = new System.Windows.Forms.Button();
            this.GlassesSearchButton = new System.Windows.Forms.Button();
            this.NewCustomerButtonBack = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SearchGlassesWindow = new KundeVindueSynspunkt.SearchGlassesWindow();
            this.searchContactLensesWindow1 = new KundeVindueSynspunkt.SearchContactLensesWindow();
            this.searchBinocularsWindow1 = new KundeVindueSynspunkt.SearchBinocularsWindow();
            this.ProductTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "SynsPunkt";
            // 
            // NewCustomer
            // 
            this.NewCustomer.AutoSize = true;
            this.NewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.NewCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.NewCustomer.Location = new System.Drawing.Point(502, 12);
            this.NewCustomer.Name = "NewCustomer";
            this.NewCustomer.Size = new System.Drawing.Size(596, 86);
            this.NewCustomer.TabIndex = 17;
            this.NewCustomer.Text = "Search Products";
            // 
            // ProductTable
            // 
            this.ProductTable.ColumnCount = 3;
            this.ProductTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ProductTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ProductTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ProductTable.Controls.Add(this.BinocularsSearchButton, 2, 0);
            this.ProductTable.Controls.Add(this.CointactLensesSearchButton, 1, 0);
            this.ProductTable.Controls.Add(this.GlassesSearchButton, 0, 0);
            this.ProductTable.Location = new System.Drawing.Point(33, 146);
            this.ProductTable.Name = "ProductTable";
            this.ProductTable.RowCount = 1;
            this.ProductTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 481F));
            this.ProductTable.Size = new System.Drawing.Size(1535, 481);
            this.ProductTable.TabIndex = 18;
            // 
            // BinocularsSearchButton
            // 
            this.BinocularsSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BinocularsSearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BinocularsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinocularsSearchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BinocularsSearchButton.Location = new System.Drawing.Point(1173, 169);
            this.BinocularsSearchButton.Name = "BinocularsSearchButton";
            this.BinocularsSearchButton.Size = new System.Drawing.Size(210, 143);
            this.BinocularsSearchButton.TabIndex = 2;
            this.BinocularsSearchButton.Text = "Binoculars";
            this.BinocularsSearchButton.UseVisualStyleBackColor = false;
            this.BinocularsSearchButton.Click += new System.EventHandler(this.BinocularsSearchButton_Click);
            // 
            // CointactLensesSearchButton
            // 
            this.CointactLensesSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CointactLensesSearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CointactLensesSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CointactLensesSearchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CointactLensesSearchButton.Location = new System.Drawing.Point(661, 169);
            this.CointactLensesSearchButton.Name = "CointactLensesSearchButton";
            this.CointactLensesSearchButton.Size = new System.Drawing.Size(210, 143);
            this.CointactLensesSearchButton.TabIndex = 1;
            this.CointactLensesSearchButton.Text = "Contact Lenses";
            this.CointactLensesSearchButton.UseVisualStyleBackColor = false;
            this.CointactLensesSearchButton.Click += new System.EventHandler(this.CointactLensesSearchButton_Click);
            // 
            // GlassesSearchButton
            // 
            this.GlassesSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GlassesSearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.GlassesSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlassesSearchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GlassesSearchButton.Location = new System.Drawing.Point(150, 169);
            this.GlassesSearchButton.Name = "GlassesSearchButton";
            this.GlassesSearchButton.Size = new System.Drawing.Size(210, 143);
            this.GlassesSearchButton.TabIndex = 0;
            this.GlassesSearchButton.Text = "Glasses";
            this.GlassesSearchButton.UseVisualStyleBackColor = false;
            this.GlassesSearchButton.Click += new System.EventHandler(this.GlassesSearchButton_Click);
            // 
            // NewCustomerButtonBack
            // 
            this.NewCustomerButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCustomerButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerButtonBack.ForeColor = System.Drawing.SystemColors.Control;
            this.NewCustomerButtonBack.Location = new System.Drawing.Point(3, 665);
            this.NewCustomerButtonBack.Name = "NewCustomerButtonBack";
            this.NewCustomerButtonBack.Size = new System.Drawing.Size(377, 127);
            this.NewCustomerButtonBack.TabIndex = 21;
            this.NewCustomerButtonBack.Text = "Back";
            this.NewCustomerButtonBack.UseVisualStyleBackColor = true;
            this.NewCustomerButtonBack.Click += new System.EventHandler(this.NewCustomerButtonBack_Click);
            // 
            // Logo
            // 
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.Image = global::KundeVindueSynspunkt.Properties.Resources.Logo;
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(160, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(100, 50);
            this.Logo.TabIndex = 16;
            this.Logo.TabStop = false;
            // 
            // SearchGlassesWindow
            // 
            this.SearchGlassesWindow.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchGlassesWindow.Location = new System.Drawing.Point(-1, -1);
            this.SearchGlassesWindow.Name = "SearchGlassesWindow";
            this.SearchGlassesWindow.Size = new System.Drawing.Size(1602, 795);
            this.SearchGlassesWindow.TabIndex = 24;
            // 
            // searchContactLensesWindow1
            // 
            this.searchContactLensesWindow1.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchContactLensesWindow1.Location = new System.Drawing.Point(-1, -1);
            this.searchContactLensesWindow1.Name = "searchContactLensesWindow1";
            this.searchContactLensesWindow1.Size = new System.Drawing.Size(1602, 795);
            this.searchContactLensesWindow1.TabIndex = 25;
            // 
            // searchBinocularsWindow1
            // 
            this.searchBinocularsWindow1.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchBinocularsWindow1.Location = new System.Drawing.Point(0, 0);
            this.searchBinocularsWindow1.Name = "searchBinocularsWindow1";
            this.searchBinocularsWindow1.Size = new System.Drawing.Size(1602, 795);
            this.searchBinocularsWindow1.TabIndex = 26;
            // 
            // SearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NewCustomerButtonBack);
            this.Controls.Add(this.ProductTable);
            this.Controls.Add(this.NewCustomer);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchContactLensesWindow1);
            this.Controls.Add(this.SearchGlassesWindow);
            this.Controls.Add(this.searchBinocularsWindow1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "SearchProducts";
            this.Size = new System.Drawing.Size(1602, 795);
            this.ProductTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label NewCustomer;
        private System.Windows.Forms.TableLayoutPanel ProductTable;
        private System.Windows.Forms.Button BinocularsSearchButton;
        private System.Windows.Forms.Button CointactLensesSearchButton;
        private System.Windows.Forms.Button GlassesSearchButton;
        private System.Windows.Forms.Button NewCustomerButtonBack;
        private SearchGlassesWindow SearchGlassesWindow;
        private SearchContactLensesWindow searchContactLensesWindow1;
        private SearchBinocularsWindow searchBinocularsWindow1;
    }
}
