namespace UI
{
    partial class CustomerUserControl
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
            this.components = new System.ComponentModel.Container();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.ButtonShowAllCustomers = new System.Windows.Forms.Button();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SortByDropDownBoxCustomer = new System.Windows.Forms.ComboBox();
            this.SortyByLabelCustomers = new System.Windows.Forms.Label();
            this.ThenByLabelCustomers = new System.Windows.Forms.Label();
            this.ThenByDropDownBoxCustomer = new System.Windows.Forms.ComboBox();
            this.SortButtonCustomers = new System.Windows.Forms.Button();
            this.dataGridViewCustomerUserControl = new System.Windows.Forms.DataGridView();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.odensedbDataSet = new UI.odensedbDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new UI.odensedbDataSetTableAdapters.CustomersTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerUserControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odensedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCustomerButton.Location = new System.Drawing.Point(376, 11);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(210, 100);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // ButtonShowAllCustomers
            // 
            this.ButtonShowAllCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonShowAllCustomers.FlatAppearance.BorderSize = 0;
            this.ButtonShowAllCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowAllCustomers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowAllCustomers.ForeColor = System.Drawing.Color.White;
            this.ButtonShowAllCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowAllCustomers.Location = new System.Drawing.Point(127, 11);
            this.ButtonShowAllCustomers.Name = "ButtonShowAllCustomers";
            this.ButtonShowAllCustomers.Size = new System.Drawing.Size(210, 100);
            this.ButtonShowAllCustomers.TabIndex = 2;
            this.ButtonShowAllCustomers.Text = "Show all";
            this.ButtonShowAllCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowAllCustomers.UseVisualStyleBackColor = false;
            this.ButtonShowAllCustomers.Click += new System.EventHandler(this.ButtonShowAllCustomers_Click);
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.UpdateCustomerButton.FlatAppearance.BorderSize = 0;
            this.UpdateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustomerButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomerButton.ForeColor = System.Drawing.Color.White;
            this.UpdateCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateCustomerButton.Location = new System.Drawing.Point(632, 11);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(210, 100);
            this.UpdateCustomerButton.TabIndex = 3;
            this.UpdateCustomerButton.Text = "Update";
            this.UpdateCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateCustomerButton.UseVisualStyleBackColor = false;
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.DeleteCustomerButton.FlatAppearance.BorderSize = 0;
            this.DeleteCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCustomerButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCustomerButton.ForeColor = System.Drawing.Color.White;
            this.DeleteCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(888, 11);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(210, 97);
            this.DeleteCustomerButton.TabIndex = 4;
            this.DeleteCustomerButton.Text = "Delete";
            this.DeleteCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteCustomerButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ButtonShowAllCustomers);
            this.panel2.Controls.Add(this.DeleteCustomerButton);
            this.panel2.Controls.Add(this.AddCustomerButton);
            this.panel2.Controls.Add(this.UpdateCustomerButton);
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
            // SortByDropDownBoxCustomer
            // 
            this.SortByDropDownBoxCustomer.BackColor = System.Drawing.Color.White;
            this.SortByDropDownBoxCustomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SortByDropDownBoxCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByDropDownBoxCustomer.ForeColor = System.Drawing.Color.Black;
            this.SortByDropDownBoxCustomer.FormattingEnabled = true;
            this.SortByDropDownBoxCustomer.Location = new System.Drawing.Point(22, 165);
            this.SortByDropDownBoxCustomer.Name = "SortByDropDownBoxCustomer";
            this.SortByDropDownBoxCustomer.Size = new System.Drawing.Size(206, 29);
            this.SortByDropDownBoxCustomer.TabIndex = 4;
            this.SortByDropDownBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.SortByDropDownBox_SelectedIndexChanged);
            // 
            // SortyByLabelCustomers
            // 
            this.SortyByLabelCustomers.AutoSize = true;
            this.SortyByLabelCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortyByLabelCustomers.Location = new System.Drawing.Point(18, 134);
            this.SortyByLabelCustomers.Name = "SortyByLabelCustomers";
            this.SortyByLabelCustomers.Size = new System.Drawing.Size(63, 21);
            this.SortyByLabelCustomers.TabIndex = 5;
            this.SortyByLabelCustomers.Text = "Sort by";
            // 
            // ThenByLabelCustomers
            // 
            this.ThenByLabelCustomers.AutoSize = true;
            this.ThenByLabelCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByLabelCustomers.Location = new System.Drawing.Point(230, 134);
            this.ThenByLabelCustomers.Name = "ThenByLabelCustomers";
            this.ThenByLabelCustomers.Size = new System.Drawing.Size(140, 21);
            this.ThenByLabelCustomers.TabIndex = 6;
            this.ThenByLabelCustomers.Text = "And then sort by";
            // 
            // ThenByDropDownBoxCustomer
            // 
            this.ThenByDropDownBoxCustomer.BackColor = System.Drawing.Color.White;
            this.ThenByDropDownBoxCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByDropDownBoxCustomer.FormattingEnabled = true;
            this.ThenByDropDownBoxCustomer.Location = new System.Drawing.Point(234, 165);
            this.ThenByDropDownBoxCustomer.Name = "ThenByDropDownBoxCustomer";
            this.ThenByDropDownBoxCustomer.Size = new System.Drawing.Size(206, 29);
            this.ThenByDropDownBoxCustomer.TabIndex = 7;
            // 
            // SortButtonCustomers
            // 
            this.SortButtonCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.SortButtonCustomers.FlatAppearance.BorderSize = 0;
            this.SortButtonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButtonCustomers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButtonCustomers.ForeColor = System.Drawing.Color.White;
            this.SortButtonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SortButtonCustomers.Location = new System.Drawing.Point(458, 163);
            this.SortButtonCustomers.Name = "SortButtonCustomers";
            this.SortButtonCustomers.Size = new System.Drawing.Size(101, 33);
            this.SortButtonCustomers.TabIndex = 5;
            this.SortButtonCustomers.Text = "Sort";
            this.SortButtonCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SortButtonCustomers.UseVisualStyleBackColor = false;
            this.SortButtonCustomers.Click += new System.EventHandler(this.SortButtonCustomers_Click);
            // 
            // dataGridViewCustomerUserControl
            // 
            this.dataGridViewCustomerUserControl.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewCustomerUserControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomerUserControl.ColumnHeadersHeight = 30;
            this.dataGridViewCustomerUserControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomerUserControl.Location = new System.Drawing.Point(22, 202);
            this.dataGridViewCustomerUserControl.Name = "dataGridViewCustomerUserControl";
            this.dataGridViewCustomerUserControl.Size = new System.Drawing.Size(1150, 529);
            this.dataGridViewCustomerUserControl.TabIndex = 8;
            this.dataGridViewCustomerUserControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerUserControl_CellContentClick);
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.odensedbDataSet;
            // 
            // odensedbDataSet
            // 
            this.odensedbDataSet.DataSetName = "odensedbDataSet";
            this.odensedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(74, 364);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(0, 0);
            this.dataGridView2.TabIndex = 9;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.odensedbDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewCustomerUserControl);
            this.Controls.Add(this.SortButtonCustomers);
            this.Controls.Add(this.ThenByDropDownBoxCustomer);
            this.Controls.Add(this.ThenByLabelCustomers);
            this.Controls.Add(this.SortyByLabelCustomers);
            this.Controls.Add(this.SortByDropDownBoxCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(1211, 774);
            this.Load += new System.EventHandler(this.CustomerUserControl_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerUserControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odensedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button ButtonShowAllCustomers;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SortByDropDownBoxCustomer;
        private System.Windows.Forms.Label SortyByLabelCustomers;
        private System.Windows.Forms.Label ThenByLabelCustomers;
        private System.Windows.Forms.ComboBox ThenByDropDownBoxCustomer;
        private System.Windows.Forms.Button SortButtonCustomers;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private odensedbDataSet odensedbDataSet;
        private odensedbDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCustomerUserControl;
        private System.Windows.Forms.BindingSource customersBindingSource1;
    }
}
