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
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSendMessageToSelectedStore = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Notification = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
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
            this.ButtonShowSelectedItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonShowSelectedItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowSelectedItems.Location = new System.Drawing.Point(72, 128);
            this.ButtonShowSelectedItems.Name = "ButtonShowSelectedItems";
            this.ButtonShowSelectedItems.Size = new System.Drawing.Size(201, 32);
            this.ButtonShowSelectedItems.TabIndex = 3;
            this.ButtonShowSelectedItems.Text = "Show selected store";
            this.ButtonShowSelectedItems.UseVisualStyleBackColor = false;
            this.ButtonShowSelectedItems.Click += new System.EventHandler(this.ButtonShowSelectedItems_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type Message to selected store";
            // 
            // ButtonSendMessageToSelectedStore
            // 
            this.ButtonSendMessageToSelectedStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonSendMessageToSelectedStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSendMessageToSelectedStore.Location = new System.Drawing.Point(637, 560);
            this.ButtonSendMessageToSelectedStore.Name = "ButtonSendMessageToSelectedStore";
            this.ButtonSendMessageToSelectedStore.Size = new System.Drawing.Size(130, 31);
            this.ButtonSendMessageToSelectedStore.TabIndex = 12;
            this.ButtonSendMessageToSelectedStore.Text = "Send message";
            this.ButtonSendMessageToSelectedStore.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(637, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 342);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.panel1.Location = new System.Drawing.Point(556, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 776);
            this.panel1.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Notification);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 33);
            this.panel2.TabIndex = 75;
            // 
            // Notification
            // 
            this.Notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification.Location = new System.Drawing.Point(1061, 2);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(118, 31);
            this.Notification.TabIndex = 76;
            this.Notification.Text = "Notifications";
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1169, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "4";
            // 
            // EmployeesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSendMessageToSelectedStore);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ButtonShowSelectedItems);
            this.Controls.Add(this.StoreInformationListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxEmplyeesSelectStore);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EmployeesUserControl";
            this.Size = new System.Drawing.Size(1211, 774);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxEmplyeesSelectStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StoreInformationListBox;
        private System.Windows.Forms.Button ButtonShowSelectedItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonSendMessageToSelectedStore;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Notification;
    }
}
