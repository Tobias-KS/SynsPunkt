namespace UI
{
    partial class AddPopUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.ButtonPanelPopUp = new System.Windows.Forms.Panel();
            this.CancelButtonPopUp = new System.Windows.Forms.Button();
            this.SaveButtonPopUp = new System.Windows.Forms.Button();
            this.TopPanelPopUp = new System.Windows.Forms.Panel();
            this.LeftPanelPopUp = new System.Windows.Forms.Panel();
            this.RightPanelPopUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addProductUserControl1 = new UI.AddProductUserControl();
            this.addCustomerPopUpMainPanelUserControl1 = new UI.AddCustomerPopUpMainPanelUserControl();
            this.addOrderPopUpMainPanelUserControl1 = new UI.AddOrderPopUpMainPanelUserControl();
            this.ButtonPanelPopUp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanelPopUp
            // 
            this.ButtonPanelPopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.ButtonPanelPopUp.Controls.Add(this.CancelButtonPopUp);
            this.ButtonPanelPopUp.Controls.Add(this.SaveButtonPopUp);
            this.ButtonPanelPopUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanelPopUp.Location = new System.Drawing.Point(0, 383);
            this.ButtonPanelPopUp.Name = "ButtonPanelPopUp";
            this.ButtonPanelPopUp.Size = new System.Drawing.Size(845, 100);
            this.ButtonPanelPopUp.TabIndex = 1;
            // 
            // CancelButtonPopUp
            // 
            this.CancelButtonPopUp.BackColor = System.Drawing.Color.DarkRed;
            this.CancelButtonPopUp.FlatAppearance.BorderSize = 0;
            this.CancelButtonPopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButtonPopUp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonPopUp.ForeColor = System.Drawing.Color.White;
            this.CancelButtonPopUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButtonPopUp.Location = new System.Drawing.Point(506, 3);
            this.CancelButtonPopUp.Name = "CancelButtonPopUp";
            this.CancelButtonPopUp.Size = new System.Drawing.Size(198, 94);
            this.CancelButtonPopUp.TabIndex = 11;
            this.CancelButtonPopUp.Text = "Cancel";
            this.CancelButtonPopUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelButtonPopUp.UseVisualStyleBackColor = false;
            this.CancelButtonPopUp.Click += new System.EventHandler(this.CancelButtonPopUp_Click);
            // 
            // SaveButtonPopUp
            // 
            this.SaveButtonPopUp.BackColor = System.Drawing.Color.Green;
            this.SaveButtonPopUp.FlatAppearance.BorderSize = 0;
            this.SaveButtonPopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButtonPopUp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonPopUp.ForeColor = System.Drawing.Color.White;
            this.SaveButtonPopUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButtonPopUp.Location = new System.Drawing.Point(124, 3);
            this.SaveButtonPopUp.Name = "SaveButtonPopUp";
            this.SaveButtonPopUp.Size = new System.Drawing.Size(198, 94);
            this.SaveButtonPopUp.TabIndex = 10;
            this.SaveButtonPopUp.Text = "Save";
            this.SaveButtonPopUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButtonPopUp.UseVisualStyleBackColor = false;
            this.SaveButtonPopUp.Click += new System.EventHandler(this.SaveButtonPopUp_Click);
            // 
            // TopPanelPopUp
            // 
            this.TopPanelPopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.TopPanelPopUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelPopUp.Location = new System.Drawing.Point(0, 0);
            this.TopPanelPopUp.Name = "TopPanelPopUp";
            this.TopPanelPopUp.Size = new System.Drawing.Size(845, 20);
            this.TopPanelPopUp.TabIndex = 2;
            this.TopPanelPopUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelPopUp_MouseDown);
            // 
            // LeftPanelPopUp
            // 
            this.LeftPanelPopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.LeftPanelPopUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanelPopUp.Location = new System.Drawing.Point(0, 20);
            this.LeftPanelPopUp.Name = "LeftPanelPopUp";
            this.LeftPanelPopUp.Size = new System.Drawing.Size(20, 363);
            this.LeftPanelPopUp.TabIndex = 3;
            // 
            // RightPanelPopUp
            // 
            this.RightPanelPopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.RightPanelPopUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanelPopUp.Location = new System.Drawing.Point(825, 20);
            this.RightPanelPopUp.Name = "RightPanelPopUp";
            this.RightPanelPopUp.Size = new System.Drawing.Size(20, 363);
            this.RightPanelPopUp.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addProductUserControl1);
            this.panel1.Controls.Add(this.addCustomerPopUpMainPanelUserControl1);
            this.panel1.Controls.Add(this.addOrderPopUpMainPanelUserControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 363);
            this.panel1.TabIndex = 5;
            // 
            // addProductUserControl1
            // 
            this.addProductUserControl1.BackColor = System.Drawing.Color.White;
            this.addProductUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addProductUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.addProductUserControl1.Name = "addProductUserControl1";
            this.addProductUserControl1.Size = new System.Drawing.Size(805, 363);
            this.addProductUserControl1.TabIndex = 2;
            // 
            // addCustomerPopUpMainPanelUserControl1
            // 
            this.addCustomerPopUpMainPanelUserControl1.BackColor = System.Drawing.Color.White;
            this.addCustomerPopUpMainPanelUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerPopUpMainPanelUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addCustomerPopUpMainPanelUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.addCustomerPopUpMainPanelUserControl1.Name = "addCustomerPopUpMainPanelUserControl1";
            this.addCustomerPopUpMainPanelUserControl1.Size = new System.Drawing.Size(805, 363);
            this.addCustomerPopUpMainPanelUserControl1.TabIndex = 0;
            // 
            // addOrderPopUpMainPanelUserControl1
            // 
            this.addOrderPopUpMainPanelUserControl1.BackColor = System.Drawing.Color.White;
            this.addOrderPopUpMainPanelUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderPopUpMainPanelUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addOrderPopUpMainPanelUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.addOrderPopUpMainPanelUserControl1.Name = "addOrderPopUpMainPanelUserControl1";
            this.addOrderPopUpMainPanelUserControl1.Size = new System.Drawing.Size(805, 363);
            this.addOrderPopUpMainPanelUserControl1.TabIndex = 1;
            // 
            // AddPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RightPanelPopUp);
            this.Controls.Add(this.LeftPanelPopUp);
            this.Controls.Add(this.TopPanelPopUp);
            this.Controls.Add(this.ButtonPanelPopUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPopUp";
            this.ButtonPanelPopUp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ButtonPanelPopUp;
        private System.Windows.Forms.Button CancelButtonPopUp;
        private System.Windows.Forms.Button SaveButtonPopUp;
        private System.Windows.Forms.Panel TopPanelPopUp;
        private System.Windows.Forms.Panel LeftPanelPopUp;
        private System.Windows.Forms.Panel RightPanelPopUp;
        private System.Windows.Forms.Panel panel1;
        private AddCustomerPopUpMainPanelUserControl addCustomerPopUpMainPanelUserControl1;
        private AddOrderPopUpMainPanelUserControl addOrderPopUpMainPanelUserControl1;
        private AddProductUserControl addProductUserControl1;
    }
}