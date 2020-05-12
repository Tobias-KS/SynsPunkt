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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ButtonShowAllProducts = new System.Windows.Forms.Button();
            this.UpdateProduktButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToLabelProducts = new System.Windows.Forms.Label();
            this.FromLabelProducts = new System.Windows.Forms.Label();
            this.ToDateProducts = new System.Windows.Forms.DateTimePicker();
            this.FromDateProducts = new System.Windows.Forms.DateTimePicker();
            this.PrintButtonProducts = new System.Windows.Forms.Button();
            this.ThenByDropDownBoxProducts = new System.Windows.Forms.ComboBox();
            this.ThenByLabelProducts = new System.Windows.Forms.Label();
            this.SortyByLabelProducts = new System.Windows.Forms.Label();
            this.SortByDropDownBoxProducts = new System.Windows.Forms.ComboBox();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
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
            this.AddProductButton.Location = new System.Drawing.Point(376, 11);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(210, 100);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddProductButton.UseVisualStyleBackColor = false;
            // 
            // ButtonShowAllProducts
            // 
            this.ButtonShowAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonShowAllProducts.FlatAppearance.BorderSize = 0;
            this.ButtonShowAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowAllProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowAllProducts.ForeColor = System.Drawing.Color.White;
            this.ButtonShowAllProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowAllProducts.Location = new System.Drawing.Point(127, 11);
            this.ButtonShowAllProducts.Name = "ButtonShowAllProducts";
            this.ButtonShowAllProducts.Size = new System.Drawing.Size(210, 100);
            this.ButtonShowAllProducts.TabIndex = 2;
            this.ButtonShowAllProducts.Text = "Show all";
            this.ButtonShowAllProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowAllProducts.UseVisualStyleBackColor = false;
            // 
            // UpdateProduktButton
            // 
            this.UpdateProduktButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.UpdateProduktButton.FlatAppearance.BorderSize = 0;
            this.UpdateProduktButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProduktButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProduktButton.ForeColor = System.Drawing.Color.White;
            this.UpdateProduktButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateProduktButton.Location = new System.Drawing.Point(632, 11);
            this.UpdateProduktButton.Name = "UpdateProduktButton";
            this.UpdateProduktButton.Size = new System.Drawing.Size(210, 100);
            this.UpdateProduktButton.TabIndex = 3;
            this.UpdateProduktButton.Text = "Update";
            this.UpdateProduktButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateProduktButton.UseVisualStyleBackColor = false;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.DeleteProductButton.FlatAppearance.BorderSize = 0;
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.ForeColor = System.Drawing.Color.White;
            this.DeleteProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteProductButton.Location = new System.Drawing.Point(888, 11);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(210, 97);
            this.DeleteProductButton.TabIndex = 4;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ButtonShowAllProducts);
            this.panel2.Controls.Add(this.DeleteProductButton);
            this.panel2.Controls.Add(this.AddProductButton);
            this.panel2.Controls.Add(this.UpdateProduktButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 118);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 10);
            this.panel1.TabIndex = 3;
            // 
            // ToLabelProducts
            // 
            this.ToLabelProducts.AutoSize = true;
            this.ToLabelProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabelProducts.Location = new System.Drawing.Point(643, 134);
            this.ToLabelProducts.Name = "ToLabelProducts";
            this.ToLabelProducts.Size = new System.Drawing.Size(28, 21);
            this.ToLabelProducts.TabIndex = 32;
            this.ToLabelProducts.Text = "To";
            // 
            // FromLabelProducts
            // 
            this.FromLabelProducts.AutoSize = true;
            this.FromLabelProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabelProducts.Location = new System.Drawing.Point(520, 134);
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
            this.ToDateProducts.Location = new System.Drawing.Point(647, 165);
            this.ToDateProducts.Name = "ToDateProducts";
            this.ToDateProducts.Size = new System.Drawing.Size(113, 29);
            this.ToDateProducts.TabIndex = 30;
            // 
            // FromDateProducts
            // 
            this.FromDateProducts.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateProducts.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateProducts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateProducts.Location = new System.Drawing.Point(524, 165);
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
            this.PrintButtonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButtonProducts.Location = new System.Drawing.Point(1578, 887);
            this.PrintButtonProducts.Name = "PrintButtonProducts";
            this.PrintButtonProducts.Size = new System.Drawing.Size(87, 45);
            this.PrintButtonProducts.TabIndex = 28;
            this.PrintButtonProducts.Text = "Print";
            this.PrintButtonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButtonProducts.UseVisualStyleBackColor = false;
            // 
            // ThenByDropDownBoxProducts
            // 
            this.ThenByDropDownBoxProducts.BackColor = System.Drawing.Color.White;
            this.ThenByDropDownBoxProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByDropDownBoxProducts.FormattingEnabled = true;
            this.ThenByDropDownBoxProducts.Location = new System.Drawing.Point(234, 165);
            this.ThenByDropDownBoxProducts.Name = "ThenByDropDownBoxProducts";
            this.ThenByDropDownBoxProducts.Size = new System.Drawing.Size(206, 29);
            this.ThenByDropDownBoxProducts.TabIndex = 27;
            // 
            // ThenByLabelProducts
            // 
            this.ThenByLabelProducts.AutoSize = true;
            this.ThenByLabelProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByLabelProducts.Location = new System.Drawing.Point(230, 134);
            this.ThenByLabelProducts.Name = "ThenByLabelProducts";
            this.ThenByLabelProducts.Size = new System.Drawing.Size(140, 21);
            this.ThenByLabelProducts.TabIndex = 26;
            this.ThenByLabelProducts.Text = "And then sort by";
            // 
            // SortyByLabelProducts
            // 
            this.SortyByLabelProducts.AutoSize = true;
            this.SortyByLabelProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortyByLabelProducts.Location = new System.Drawing.Point(18, 134);
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
            this.SortByDropDownBoxProducts.Location = new System.Drawing.Point(22, 165);
            this.SortByDropDownBoxProducts.Name = "SortByDropDownBoxProducts";
            this.SortByDropDownBoxProducts.Size = new System.Drawing.Size(206, 29);
            this.SortByDropDownBoxProducts.TabIndex = 23;
            // 
            // ProductList
            // 
            this.ProductList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 21;
            this.ProductList.Location = new System.Drawing.Point(22, 202);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(1643, 676);
            this.ProductList.TabIndex = 22;
            // 
            // ProductsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ToLabelProducts);
            this.Controls.Add(this.FromLabelProducts);
            this.Controls.Add(this.ToDateProducts);
            this.Controls.Add(this.FromDateProducts);
            this.Controls.Add(this.PrintButtonProducts);
            this.Controls.Add(this.ThenByDropDownBoxProducts);
            this.Controls.Add(this.ThenByLabelProducts);
            this.Controls.Add(this.SortyByLabelProducts);
            this.Controls.Add(this.SortByDropDownBoxProducts);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ProductsUserControl";
            this.Size = new System.Drawing.Size(1700, 966);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ButtonShowAllProducts;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button UpdateProduktButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ToLabelProducts;
        private System.Windows.Forms.Label FromLabelProducts;
        private System.Windows.Forms.DateTimePicker ToDateProducts;
        private System.Windows.Forms.DateTimePicker FromDateProducts;
        private System.Windows.Forms.Button PrintButtonProducts;
        private System.Windows.Forms.ComboBox ThenByDropDownBoxProducts;
        private System.Windows.Forms.Label ThenByLabelProducts;
        private System.Windows.Forms.Label SortyByLabelProducts;
        private System.Windows.Forms.ComboBox SortByDropDownBoxProducts;
        private System.Windows.Forms.ListBox ProductList;
    }
}
