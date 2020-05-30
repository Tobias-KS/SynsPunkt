namespace KundeVindueSynspunkt
{
    partial class SearchBinocularsWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BinocularsPrice = new System.Windows.Forms.TextBox();
            this.BinocularsPriceBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BinocularsStrenghtText = new System.Windows.Forms.TextBox();
            this.BinocularsProductsClearBtn = new System.Windows.Forms.Button();
            this.BinocularsDataView = new System.Windows.Forms.DataGridView();
            this.BinocularsProductsSearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.BinocularsProductsBackBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchBinocularsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BinocularTypeList = new System.Windows.Forms.ListBox();
            this.BinocularsListBoxColour = new System.Windows.Forms.ListBox();
            this.BinocularBrandList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinocularsPriceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinocularsDataView)).BeginInit();
            this.SearchBinocularsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BinocularsPrice);
            this.panel1.Controls.Add(this.BinocularsPriceBar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 87);
            this.panel1.TabIndex = 16;
            // 
            // BinocularsPrice
            // 
            this.BinocularsPrice.BackColor = System.Drawing.SystemColors.Highlight;
            this.BinocularsPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BinocularsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinocularsPrice.Location = new System.Drawing.Point(80, 65);
            this.BinocularsPrice.MaxLength = 5;
            this.BinocularsPrice.Name = "BinocularsPrice";
            this.BinocularsPrice.ReadOnly = true;
            this.BinocularsPrice.Size = new System.Drawing.Size(176, 19);
            this.BinocularsPrice.TabIndex = 21;
            // 
            // BinocularsPriceBar
            // 
            this.BinocularsPriceBar.BackColor = System.Drawing.SystemColors.Window;
            this.BinocularsPriceBar.LargeChange = 500;
            this.BinocularsPriceBar.Location = new System.Drawing.Point(0, 16);
            this.BinocularsPriceBar.Maximum = 10000;
            this.BinocularsPriceBar.Name = "BinocularsPriceBar";
            this.BinocularsPriceBar.Size = new System.Drawing.Size(368, 45);
            this.BinocularsPriceBar.SmallChange = 100;
            this.BinocularsPriceBar.TabIndex = 2;
            this.BinocularsPriceBar.TickFrequency = 500;
            this.BinocularsPriceBar.Value = 5000;
            this.BinocularsPriceBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Maximum";
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
            // BinocularsStrenghtText
            // 
            this.BinocularsStrenghtText.Location = new System.Drawing.Point(3, 280);
            this.BinocularsStrenghtText.Name = "BinocularsStrenghtText";
            this.BinocularsStrenghtText.Size = new System.Drawing.Size(371, 20);
            this.BinocularsStrenghtText.TabIndex = 13;
            // 
            // BinocularsProductsClearBtn
            // 
            this.BinocularsProductsClearBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.BinocularsProductsClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BinocularsProductsClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinocularsProductsClearBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BinocularsProductsClearBtn.Location = new System.Drawing.Point(1232, 1);
            this.BinocularsProductsClearBtn.Name = "BinocularsProductsClearBtn";
            this.BinocularsProductsClearBtn.Size = new System.Drawing.Size(361, 113);
            this.BinocularsProductsClearBtn.TabIndex = 12;
            this.BinocularsProductsClearBtn.Text = "Clear";
            this.BinocularsProductsClearBtn.UseVisualStyleBackColor = true;
            this.BinocularsProductsClearBtn.Click += new System.EventHandler(this.BinocularsProductsClearBtn_Click);
            // 
            // BinocularsDataView
            // 
            this.BinocularsDataView.AllowUserToAddRows = false;
            this.BinocularsDataView.AllowUserToDeleteRows = false;
            this.BinocularsDataView.AllowUserToResizeColumns = false;
            this.BinocularsDataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BinocularsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BinocularsDataView.Location = new System.Drawing.Point(383, 118);
            this.BinocularsDataView.MultiSelect = false;
            this.BinocularsDataView.Name = "BinocularsDataView";
            this.BinocularsDataView.ReadOnly = true;
            this.BinocularsDataView.Size = new System.Drawing.Size(1210, 636);
            this.BinocularsDataView.TabIndex = 11;
            // 
            // BinocularsProductsSearchBtn
            // 
            this.BinocularsProductsSearchBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.BinocularsProductsSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BinocularsProductsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinocularsProductsSearchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BinocularsProductsSearchBtn.Location = new System.Drawing.Point(812, 1);
            this.BinocularsProductsSearchBtn.Name = "BinocularsProductsSearchBtn";
            this.BinocularsProductsSearchBtn.Size = new System.Drawing.Size(361, 113);
            this.BinocularsProductsSearchBtn.TabIndex = 14;
            this.BinocularsProductsSearchBtn.Text = "Search";
            this.BinocularsProductsSearchBtn.UseVisualStyleBackColor = true;
            this.BinocularsProductsSearchBtn.Click += new System.EventHandler(this.BinocularsProductsSearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Strength";
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
            // BinocularsProductsBackBtn
            // 
            this.BinocularsProductsBackBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.BinocularsProductsBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BinocularsProductsBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinocularsProductsBackBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BinocularsProductsBackBtn.Location = new System.Drawing.Point(386, 1);
            this.BinocularsProductsBackBtn.Name = "BinocularsProductsBackBtn";
            this.BinocularsProductsBackBtn.Size = new System.Drawing.Size(361, 113);
            this.BinocularsProductsBackBtn.TabIndex = 13;
            this.BinocularsProductsBackBtn.Text = "Back";
            this.BinocularsProductsBackBtn.UseVisualStyleBackColor = true;
            this.BinocularsProductsBackBtn.Click += new System.EventHandler(this.BinocularsProductsBackBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Price";
            // 
            // SearchBinocularsPanel
            // 
            this.SearchBinocularsPanel.ColumnCount = 1;
            this.SearchBinocularsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchBinocularsPanel.Controls.Add(this.label7, 0, 12);
            this.SearchBinocularsPanel.Controls.Add(this.labelBrand, 0, 0);
            this.SearchBinocularsPanel.Controls.Add(this.panel1, 0, 13);
            this.SearchBinocularsPanel.Controls.Add(this.BinocularsStrenghtText, 0, 5);
            this.SearchBinocularsPanel.Controls.Add(this.label4, 0, 4);
            this.SearchBinocularsPanel.Controls.Add(this.label1, 0, 2);
            this.SearchBinocularsPanel.Controls.Add(this.label2, 0, 6);
            this.SearchBinocularsPanel.Controls.Add(this.BinocularTypeList, 0, 3);
            this.SearchBinocularsPanel.Controls.Add(this.BinocularsListBoxColour, 0, 7);
            this.SearchBinocularsPanel.Controls.Add(this.BinocularBrandList, 0, 1);
            this.SearchBinocularsPanel.Location = new System.Drawing.Point(3, 4);
            this.SearchBinocularsPanel.Name = "SearchBinocularsPanel";
            this.SearchBinocularsPanel.RowCount = 14;
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchBinocularsPanel.Size = new System.Drawing.Size(377, 789);
            this.SearchBinocularsPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Colour";
            // 
            // BinocularTypeList
            // 
            this.BinocularTypeList.BackColor = System.Drawing.SystemColors.Highlight;
            this.BinocularTypeList.FormattingEnabled = true;
            this.BinocularTypeList.Items.AddRange(new object[] {
            "Regular",
            "Hunting",
            "Double",
            "Single"});
            this.BinocularTypeList.Location = new System.Drawing.Point(3, 154);
            this.BinocularTypeList.Name = "BinocularTypeList";
            this.BinocularTypeList.Size = new System.Drawing.Size(371, 95);
            this.BinocularTypeList.TabIndex = 22;
            // 
            // BinocularsListBoxColour
            // 
            this.BinocularsListBoxColour.BackColor = System.Drawing.SystemColors.Highlight;
            this.BinocularsListBoxColour.FormattingEnabled = true;
            this.BinocularsListBoxColour.Items.AddRange(new object[] {
            "Brown",
            "Green",
            "Military",
            "Black",
            "White"});
            this.BinocularsListBoxColour.Location = new System.Drawing.Point(3, 331);
            this.BinocularsListBoxColour.Name = "BinocularsListBoxColour";
            this.BinocularsListBoxColour.Size = new System.Drawing.Size(371, 95);
            this.BinocularsListBoxColour.TabIndex = 24;
            // 
            // BinocularBrandList
            // 
            this.BinocularBrandList.BackColor = System.Drawing.SystemColors.Highlight;
            this.BinocularBrandList.FormattingEnabled = true;
            this.BinocularBrandList.Items.AddRange(new object[] {
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
            "HUGO boss"});
            this.BinocularBrandList.Location = new System.Drawing.Point(3, 28);
            this.BinocularBrandList.Name = "BinocularBrandList";
            this.BinocularBrandList.Size = new System.Drawing.Size(371, 95);
            this.BinocularBrandList.TabIndex = 15;
            // 
            // SearchBinocularsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.BinocularsProductsClearBtn);
            this.Controls.Add(this.BinocularsDataView);
            this.Controls.Add(this.BinocularsProductsSearchBtn);
            this.Controls.Add(this.BinocularsProductsBackBtn);
            this.Controls.Add(this.SearchBinocularsPanel);
            this.Name = "SearchBinocularsWindow";
            this.Size = new System.Drawing.Size(1602, 795);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinocularsPriceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinocularsDataView)).EndInit();
            this.SearchBinocularsPanel.ResumeLayout(false);
            this.SearchBinocularsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar BinocularsPriceBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BinocularsStrenghtText;
        private System.Windows.Forms.Button BinocularsProductsClearBtn;
        private System.Windows.Forms.DataGridView BinocularsDataView;
        private System.Windows.Forms.Button BinocularsProductsSearchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Button BinocularsProductsBackBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel SearchBinocularsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BinocularsPrice;
        private System.Windows.Forms.ListBox BinocularTypeList;
        private System.Windows.Forms.ListBox BinocularsListBoxColour;
        private System.Windows.Forms.ListBox BinocularBrandList;
    }
}
