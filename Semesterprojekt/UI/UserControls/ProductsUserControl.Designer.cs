namespace UI
{
    partial class ProductsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ToLabelProducts = new System.Windows.Forms.Label();
            this.FromLabelProducts = new System.Windows.Forms.Label();
            this.ToDateProducts = new System.Windows.Forms.DateTimePicker();
            this.FromDateProducts = new System.Windows.Forms.DateTimePicker();
            this.PrintButtonProducts = new System.Windows.Forms.Button();
            this.ThenByDropDownBoxProducts = new System.Windows.Forms.ComboBox();
            this.ThenByLabelProducts = new System.Windows.Forms.Label();
            this.SortyByLabelProducts = new System.Windows.Forms.Label();
            this.SortByDropDownBoxProducts = new System.Windows.Forms.ComboBox();
            this.dataGridViewProductUserControl = new System.Windows.Forms.DataGridView();
            this.NameOfFileProductsUserContolPrint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductUserControl)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductButton.Location = new System.Drawing.Point(22, 57);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(150, 36);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Add product";
            this.AddProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddProductButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 26);
            this.panel2.TabIndex = 2;
            // 
            // ToLabelProducts
            // 
            this.ToLabelProducts.AutoSize = true;
            this.ToLabelProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabelProducts.Location = new System.Drawing.Point(1353, 45);
            this.ToLabelProducts.Name = "ToLabelProducts";
            this.ToLabelProducts.Size = new System.Drawing.Size(28, 21);
            this.ToLabelProducts.TabIndex = 32;
            this.ToLabelProducts.Text = "To";
            // 
            // FromLabelProducts
            // 
            this.FromLabelProducts.AutoSize = true;
            this.FromLabelProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabelProducts.Location = new System.Drawing.Point(1230, 45);
            this.FromLabelProducts.Name = "FromLabelProducts";
            this.FromLabelProducts.Size = new System.Drawing.Size(52, 21);
            this.FromLabelProducts.TabIndex = 31;
            this.FromLabelProducts.Text = "From ";
            // 
            // ToDateProducts
            // 
            this.ToDateProducts.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateProducts.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateProducts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateProducts.Location = new System.Drawing.Point(1357, 76);
            this.ToDateProducts.Name = "ToDateProducts";
            this.ToDateProducts.Size = new System.Drawing.Size(113, 29);
            this.ToDateProducts.TabIndex = 30;
            // 
            // FromDateProducts
            // 
            this.FromDateProducts.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateProducts.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateProducts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateProducts.Location = new System.Drawing.Point(1234, 76);
            this.FromDateProducts.Name = "FromDateProducts";
            this.FromDateProducts.Size = new System.Drawing.Size(117, 29);
            this.FromDateProducts.TabIndex = 29;
            // 
            // PrintButtonProducts
            // 
            this.PrintButtonProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.PrintButtonProducts.FlatAppearance.BorderSize = 0;
            this.PrintButtonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButtonProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButtonProducts.ForeColor = System.Drawing.Color.White;
            this.PrintButtonProducts.Image = ((System.Drawing.Image)(resources.GetObject("PrintButtonProducts.Image")));
            this.PrintButtonProducts.Location = new System.Drawing.Point(1528, 908);
            this.PrintButtonProducts.Name = "PrintButtonProducts";
            this.PrintButtonProducts.Size = new System.Drawing.Size(137, 33);
            this.PrintButtonProducts.TabIndex = 28;
            this.PrintButtonProducts.Text = "Print";
            this.PrintButtonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButtonProducts.UseVisualStyleBackColor = false;
            this.PrintButtonProducts.Click += new System.EventHandler(this.PrintButtonProducts_Click);
            // 
            // ThenByDropDownBoxProducts
            // 
            this.ThenByDropDownBoxProducts.BackColor = System.Drawing.Color.White;
            this.ThenByDropDownBoxProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByDropDownBoxProducts.FormattingEnabled = true;
            this.ThenByDropDownBoxProducts.Location = new System.Drawing.Point(944, 76);
            this.ThenByDropDownBoxProducts.Name = "ThenByDropDownBoxProducts";
            this.ThenByDropDownBoxProducts.Size = new System.Drawing.Size(206, 29);
            this.ThenByDropDownBoxProducts.TabIndex = 27;
            // 
            // ThenByLabelProducts
            // 
            this.ThenByLabelProducts.AutoSize = true;
            this.ThenByLabelProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByLabelProducts.Location = new System.Drawing.Point(940, 45);
            this.ThenByLabelProducts.Name = "ThenByLabelProducts";
            this.ThenByLabelProducts.Size = new System.Drawing.Size(140, 21);
            this.ThenByLabelProducts.TabIndex = 26;
            this.ThenByLabelProducts.Text = "And then sort by";
            // 
            // SortyByLabelProducts
            // 
            this.SortyByLabelProducts.AutoSize = true;
            this.SortyByLabelProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortyByLabelProducts.Location = new System.Drawing.Point(728, 45);
            this.SortyByLabelProducts.Name = "SortyByLabelProducts";
            this.SortyByLabelProducts.Size = new System.Drawing.Size(63, 21);
            this.SortyByLabelProducts.TabIndex = 25;
            this.SortyByLabelProducts.Text = "Sort by";
            // 
            // SortByDropDownBoxProducts
            // 
            this.SortByDropDownBoxProducts.BackColor = System.Drawing.Color.White;
            this.SortByDropDownBoxProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByDropDownBoxProducts.FormattingEnabled = true;
            this.SortByDropDownBoxProducts.Location = new System.Drawing.Point(732, 76);
            this.SortByDropDownBoxProducts.Name = "SortByDropDownBoxProducts";
            this.SortByDropDownBoxProducts.Size = new System.Drawing.Size(206, 29);
            this.SortByDropDownBoxProducts.TabIndex = 23;
            // 
            // dataGridViewProductUserControl
            // 
            this.dataGridViewProductUserControl.AllowUserToAddRows = false;
            this.dataGridViewProductUserControl.AllowUserToDeleteRows = false;
            this.dataGridViewProductUserControl.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProductUserControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductUserControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProductUserControl.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductUserControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductUserControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductUserControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductUserControl.ColumnHeadersHeight = 40;
            this.dataGridViewProductUserControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductUserControl.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductUserControl.GridColor = System.Drawing.Color.Black;
            this.dataGridViewProductUserControl.Location = new System.Drawing.Point(19, 111);
            this.dataGridViewProductUserControl.Name = "dataGridViewProductUserControl";
            this.dataGridViewProductUserControl.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductUserControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProductUserControl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewProductUserControl.RowTemplate.DividerHeight = 3;
            this.dataGridViewProductUserControl.RowTemplate.Height = 40;
            this.dataGridViewProductUserControl.Size = new System.Drawing.Size(1646, 774);
            this.dataGridViewProductUserControl.TabIndex = 33;
            // 
            // NameOfFileProductsUserContolPrint
            // 
            this.NameOfFileProductsUserContolPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfFileProductsUserContolPrint.Location = new System.Drawing.Point(1394, 912);
            this.NameOfFileProductsUserContolPrint.Name = "NameOfFileProductsUserContolPrint";
            this.NameOfFileProductsUserContolPrint.Size = new System.Drawing.Size(128, 27);
            this.NameOfFileProductsUserContolPrint.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1390, 888);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filename";
            // 
            // ProductsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfFileProductsUserContolPrint);
            this.Controls.Add(this.dataGridViewProductUserControl);
            this.Controls.Add(this.ToLabelProducts);
            this.Controls.Add(this.FromLabelProducts);
            this.Controls.Add(this.ToDateProducts);
            this.Controls.Add(this.FromDateProducts);
            this.Controls.Add(this.PrintButtonProducts);
            this.Controls.Add(this.ThenByDropDownBoxProducts);
            this.Controls.Add(this.ThenByLabelProducts);
            this.Controls.Add(this.SortyByLabelProducts);
            this.Controls.Add(this.SortByDropDownBoxProducts);
            this.Controls.Add(this.panel2);
            this.Name = "ProductsUserControl";
            this.Size = new System.Drawing.Size(1700, 966);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductUserControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ToLabelProducts;
        private System.Windows.Forms.Label FromLabelProducts;
        private System.Windows.Forms.DateTimePicker ToDateProducts;
        private System.Windows.Forms.DateTimePicker FromDateProducts;
        private System.Windows.Forms.Button PrintButtonProducts;
        private System.Windows.Forms.ComboBox ThenByDropDownBoxProducts;
        private System.Windows.Forms.Label ThenByLabelProducts;
        private System.Windows.Forms.Label SortyByLabelProducts;
        private System.Windows.Forms.ComboBox SortByDropDownBoxProducts;
        private System.Windows.Forms.DataGridView dataGridViewProductUserControl;
        private System.Windows.Forms.TextBox NameOfFileProductsUserContolPrint;
        private System.Windows.Forms.Label label1;
    }
}
