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
            this.ButtonShowAllOrders = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SortButtonCustomers = new System.Windows.Forms.Button();
            this.ThenByDropDownBox = new System.Windows.Forms.ComboBox();
            this.ThenByLabelCustomers = new System.Windows.Forms.Label();
            this.SortyByLabelCustomers = new System.Windows.Forms.Label();
            this.SortByDropDownBox = new System.Windows.Forms.ComboBox();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.FromDateOrders = new System.Windows.Forms.DateTimePicker();
            this.ToDateOrders = new System.Windows.Forms.DateTimePicker();
            this.FromLabelOrders = new System.Windows.Forms.Label();
            this.ToLabelOrders = new System.Windows.Forms.Label();
            this.PrintButtonOrders = new System.Windows.Forms.Button();
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
            this.ButtonShowAllOrders.Location = new System.Drawing.Point(120, 11);
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
            this.DeleteOrderButton.Location = new System.Drawing.Point(888, 11);
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
            this.AddOrderButton.Location = new System.Drawing.Point(376, 11);
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
            this.UpdateOrderButton.Location = new System.Drawing.Point(632, 11);
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
            this.panel1.Size = new System.Drawing.Size(1211, 10);
            this.panel1.TabIndex = 9;
            // 
            // SortButtonCustomers
            // 
            this.SortButtonCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.SortButtonCustomers.FlatAppearance.BorderSize = 0;
            this.SortButtonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButtonCustomers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButtonCustomers.ForeColor = System.Drawing.Color.White;
            this.SortButtonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SortButtonCustomers.Location = new System.Drawing.Point(1081, 163);
            this.SortButtonCustomers.Name = "SortButtonCustomers";
            this.SortButtonCustomers.Size = new System.Drawing.Size(101, 33);
            this.SortButtonCustomers.TabIndex = 13;
            this.SortButtonCustomers.Text = "Sort";
            this.SortButtonCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SortButtonCustomers.UseVisualStyleBackColor = false;
            // 
            // ThenByDropDownBox
            // 
            this.ThenByDropDownBox.BackColor = System.Drawing.Color.White;
            this.ThenByDropDownBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByDropDownBox.FormattingEnabled = true;
            this.ThenByDropDownBox.Location = new System.Drawing.Point(234, 165);
            this.ThenByDropDownBox.Name = "ThenByDropDownBox";
            this.ThenByDropDownBox.Size = new System.Drawing.Size(206, 29);
            this.ThenByDropDownBox.TabIndex = 16;
            // 
            // ThenByLabelCustomers
            // 
            this.ThenByLabelCustomers.AutoSize = true;
            this.ThenByLabelCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThenByLabelCustomers.Location = new System.Drawing.Point(230, 134);
            this.ThenByLabelCustomers.Name = "ThenByLabelCustomers";
            this.ThenByLabelCustomers.Size = new System.Drawing.Size(140, 21);
            this.ThenByLabelCustomers.TabIndex = 15;
            this.ThenByLabelCustomers.Text = "And then sort by";
            // 
            // SortyByLabelCustomers
            // 
            this.SortyByLabelCustomers.AutoSize = true;
            this.SortyByLabelCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortyByLabelCustomers.Location = new System.Drawing.Point(18, 134);
            this.SortyByLabelCustomers.Name = "SortyByLabelCustomers";
            this.SortyByLabelCustomers.Size = new System.Drawing.Size(63, 21);
            this.SortyByLabelCustomers.TabIndex = 14;
            this.SortyByLabelCustomers.Text = "Sort by";
            // 
            // SortByDropDownBox
            // 
            this.SortByDropDownBox.BackColor = System.Drawing.Color.White;
            this.SortByDropDownBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByDropDownBox.FormattingEnabled = true;
            this.SortByDropDownBox.Location = new System.Drawing.Point(22, 165);
            this.SortByDropDownBox.Name = "SortByDropDownBox";
            this.SortByDropDownBox.Size = new System.Drawing.Size(206, 29);
            this.SortByDropDownBox.TabIndex = 12;
            // 
            // OrderList
            // 
            this.OrderList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 21;
            this.OrderList.Location = new System.Drawing.Point(22, 202);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(1160, 508);
            this.OrderList.TabIndex = 11;
            // 
            // FromDateOrders
            // 
            this.FromDateOrders.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateOrders.Location = new System.Drawing.Point(469, 163);
            this.FromDateOrders.Name = "FromDateOrders";
            this.FromDateOrders.Size = new System.Drawing.Size(200, 27);
            this.FromDateOrders.TabIndex = 18;
            // 
            // ToDateOrders
            // 
            this.ToDateOrders.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateOrders.Location = new System.Drawing.Point(685, 163);
            this.ToDateOrders.Name = "ToDateOrders";
            this.ToDateOrders.Size = new System.Drawing.Size(200, 27);
            this.ToDateOrders.TabIndex = 19;
            // 
            // FromLabelOrders
            // 
            this.FromLabelOrders.AutoSize = true;
            this.FromLabelOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabelOrders.Location = new System.Drawing.Point(465, 134);
            this.FromLabelOrders.Name = "FromLabelOrders";
            this.FromLabelOrders.Size = new System.Drawing.Size(52, 21);
            this.FromLabelOrders.TabIndex = 20;
            this.FromLabelOrders.Text = "From ";
            // 
            // ToLabelOrders
            // 
            this.ToLabelOrders.AutoSize = true;
            this.ToLabelOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabelOrders.Location = new System.Drawing.Point(681, 134);
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
            this.PrintButtonOrders.Location = new System.Drawing.Point(1095, 719);
            this.PrintButtonOrders.Name = "PrintButtonOrders";
            this.PrintButtonOrders.Size = new System.Drawing.Size(87, 45);
            this.PrintButtonOrders.TabIndex = 17;
            this.PrintButtonOrders.Text = "Print";
            this.PrintButtonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButtonOrders.UseVisualStyleBackColor = false;
            // 
            // OrderUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ToLabelOrders);
            this.Controls.Add(this.FromLabelOrders);
            this.Controls.Add(this.ToDateOrders);
            this.Controls.Add(this.FromDateOrders);
            this.Controls.Add(this.PrintButtonOrders);
            this.Controls.Add(this.SortButtonCustomers);
            this.Controls.Add(this.ThenByDropDownBox);
            this.Controls.Add(this.ThenByLabelCustomers);
            this.Controls.Add(this.SortyByLabelCustomers);
            this.Controls.Add(this.SortByDropDownBox);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.ButtonShowAllOrders);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.UpdateOrderButton);
            this.Controls.Add(this.panel1);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(1211, 774);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonShowAllOrders;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button UpdateOrderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SortButtonCustomers;
        private System.Windows.Forms.ComboBox ThenByDropDownBox;
        private System.Windows.Forms.Label ThenByLabelCustomers;
        private System.Windows.Forms.Label SortyByLabelCustomers;
        private System.Windows.Forms.ComboBox SortByDropDownBox;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Button PrintButtonOrders;
        private System.Windows.Forms.DateTimePicker FromDateOrders;
        private System.Windows.Forms.DateTimePicker ToDateOrders;
        private System.Windows.Forms.Label FromLabelOrders;
        private System.Windows.Forms.Label ToLabelOrders;
    }
}
