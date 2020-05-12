namespace UI
{
    partial class EmployeesUserControl
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
            this.ComboBoxEmplyeesSelectStore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StoreInformationListBox = new System.Windows.Forms.ListBox();
            this.ButtonShowSelectedItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxEmplyeesSelectStore
            // 
            this.ComboBoxEmplyeesSelectStore.FormattingEnabled = true;
            this.ComboBoxEmplyeesSelectStore.Items.AddRange(new object[] {
            "Odense ",
            "København",
            "Århus",
            "Struer"});
            this.ComboBoxEmplyeesSelectStore.Location = new System.Drawing.Point(72, 92);
            this.ComboBoxEmplyeesSelectStore.Name = "ComboBoxEmplyeesSelectStore";
            this.ComboBoxEmplyeesSelectStore.Size = new System.Drawing.Size(201, 29);
            this.ComboBoxEmplyeesSelectStore.TabIndex = 0;
            this.ComboBoxEmplyeesSelectStore.Text = "STORE";
            this.ComboBoxEmplyeesSelectStore.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEmplyeesSelectStore_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select store";
            // 
            // StoreInformationListBox
            // 
            this.StoreInformationListBox.FormattingEnabled = true;
            this.StoreInformationListBox.ItemHeight = 21;
            this.StoreInformationListBox.Location = new System.Drawing.Point(72, 185);
            this.StoreInformationListBox.Name = "StoreInformationListBox";
            this.StoreInformationListBox.Size = new System.Drawing.Size(424, 340);
            this.StoreInformationListBox.TabIndex = 2;
            this.StoreInformationListBox.SelectedIndexChanged += new System.EventHandler(this.StoreInformationListBox_SelectedIndexChanged);
            // 
            // ButtonShowSelectedItems
            // 
            this.ButtonShowSelectedItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowSelectedItems.Location = new System.Drawing.Point(72, 128);
            this.ButtonShowSelectedItems.Name = "ButtonShowSelectedItems";
            this.ButtonShowSelectedItems.Size = new System.Drawing.Size(201, 32);
            this.ButtonShowSelectedItems.TabIndex = 3;
            this.ButtonShowSelectedItems.Text = "Show selected store";
            this.ButtonShowSelectedItems.UseVisualStyleBackColor = true;
            this.ButtonShowSelectedItems.Click += new System.EventHandler(this.ButtonShowSelectedItems_Click);
            // 
            // EmployeesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonShowSelectedItems);
            this.Controls.Add(this.StoreInformationListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxEmplyeesSelectStore);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EmployeesUserControl";
            this.Size = new System.Drawing.Size(1211, 774);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxEmplyeesSelectStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StoreInformationListBox;
        private System.Windows.Forms.Button ButtonShowSelectedItems;
    }
}
