using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            CustomerUserControl.dataGridViewCustomerUserControl = new System.Windows.Forms.DataGridView();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.odensedbDataSet = new UI.odensedbDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new UI.odensedbDataSetTableAdapters.CustomersTableAdapter();
            this.ResetfiltersButtonCustomers = new System.Windows.Forms.Button();
            this.SeachTextBoxCustomerUserControl = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.PrintCustomersButton = new System.Windows.Forms.Button();
            this.NameOnFile = new System.Windows.Forms.TextBox();
            this.ToLabelCustomer = new System.Windows.Forms.Label();
            this.FromLabelCustomer = new System.Windows.Forms.Label();
            this.ToDateCustomer = new System.Windows.Forms.DateTimePicker();
            this.FromDateCustomer = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(CustomerUserControl.dataGridViewCustomerUserControl)).BeginInit();
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
            this.AddCustomerButton.Location = new System.Drawing.Point(22, 67);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(121, 34);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Add new";
            this.AddCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 30);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewCustomerUserControl
            // 
            CustomerUserControl.dataGridViewCustomerUserControl.AllowUserToAddRows = false;
            CustomerUserControl.dataGridViewCustomerUserControl.AllowUserToDeleteRows = false;
            CustomerUserControl.dataGridViewCustomerUserControl.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            CustomerUserControl.dataGridViewCustomerUserControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CustomerUserControl.dataGridViewCustomerUserControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            CustomerUserControl.dataGridViewCustomerUserControl.BackgroundColor = System.Drawing.Color.White;
            CustomerUserControl.dataGridViewCustomerUserControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CustomerUserControl.dataGridViewCustomerUserControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            CustomerUserControl.dataGridViewCustomerUserControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomerUserControl.dataGridViewCustomerUserControl.ColumnHeadersHeight = 40;
            CustomerUserControl.dataGridViewCustomerUserControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            CustomerUserControl.dataGridViewCustomerUserControl.DefaultCellStyle = dataGridViewCellStyle3;
            CustomerUserControl.dataGridViewCustomerUserControl.GridColor = System.Drawing.Color.Black;
            CustomerUserControl.dataGridViewCustomerUserControl.Location = new System.Drawing.Point(22, 112);
            CustomerUserControl.dataGridViewCustomerUserControl.Name = "dataGridViewCustomerUserControl";
            CustomerUserControl.dataGridViewCustomerUserControl.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            CustomerUserControl.dataGridViewCustomerUserControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CustomerUserControl.dataGridViewCustomerUserControl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            CustomerUserControl.dataGridViewCustomerUserControl.RowTemplate.DividerHeight = 3;
            CustomerUserControl.dataGridViewCustomerUserControl.RowTemplate.Height = 40;
            CustomerUserControl.dataGridViewCustomerUserControl.Size = new System.Drawing.Size(1650, 837);
            CustomerUserControl.dataGridViewCustomerUserControl.TabIndex = 8;
            CustomerUserControl.dataGridViewCustomerUserControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerUserControl_CellClick);
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
            this.dataGridView2.Location = new System.Drawing.Point(74, 340);
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
            // ResetfiltersButtonCustomers
            // 
            this.ResetfiltersButtonCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ResetfiltersButtonCustomers.FlatAppearance.BorderSize = 0;
            this.ResetfiltersButtonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetfiltersButtonCustomers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetfiltersButtonCustomers.ForeColor = System.Drawing.Color.White;
            this.ResetfiltersButtonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetfiltersButtonCustomers.Location = new System.Drawing.Point(1535, 73);
            this.ResetfiltersButtonCustomers.Name = "ResetfiltersButtonCustomers";
            this.ResetfiltersButtonCustomers.Size = new System.Drawing.Size(137, 33);
            this.ResetfiltersButtonCustomers.TabIndex = 5;
            this.ResetfiltersButtonCustomers.Text = "Reset filters";
            this.ResetfiltersButtonCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResetfiltersButtonCustomers.UseVisualStyleBackColor = false;
            this.ResetfiltersButtonCustomers.Click += new System.EventHandler(this.ResetfiltersButtonCustomers_Click);
            // 
            // SeachTextBoxCustomerUserControl
            // 
            this.SeachTextBoxCustomerUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeachTextBoxCustomerUserControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeachTextBoxCustomerUserControl.Location = new System.Drawing.Point(171, 72);
            this.SeachTextBoxCustomerUserControl.Name = "SeachTextBoxCustomerUserControl";
            this.SeachTextBoxCustomerUserControl.Size = new System.Drawing.Size(144, 27);
            this.SeachTextBoxCustomerUserControl.TabIndex = 10;
            this.SeachTextBoxCustomerUserControl.TextChanged += new System.EventHandler(this.SeachTextBoxCustomerUserControl_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(167, 49);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(64, 21);
            this.labelSearch.TabIndex = 11;
            this.labelSearch.Text = "Search";
            // 
            // PrintCustomersButton
            // 
            this.PrintCustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.PrintCustomersButton.FlatAppearance.BorderSize = 0;
            this.PrintCustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintCustomersButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintCustomersButton.ForeColor = System.Drawing.Color.White;
            this.PrintCustomersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintCustomersButton.Location = new System.Drawing.Point(1392, 73);
            this.PrintCustomersButton.Name = "PrintCustomersButton";
            this.PrintCustomersButton.Size = new System.Drawing.Size(137, 33);
            this.PrintCustomersButton.TabIndex = 12;
            this.PrintCustomersButton.Text = "Print Customers ";
            this.PrintCustomersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintCustomersButton.UseVisualStyleBackColor = false;
            this.PrintCustomersButton.Click += new System.EventHandler(this.PrintCustomersButton_Click);
            // 
            // NameOnFile
            // 
            this.NameOnFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOnFile.Location = new System.Drawing.Point(1253, 78);
            this.NameOnFile.Name = "NameOnFile";
            this.NameOnFile.Size = new System.Drawing.Size(133, 27);
            this.NameOnFile.TabIndex = 13;
            // 
            // ToLabelCustomer
            // 
            this.ToLabelCustomer.AutoSize = true;
            this.ToLabelCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabelCustomer.Location = new System.Drawing.Point(574, 49);
            this.ToLabelCustomer.Name = "ToLabelCustomer";
            this.ToLabelCustomer.Size = new System.Drawing.Size(28, 21);
            this.ToLabelCustomer.TabIndex = 36;
            this.ToLabelCustomer.Text = "To";
            // 
            // FromLabelCustomer
            // 
            this.FromLabelCustomer.AutoSize = true;
            this.FromLabelCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabelCustomer.Location = new System.Drawing.Point(451, 49);
            this.FromLabelCustomer.Name = "FromLabelCustomer";
            this.FromLabelCustomer.Size = new System.Drawing.Size(52, 21);
            this.FromLabelCustomer.TabIndex = 35;
            this.FromLabelCustomer.Text = "From ";
            // 
            // ToDateCustomer
            // 
            this.ToDateCustomer.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateCustomer.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateCustomer.Location = new System.Drawing.Point(578, 80);
            this.ToDateCustomer.Name = "ToDateCustomer";
            this.ToDateCustomer.Size = new System.Drawing.Size(113, 29);
            this.ToDateCustomer.TabIndex = 34;
            // 
            // FromDateCustomer
            // 
            this.FromDateCustomer.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateCustomer.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateCustomer.Location = new System.Drawing.Point(455, 80);
            this.FromDateCustomer.Name = "FromDateCustomer";
            this.FromDateCustomer.Size = new System.Drawing.Size(117, 29);
            this.FromDateCustomer.TabIndex = 33;
            // 
            // CustomerUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ToLabelCustomer);
            this.Controls.Add(this.FromLabelCustomer);
            this.Controls.Add(this.ToDateCustomer);
            this.Controls.Add(this.FromDateCustomer);
            this.Controls.Add(this.NameOnFile);
            this.Controls.Add(this.PrintCustomersButton);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.SeachTextBoxCustomerUserControl);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(CustomerUserControl.dataGridViewCustomerUserControl);
            this.Controls.Add(this.ResetfiltersButtonCustomers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(1700, 966);
            this.Load += new System.EventHandler(this.CustomerUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(CustomerUserControl.dataGridViewCustomerUserControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odensedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private odensedbDataSet odensedbDataSet;
        private odensedbDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewCustomerUserControl;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private System.Windows.Forms.Button ResetfiltersButtonCustomers;
        private System.Windows.Forms.TextBox SeachTextBoxCustomerUserControl;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button PrintCustomersButton;
        private System.Windows.Forms.TextBox NameOnFile;
        private System.Windows.Forms.Label ToLabelCustomer;
        private System.Windows.Forms.Label FromLabelCustomer;
        private System.Windows.Forms.DateTimePicker ToDateCustomer;
        private System.Windows.Forms.DateTimePicker FromDateCustomer;
    }
}
