namespace KundeVindueSynspunkt
{
    partial class SearchContactLensesWindow
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
            this.LensPriceBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LensProductsClearBtn = new System.Windows.Forms.Button();
            this.LensesDataView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LensProductsSearchBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LensStrengthLeftText = new System.Windows.Forms.TextBox();
            this.LensStrengthRightText = new System.Windows.Forms.TextBox();
            this.LensesProductsBackBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LensePrice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LensQuantityText = new System.Windows.Forms.TextBox();
            this.BrandLensListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.LensPriceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LensesDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LensPriceBar
            // 
            this.LensPriceBar.BackColor = System.Drawing.SystemColors.Window;
            this.LensPriceBar.LargeChange = 500;
            this.LensPriceBar.Location = new System.Drawing.Point(0, 16);
            this.LensPriceBar.Maximum = 10000;
            this.LensPriceBar.Name = "LensPriceBar";
            this.LensPriceBar.Size = new System.Drawing.Size(368, 45);
            this.LensPriceBar.SmallChange = 100;
            this.LensPriceBar.TabIndex = 2;
            this.LensPriceBar.TickFrequency = 500;
            this.LensPriceBar.Value = 1000;
            this.LensPriceBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Price";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(3, 0);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(69, 25);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Minimum";
            // 
            // LensProductsClearBtn
            // 
            this.LensProductsClearBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.LensProductsClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LensProductsClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LensProductsClearBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LensProductsClearBtn.Location = new System.Drawing.Point(1232, 1);
            this.LensProductsClearBtn.Name = "LensProductsClearBtn";
            this.LensProductsClearBtn.Size = new System.Drawing.Size(361, 113);
            this.LensProductsClearBtn.TabIndex = 7;
            this.LensProductsClearBtn.Text = "Clear";
            this.LensProductsClearBtn.UseVisualStyleBackColor = true;
            this.LensProductsClearBtn.Click += new System.EventHandler(this.LensProductsClearBtn_Click);
            // 
            // LensesDataView
            // 
            this.LensesDataView.AllowUserToAddRows = false;
            this.LensesDataView.AllowUserToDeleteRows = false;
            this.LensesDataView.AllowUserToResizeColumns = false;
            this.LensesDataView.AllowUserToResizeRows = false;
            this.LensesDataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LensesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LensesDataView.Location = new System.Drawing.Point(383, 118);
            this.LensesDataView.MultiSelect = false;
            this.LensesDataView.Name = "LensesDataView";
            this.LensesDataView.ReadOnly = true;
            this.LensesDataView.Size = new System.Drawing.Size(1210, 636);
            this.LensesDataView.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Strength";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Maximum";
            // 
            // LensProductsSearchBtn
            // 
            this.LensProductsSearchBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.LensProductsSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LensProductsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LensProductsSearchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LensProductsSearchBtn.Location = new System.Drawing.Point(812, 1);
            this.LensProductsSearchBtn.Name = "LensProductsSearchBtn";
            this.LensProductsSearchBtn.Size = new System.Drawing.Size(361, 113);
            this.LensProductsSearchBtn.TabIndex = 9;
            this.LensProductsSearchBtn.Text = "Search";
            this.LensProductsSearchBtn.UseVisualStyleBackColor = true;
            this.LensProductsSearchBtn.Click += new System.EventHandler(this.LensProductsSearchBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Right";
            // 
            // LensStrengthLeftText
            // 
            this.LensStrengthLeftText.Location = new System.Drawing.Point(3, 167);
            this.LensStrengthLeftText.Name = "LensStrengthLeftText";
            this.LensStrengthLeftText.Size = new System.Drawing.Size(371, 20);
            this.LensStrengthLeftText.TabIndex = 13;
            // 
            // LensStrengthRightText
            // 
            this.LensStrengthRightText.Location = new System.Drawing.Point(3, 206);
            this.LensStrengthRightText.Name = "LensStrengthRightText";
            this.LensStrengthRightText.Size = new System.Drawing.Size(371, 20);
            this.LensStrengthRightText.TabIndex = 14;
            // 
            // LensesProductsBackBtn
            // 
            this.LensesProductsBackBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.LensesProductsBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LensesProductsBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LensesProductsBackBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LensesProductsBackBtn.Location = new System.Drawing.Point(386, 1);
            this.LensesProductsBackBtn.Name = "LensesProductsBackBtn";
            this.LensesProductsBackBtn.Size = new System.Drawing.Size(361, 113);
            this.LensesProductsBackBtn.TabIndex = 8;
            this.LensesProductsBackBtn.Text = "Back";
            this.LensesProductsBackBtn.UseVisualStyleBackColor = true;
            this.LensesProductsBackBtn.Click += new System.EventHandler(this.LensesProductsBackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LensePrice);
            this.panel1.Controls.Add(this.LensPriceBar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 88);
            this.panel1.TabIndex = 16;
            // 
            // LensePrice
            // 
            this.LensePrice.BackColor = System.Drawing.SystemColors.Highlight;
            this.LensePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LensePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LensePrice.Location = new System.Drawing.Point(69, 66);
            this.LensePrice.MaxLength = 5;
            this.LensePrice.Name = "LensePrice";
            this.LensePrice.ReadOnly = true;
            this.LensePrice.Size = new System.Drawing.Size(176, 19);
            this.LensePrice.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BrandLensListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.labelBrand, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LensStrengthLeftText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.LensQuantityText, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.LensStrengthRightText, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 789);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantity";
            // 
            // LensQuantityText
            // 
            this.LensQuantityText.Location = new System.Drawing.Point(3, 257);
            this.LensQuantityText.Name = "LensQuantityText";
            this.LensQuantityText.Size = new System.Drawing.Size(371, 20);
            this.LensQuantityText.TabIndex = 19;
            // 
            // BrandLensListBox
            // 
            this.BrandLensListBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.BrandLensListBox.FormattingEnabled = true;
            this.BrandLensListBox.Items.AddRange(new object[] {
            "Gant",
            "Tiger of Sweden",
            "Viktor-Rolf",
            "Kenzo",
            "Lacoste",
            "Henri Lioyd",
            "Diesel",
            "Lye and Scott",
            "Ivana Helsinki",
            "Marc Jacobs",
            "Ultralight",
            "HUGO boss",
            ""});
            this.BrandLensListBox.Location = new System.Drawing.Point(3, 28);
            this.BrandLensListBox.Name = "BrandLensListBox";
            this.BrandLensListBox.Size = new System.Drawing.Size(371, 95);
            this.BrandLensListBox.TabIndex = 10;
            // 
            // SearchContactLensesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.LensProductsClearBtn);
            this.Controls.Add(this.LensesDataView);
            this.Controls.Add(this.LensProductsSearchBtn);
            this.Controls.Add(this.LensesProductsBackBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchContactLensesWindow";
            this.Size = new System.Drawing.Size(1602, 795);
            ((System.ComponentModel.ISupportInitialize)(this.LensPriceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LensesDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar LensPriceBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LensProductsClearBtn;
        private System.Windows.Forms.DataGridView LensesDataView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button LensProductsSearchBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LensStrengthLeftText;
        private System.Windows.Forms.TextBox LensStrengthRightText;
        private System.Windows.Forms.Button LensesProductsBackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LensQuantityText;
        private System.Windows.Forms.TextBox LensePrice;
        private System.Windows.Forms.ListBox BrandLensListBox;
    }
}
