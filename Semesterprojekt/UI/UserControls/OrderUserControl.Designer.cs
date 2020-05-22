﻿namespace UI
{
    partial class OrderUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonShowAllOrders = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThenByDropDownBoxOrders = new System.Windows.Forms.ComboBox();
            this.ThenByLabelOrders = new System.Windows.Forms.Label();
            this.SortyByLabelOrders = new System.Windows.Forms.Label();
            this.SortByDropDownBoxOrders = new System.Windows.Forms.ComboBox();
            this.FromDateOrders = new System.Windows.Forms.DateTimePicker();
            this.ToDateOrders = new System.Windows.Forms.DateTimePicker();
            this.FromLabelOrders = new System.Windows.Forms.Label();
            this.ToLabelOrders = new System.Windows.Forms.Label();
            this.PrintButtonOrders = new System.Windows.Forms.Button();
            this.SearchButtonOrderUserControl = new System.Windows.Forms.TextBox();
            this.dataGridViewOrderUserControl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderUserControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonShowAllOrders
            // 
            this.ButtonShowAllOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonShowAllOrders.FlatAppearance.BorderSize = 0;
            this.ButtonShowAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowAllOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowAllOrders.ForeColor = System.Drawing.Color.White;
            this.ButtonShowAllOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowAllOrders.Location = new System.Drawing.Point(251, 15);
            this.ButtonShowAllOrders.Name = "ButtonShowAllOrders";
            this.ButtonShowAllOrders.Size = new System.Drawing.Size(210, 100);
            this.ButtonShowAllOrders.TabIndex = 7;
            this.ButtonShowAllOrders.Text = "Show all";
            this.ButtonShowAllOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowAllOrders.UseVisualStyleBackColor = false;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.DeleteOrderButton.FlatAppearance.BorderSize = 0;
            this.DeleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrderButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderButton.ForeColor = System.Drawing.Color.White;
            this.DeleteOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteOrderButton.Location = new System.Drawing.Point(1091, 15);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(210, 97);
            this.DeleteOrderButton.TabIndex = 10;
            this.DeleteOrderButton.Text = "Delete";
            this.DeleteOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteOrderButton.UseVisualStyleBackColor = false;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.AddOrderButton.FlatAppearance.BorderSize = 0;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddOrderButton.Location = new System.Drawing.Point(579, 15);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(210, 100);
            this.AddOrderButton.TabIndex = 6;
            this.AddOrderButton.Text = "Add";
            this.AddOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // UpdateOrderButton
            // 
            this.UpdateOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.UpdateOrderButton.FlatAppearance.BorderSize = 0;
            this.UpdateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateOrderButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateOrderButton.ForeColor = System.Drawing.Color.White;
            this.UpdateOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateOrderButton.Location = new System.Drawing.Point(835, 15);
            this.UpdateOrderButton.Name = "UpdateOrderButton";
            this.UpdateOrderButton.Size = new System.Drawing.Size(210, 100);
            this.UpdateOrderButton.TabIndex = 8;
            this.UpdateOrderButton.Text = "Update";
            this.UpdateOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateOrderButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 10);
            this.panel1.TabIndex = 9;
            // 
            // ThenByDropDownBoxOrders
            // 
            this.ThenByDropDownBoxOrders.BackColor = System.Drawing.Color.White;
            this.ThenByDropDownBoxOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByDropDownBoxOrders.FormattingEnabled = true;
            this.ThenByDropDownBoxOrders.Location = new System.Drawing.Point(234, 165);
            this.ThenByDropDownBoxOrders.Name = "ThenByDropDownBoxOrders";
            this.ThenByDropDownBoxOrders.Size = new System.Drawing.Size(206, 29);
            this.ThenByDropDownBoxOrders.TabIndex = 16;
            // 
            // ThenByLabelOrders
            // 
            this.ThenByLabelOrders.AutoSize = true;
            this.ThenByLabelOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByLabelOrders.Location = new System.Drawing.Point(230, 134);
            this.ThenByLabelOrders.Name = "ThenByLabelOrders";
            this.ThenByLabelOrders.Size = new System.Drawing.Size(140, 21);
            this.ThenByLabelOrders.TabIndex = 15;
            this.ThenByLabelOrders.Text = "And then sort by";
            // 
            // SortyByLabelOrders
            // 
            this.SortyByLabelOrders.AutoSize = true;
            this.SortyByLabelOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortyByLabelOrders.Location = new System.Drawing.Point(18, 134);
            this.SortyByLabelOrders.Name = "SortyByLabelOrders";
            this.SortyByLabelOrders.Size = new System.Drawing.Size(63, 21);
            this.SortyByLabelOrders.TabIndex = 14;
            this.SortyByLabelOrders.Text = "Sort by";
            // 
            // SortByDropDownBoxOrders
            // 
            this.SortByDropDownBoxOrders.BackColor = System.Drawing.Color.White;
            this.SortByDropDownBoxOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByDropDownBoxOrders.FormattingEnabled = true;
            this.SortByDropDownBoxOrders.Location = new System.Drawing.Point(22, 165);
            this.SortByDropDownBoxOrders.Name = "SortByDropDownBoxOrders";
            this.SortByDropDownBoxOrders.Size = new System.Drawing.Size(206, 29);
            this.SortByDropDownBoxOrders.TabIndex = 12;
            // 
            // FromDateOrders
            // 
            this.FromDateOrders.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateOrders.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateOrders.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateOrders.Location = new System.Drawing.Point(524, 165);
            this.FromDateOrders.Name = "FromDateOrders";
            this.FromDateOrders.Size = new System.Drawing.Size(117, 29);
            this.FromDateOrders.TabIndex = 18;
            // 
            // ToDateOrders
            // 
            this.ToDateOrders.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateOrders.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateOrders.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateOrders.Location = new System.Drawing.Point(647, 165);
            this.ToDateOrders.Name = "ToDateOrders";
            this.ToDateOrders.Size = new System.Drawing.Size(113, 29);
            this.ToDateOrders.TabIndex = 19;
            // 
            // FromLabelOrders
            // 
            this.FromLabelOrders.AutoSize = true;
            this.FromLabelOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabelOrders.Location = new System.Drawing.Point(520, 134);
            this.FromLabelOrders.Name = "FromLabelOrders";
            this.FromLabelOrders.Size = new System.Drawing.Size(52, 21);
            this.FromLabelOrders.TabIndex = 20;
            this.FromLabelOrders.Text = "From ";
            // 
            // ToLabelOrders
            // 
            this.ToLabelOrders.AutoSize = true;
            this.ToLabelOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabelOrders.Location = new System.Drawing.Point(643, 134);
            this.ToLabelOrders.Name = "ToLabelOrders";
            this.ToLabelOrders.Size = new System.Drawing.Size(28, 21);
            this.ToLabelOrders.TabIndex = 21;
            this.ToLabelOrders.Text = "To";
            // 
            // PrintButtonOrders
            // 
            this.PrintButtonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.PrintButtonOrders.FlatAppearance.BorderSize = 0;
            this.PrintButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButtonOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButtonOrders.ForeColor = System.Drawing.Color.White;
            this.PrintButtonOrders.Image = ((System.Drawing.Image)(resources.GetObject("PrintButtonOrders.Image")));
            this.PrintButtonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButtonOrders.Location = new System.Drawing.Point(1570, 876);
            this.PrintButtonOrders.Name = "PrintButtonOrders";
            this.PrintButtonOrders.Size = new System.Drawing.Size(87, 45);
            this.PrintButtonOrders.TabIndex = 17;
            this.PrintButtonOrders.Text = "Print";
            this.PrintButtonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButtonOrders.UseVisualStyleBackColor = false;
            // 
            // SearchButtonOrderUserControl
            // 
            this.SearchButtonOrderUserControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButtonOrderUserControl.Location = new System.Drawing.Point(1522, 167);
            this.SearchButtonOrderUserControl.Name = "SearchButtonOrderUserControl";
            this.SearchButtonOrderUserControl.Size = new System.Drawing.Size(135, 27);
            this.SearchButtonOrderUserControl.TabIndex = 22;
            // 
            // dataGridViewOrderUserControl
            // 
            this.dataGridViewOrderUserControl.AllowUserToAddRows = false;
            this.dataGridViewOrderUserControl.AllowUserToDeleteRows = false;
            this.dataGridViewOrderUserControl.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewOrderUserControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrderUserControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOrderUserControl.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderUserControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrderUserControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderUserControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrderUserControl.ColumnHeadersHeight = 40;
            this.dataGridViewOrderUserControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderUserControl.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrderUserControl.GridColor = System.Drawing.Color.Black;
            this.dataGridViewOrderUserControl.Location = new System.Drawing.Point(22, 200);
            this.dataGridViewOrderUserControl.Name = "dataGridViewOrderUserControl";
            this.dataGridViewOrderUserControl.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderUserControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrderUserControl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewOrderUserControl.RowTemplate.DividerHeight = 3;
            this.dataGridViewOrderUserControl.RowTemplate.Height = 40;
            this.dataGridViewOrderUserControl.Size = new System.Drawing.Size(1613, 670);
            this.dataGridViewOrderUserControl.TabIndex = 23;
            // 
            // OrderUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewOrderUserControl);
            this.Controls.Add(this.SearchButtonOrderUserControl);
            this.Controls.Add(this.ToLabelOrders);
            this.Controls.Add(this.FromLabelOrders);
            this.Controls.Add(this.ToDateOrders);
            this.Controls.Add(this.FromDateOrders);
            this.Controls.Add(this.PrintButtonOrders);
            this.Controls.Add(this.ThenByDropDownBoxOrders);
            this.Controls.Add(this.ThenByLabelOrders);
            this.Controls.Add(this.SortyByLabelOrders);
            this.Controls.Add(this.SortByDropDownBoxOrders);
            this.Controls.Add(this.ButtonShowAllOrders);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.UpdateOrderButton);
            this.Controls.Add(this.panel1);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(1700, 966);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderUserControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonShowAllOrders;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button UpdateOrderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ThenByDropDownBoxOrders;
        private System.Windows.Forms.Label ThenByLabelOrders;
        private System.Windows.Forms.Label SortyByLabelOrders;
        private System.Windows.Forms.ComboBox SortByDropDownBoxOrders;
        private System.Windows.Forms.Button PrintButtonOrders;
        private System.Windows.Forms.DateTimePicker FromDateOrders;
        private System.Windows.Forms.DateTimePicker ToDateOrders;
        private System.Windows.Forms.Label FromLabelOrders;
        private System.Windows.Forms.Label ToLabelOrders;
        private System.Windows.Forms.TextBox SearchButtonOrderUserControl;
        public System.Windows.Forms.DataGridView dataGridViewOrderUserControl;
    }
}
