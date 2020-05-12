﻿using System.Drawing;

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
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SortByDropDownBoxCustomer = new System.Windows.Forms.ComboBox();
            this.SortyByLabelCustomers = new System.Windows.Forms.Label();
            this.ThenByLabelCustomers = new System.Windows.Forms.Label();
            this.ThenByDropDownBoxCustomer = new System.Windows.Forms.ComboBox();
            this.dataGridViewCustomerUserControl = new System.Windows.Forms.DataGridView();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.odensedbDataSet = new UI.odensedbDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new UI.odensedbDataSetTableAdapters.CustomersTableAdapter();
            this.ResetfiltersButtonCustomers = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
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
            // SortByDropDownBoxCustomer
            // 
            this.SortByDropDownBoxCustomer.BackColor = System.Drawing.Color.White;
            this.SortByDropDownBoxCustomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SortByDropDownBoxCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByDropDownBoxCustomer.ForeColor = System.Drawing.Color.Black;
            this.SortByDropDownBoxCustomer.FormattingEnabled = true;
            this.SortByDropDownBoxCustomer.Items.AddRange(new object[] {
            "CustomerID"});
            this.SortByDropDownBoxCustomer.Location = new System.Drawing.Point(1107, 72);
            this.SortByDropDownBoxCustomer.Name = "SortByDropDownBoxCustomer";
            this.SortByDropDownBoxCustomer.Size = new System.Drawing.Size(206, 29);
            this.SortByDropDownBoxCustomer.TabIndex = 4;
            this.SortByDropDownBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.SortByDropDownBox_SelectedIndexChanged);
            // 
            // SortyByLabelCustomers
            // 
            this.SortyByLabelCustomers.AutoSize = true;
            this.SortyByLabelCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortyByLabelCustomers.Location = new System.Drawing.Point(1103, 49);
            this.SortyByLabelCustomers.Name = "SortyByLabelCustomers";
            this.SortyByLabelCustomers.Size = new System.Drawing.Size(63, 21);
            this.SortyByLabelCustomers.TabIndex = 5;
            this.SortyByLabelCustomers.Text = "Sort by";
            // 
            // ThenByLabelCustomers
            // 
            this.ThenByLabelCustomers.AutoSize = true;
            this.ThenByLabelCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByLabelCustomers.Location = new System.Drawing.Point(1319, 49);
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
            this.ThenByDropDownBoxCustomer.Location = new System.Drawing.Point(1323, 73);
            this.ThenByDropDownBoxCustomer.Name = "ThenByDropDownBoxCustomer";
            this.ThenByDropDownBoxCustomer.Size = new System.Drawing.Size(206, 29);
            this.ThenByDropDownBoxCustomer.TabIndex = 7;
            // 
            // dataGridViewCustomerUserControl
            // 
            this.dataGridViewCustomerUserControl.AllowUserToAddRows = false;
            this.dataGridViewCustomerUserControl.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerUserControl.AllowUserToResizeColumns = false;
            this.dataGridViewCustomerUserControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCustomerUserControl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomerUserControl.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewCustomerUserControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomerUserControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomerUserControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomerUserControl.ColumnHeadersHeight = 30;
            this.dataGridViewCustomerUserControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomerUserControl.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomerUserControl.Location = new System.Drawing.Point(22, 112);
            this.dataGridViewCustomerUserControl.Name = "dataGridViewCustomerUserControl";
            this.dataGridViewCustomerUserControl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewCustomerUserControl.Size = new System.Drawing.Size(1650, 837);
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
            this.ResetfiltersButtonCustomers.Click += new System.EventHandler(this.SortButtonCustomers_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(171, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 10;
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
            // CustomerUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.dataGridViewCustomerUserControl);
            this.Controls.Add(this.ResetfiltersButtonCustomers);
            this.Controls.Add(this.ThenByDropDownBoxCustomer);
            this.Controls.Add(this.ThenByLabelCustomers);
            this.Controls.Add(this.SortyByLabelCustomers);
            this.Controls.Add(this.SortByDropDownBoxCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(1700, 966);
            this.Load += new System.EventHandler(this.CustomerUserControl_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox SortByDropDownBoxCustomer;
        private System.Windows.Forms.Label SortyByLabelCustomers;
        private System.Windows.Forms.Label ThenByLabelCustomers;
        private System.Windows.Forms.ComboBox ThenByDropDownBoxCustomer;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private odensedbDataSet odensedbDataSet;
        private odensedbDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCustomerUserControl;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private System.Windows.Forms.Button ResetfiltersButtonCustomers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSearch;
    }
}
