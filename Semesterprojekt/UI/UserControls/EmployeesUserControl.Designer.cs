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
            this.CancelButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.ComboBoxEmplyeesSelectStore.Location = new System.Drawing.Point(72, 39);
            this.ComboBoxEmplyeesSelectStore.Name = "ComboBoxEmplyeesSelectStore";
            this.ComboBoxEmplyeesSelectStore.Size = new System.Drawing.Size(201, 29);
            this.ComboBoxEmplyeesSelectStore.TabIndex = 0;
            this.ComboBoxEmplyeesSelectStore.Text = "STORE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select store";
            // 
            // StoreInformationListBox
            // 
            this.StoreInformationListBox.FormattingEnabled = true;
            this.StoreInformationListBox.ItemHeight = 21;
            this.StoreInformationListBox.Location = new System.Drawing.Point(72, 130);
            this.StoreInformationListBox.Name = "StoreInformationListBox";
            this.StoreInformationListBox.Size = new System.Drawing.Size(558, 655);
            this.StoreInformationListBox.TabIndex = 2;
            // 
            // ButtonShowSelectedItems
            // 
            this.ButtonShowSelectedItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonShowSelectedItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowSelectedItems.Location = new System.Drawing.Point(72, 71);
            this.ButtonShowSelectedItems.Name = "ButtonShowSelectedItems";
            this.ButtonShowSelectedItems.Size = new System.Drawing.Size(201, 32);
            this.ButtonShowSelectedItems.TabIndex = 3;
            this.ButtonShowSelectedItems.Text = "Show selected store";
            this.ButtonShowSelectedItems.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(902, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type Message to selected store";
            // 
            // ButtonSendMessageToSelectedStore
            // 
            this.ButtonSendMessageToSelectedStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonSendMessageToSelectedStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSendMessageToSelectedStore.Location = new System.Drawing.Point(906, 791);
            this.ButtonSendMessageToSelectedStore.Name = "ButtonSendMessageToSelectedStore";
            this.ButtonSendMessageToSelectedStore.Size = new System.Drawing.Size(130, 38);
            this.ButtonSendMessageToSelectedStore.TabIndex = 12;
            this.ButtonSendMessageToSelectedStore.Text = "Send message";
            this.ButtonSendMessageToSelectedStore.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(906, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(633, 673);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.panel1.Location = new System.Drawing.Point(770, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 966);
            this.panel1.TabIndex = 76;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(1409, 791);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 38);
            this.CancelButton.TabIndex = 77;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1540, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 78;
            this.button1.Text = "Notifications";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1651, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "4";
            // 
            // EmployeesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelButton);
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
            this.Size = new System.Drawing.Size(1700, 966);
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
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}
