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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrintButtonProducts = new System.Windows.Forms.Button();
            this.dataGridViewProductUserControl = new System.Windows.Forms.DataGridView();
            this.NameOfFileProductsUserContolPrint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.textBoxSearchProducts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
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
            // dataGridViewProductUserControl
            // 
            this.dataGridViewProductUserControl.AllowUserToAddRows = false;
            this.dataGridViewProductUserControl.AllowUserToDeleteRows = false;
            this.dataGridViewProductUserControl.AllowUserToResizeColumns = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProductUserControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewProductUserControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductUserControl.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductUserControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductUserControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductUserControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewProductUserControl.ColumnHeadersHeight = 40;
            this.dataGridViewProductUserControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductUserControl.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewProductUserControl.GridColor = System.Drawing.Color.Black;
            this.dataGridViewProductUserControl.Location = new System.Drawing.Point(19, 111);
            this.dataGridViewProductUserControl.MultiSelect = false;
            this.dataGridViewProductUserControl.Name = "dataGridViewProductUserControl";
            this.dataGridViewProductUserControl.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductUserControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // buttonResetFilter
            // 
            this.buttonResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.buttonResetFilter.FlatAppearance.BorderSize = 0;
            this.buttonResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetFilter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetFilter.ForeColor = System.Drawing.Color.White;
            this.buttonResetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResetFilter.Location = new System.Drawing.Point(1203, 57);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(150, 36);
            this.buttonResetFilter.TabIndex = 36;
            this.buttonResetFilter.Text = "Reset filter";
            this.buttonResetFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonResetFilter.UseVisualStyleBackColor = false;
            this.buttonResetFilter.Click += new System.EventHandler(this.buttonResetFilter_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.buttonDeleteProduct.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(1515, 57);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(150, 36);
            this.buttonDeleteProduct.TabIndex = 37;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.buttonEditProduct.FlatAppearance.BorderSize = 0;
            this.buttonEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProduct.ForeColor = System.Drawing.Color.White;
            this.buttonEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditProduct.Location = new System.Drawing.Point(1359, 57);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(150, 36);
            this.buttonEditProduct.TabIndex = 38;
            this.buttonEditProduct.Text = "Edit";
            this.buttonEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditProduct.UseVisualStyleBackColor = false;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // textBoxSearchProducts
            // 
            this.textBoxSearchProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchProducts.Location = new System.Drawing.Point(198, 66);
            this.textBoxSearchProducts.Name = "textBoxSearchProducts";
            this.textBoxSearchProducts.Size = new System.Drawing.Size(135, 27);
            this.textBoxSearchProducts.TabIndex = 39;
            this.textBoxSearchProducts.TextChanged += new System.EventHandler(this.textBoxSearchProducts_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Search";
            // 
            // ProductsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchProducts);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonResetFilter);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfFileProductsUserContolPrint);
            this.Controls.Add(this.dataGridViewProductUserControl);
            this.Controls.Add(this.PrintButtonProducts);
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
        private System.Windows.Forms.Button PrintButtonProducts;
        private System.Windows.Forms.DataGridView dataGridViewProductUserControl;
        private System.Windows.Forms.TextBox NameOfFileProductsUserContolPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResetFilter;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.TextBox textBoxSearchProducts;
        private System.Windows.Forms.Label label2;
    }
}
