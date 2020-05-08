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
            this.ProductList = new System.Windows.Forms.ListBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ButtonShowAllProducts = new System.Windows.Forms.Button();
            this.UpdateProduktButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 21;
            this.ProductList.Location = new System.Drawing.Point(724, 153);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(463, 550);
            this.ProductList.TabIndex = 0;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.CustomerList_SelectedIndexChanged);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductButton.Location = new System.Drawing.Point(374, 11);
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
            this.ButtonShowAllProducts.Location = new System.Drawing.Point(118, 11);
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
            this.UpdateProduktButton.Location = new System.Drawing.Point(630, 11);
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
            this.DeleteProductButton.Location = new System.Drawing.Point(886, 11);
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
            this.panel2.Size = new System.Drawing.Size(1211, 118);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 10);
            this.panel1.TabIndex = 3;
            // 
            // ProductsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ProductList);
            this.Name = "ProductsUserControl";
            this.Size = new System.Drawing.Size(1211, 774);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ButtonShowAllProducts;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button UpdateProduktButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
