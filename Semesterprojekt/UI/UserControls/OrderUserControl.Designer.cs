namespace UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FromDateOrders = new System.Windows.Forms.DateTimePicker();
            this.ToDateOrders = new System.Windows.Forms.DateTimePicker();
            this.FromLabelOrders = new System.Windows.Forms.Label();
            this.ToLabelOrders = new System.Windows.Forms.Label();
            this.PrintButtonOrders = new System.Windows.Forms.Button();
            this.textboxOrderSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewOrderUserControl = new System.Windows.Forms.DataGridView();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.buttonResetFiltersOrders = new System.Windows.Forms.Button();
            this.textBoxNameOnPrintFileOrders = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderUserControl)).BeginInit();
            this.SuspendLayout();
            // 
            // FromDateOrders
            // 
            this.FromDateOrders.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateOrders.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateOrders.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateOrders.Location = new System.Drawing.Point(571, 56);
            this.FromDateOrders.Name = "FromDateOrders";
            this.FromDateOrders.Size = new System.Drawing.Size(117, 29);
            this.FromDateOrders.TabIndex = 18;
            this.FromDateOrders.ValueChanged += new System.EventHandler(this.FromDateOrders_ValueChanged);
            // 
            // ToDateOrders
            // 
            this.ToDateOrders.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateOrders.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateOrders.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateOrders.Location = new System.Drawing.Point(694, 56);
            this.ToDateOrders.Name = "ToDateOrders";
            this.ToDateOrders.Size = new System.Drawing.Size(113, 29);
            this.ToDateOrders.TabIndex = 19;
            this.ToDateOrders.ValueChanged += new System.EventHandler(this.ToDateOrders_ValueChanged);
            // 
            // FromLabelOrders
            // 
            this.FromLabelOrders.AutoSize = true;
            this.FromLabelOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabelOrders.Location = new System.Drawing.Point(567, 32);
            this.FromLabelOrders.Name = "FromLabelOrders";
            this.FromLabelOrders.Size = new System.Drawing.Size(52, 21);
            this.FromLabelOrders.TabIndex = 20;
            this.FromLabelOrders.Text = "From ";
            // 
            // ToLabelOrders
            // 
            this.ToLabelOrders.AutoSize = true;
            this.ToLabelOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabelOrders.Location = new System.Drawing.Point(694, 35);
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
            this.PrintButtonOrders.Location = new System.Drawing.Point(1591, 918);
            this.PrintButtonOrders.Name = "PrintButtonOrders";
            this.PrintButtonOrders.Size = new System.Drawing.Size(87, 29);
            this.PrintButtonOrders.TabIndex = 17;
            this.PrintButtonOrders.Text = "Print";
            this.PrintButtonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButtonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButtonOrders.UseVisualStyleBackColor = false;
            this.PrintButtonOrders.Click += new System.EventHandler(this.PrintButtonOrders_Click);
            // 
            // textboxOrderSearch
            // 
            this.textboxOrderSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxOrderSearch.Location = new System.Drawing.Point(383, 58);
            this.textboxOrderSearch.Name = "textboxOrderSearch";
            this.textboxOrderSearch.Size = new System.Drawing.Size(158, 27);
            this.textboxOrderSearch.TabIndex = 22;
            this.textboxOrderSearch.TextChanged += new System.EventHandler(this.SearchButtonOrderUserControl_TextChanged);
            // 
            // dataGridViewOrderUserControl
            // 
            this.dataGridViewOrderUserControl.AllowUserToAddRows = false;
            this.dataGridViewOrderUserControl.AllowUserToDeleteRows = false;
            this.dataGridViewOrderUserControl.AllowUserToResizeColumns = false;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewOrderUserControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dataGridViewOrderUserControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderUserControl.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderUserControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrderUserControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderUserControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.dataGridViewOrderUserControl.ColumnHeadersHeight = 40;
            this.dataGridViewOrderUserControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderUserControl.DefaultCellStyle = dataGridViewCellStyle51;
            this.dataGridViewOrderUserControl.GridColor = System.Drawing.Color.Black;
            this.dataGridViewOrderUserControl.Location = new System.Drawing.Point(22, 115);
            this.dataGridViewOrderUserControl.MultiSelect = false;
            this.dataGridViewOrderUserControl.Name = "dataGridViewOrderUserControl";
            this.dataGridViewOrderUserControl.ReadOnly = true;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderUserControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.dataGridViewOrderUserControl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewOrderUserControl.RowTemplate.DividerHeight = 3;
            this.dataGridViewOrderUserControl.RowTemplate.Height = 40;
            this.dataGridViewOrderUserControl.Size = new System.Drawing.Size(1646, 774);
            this.dataGridViewOrderUserControl.TabIndex = 23;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.AddOrderButton.FlatAppearance.BorderSize = 0;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddOrderButton.Location = new System.Drawing.Point(24, 54);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(164, 35);
            this.AddOrderButton.TabIndex = 6;
            this.AddOrderButton.Text = "Add orders";
            this.AddOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(379, 34);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(64, 21);
            this.Search.TabIndex = 24;
            this.Search.Text = "Search";
            // 
            // buttonResetFiltersOrders
            // 
            this.buttonResetFiltersOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.buttonResetFiltersOrders.FlatAppearance.BorderSize = 0;
            this.buttonResetFiltersOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetFiltersOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetFiltersOrders.ForeColor = System.Drawing.Color.White;
            this.buttonResetFiltersOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResetFiltersOrders.Location = new System.Drawing.Point(194, 54);
            this.buttonResetFiltersOrders.Name = "buttonResetFiltersOrders";
            this.buttonResetFiltersOrders.Size = new System.Drawing.Size(164, 35);
            this.buttonResetFiltersOrders.TabIndex = 25;
            this.buttonResetFiltersOrders.Text = "Reset filter";
            this.buttonResetFiltersOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonResetFiltersOrders.UseVisualStyleBackColor = false;
            this.buttonResetFiltersOrders.Click += new System.EventHandler(this.buttonResetFiltersOrders_Click);
            // 
            // textBoxNameOnPrintFileOrders
            // 
            this.textBoxNameOnPrintFileOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameOnPrintFileOrders.Location = new System.Drawing.Point(1407, 920);
            this.textBoxNameOnPrintFileOrders.Name = "textBoxNameOnPrintFileOrders";
            this.textBoxNameOnPrintFileOrders.Size = new System.Drawing.Size(159, 27);
            this.textBoxNameOnPrintFileOrders.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(1403, 896);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name of printed file";
            // 
            // OrderUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameOnPrintFileOrders);
            this.Controls.Add(this.buttonResetFiltersOrders);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridViewOrderUserControl);
            this.Controls.Add(this.textboxOrderSearch);
            this.Controls.Add(this.ToLabelOrders);
            this.Controls.Add(this.FromLabelOrders);
            this.Controls.Add(this.ToDateOrders);
            this.Controls.Add(this.FromDateOrders);
            this.Controls.Add(this.PrintButtonOrders);
            this.Controls.Add(this.AddOrderButton);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(1700, 966);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderUserControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrintButtonOrders;
        private System.Windows.Forms.DateTimePicker FromDateOrders;
        private System.Windows.Forms.DateTimePicker ToDateOrders;
        private System.Windows.Forms.Label FromLabelOrders;
        private System.Windows.Forms.Label ToLabelOrders;
        private System.Windows.Forms.TextBox textboxOrderSearch;
        public System.Windows.Forms.DataGridView dataGridViewOrderUserControl;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button buttonResetFiltersOrders;
        private System.Windows.Forms.TextBox textBoxNameOnPrintFileOrders;
        private System.Windows.Forms.Label label1;
    }
}
