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
        private void InitializeComponent()
        {
            this.ButtonPanelPopUp = new System.Windows.Forms.Panel();
            this.SaveButtonPopUp = new System.Windows.Forms.Button();
            this.CancelButtonPopUp = new System.Windows.Forms.Button();
            this.MainPanelPopUp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonPanelPopUp.SuspendLayout();
            this.MainPanelPopUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanelPopUp
            // 
            this.ButtonPanelPopUp.Controls.Add(this.CancelButtonPopUp);
            this.ButtonPanelPopUp.Controls.Add(this.SaveButtonPopUp);
            this.ButtonPanelPopUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanelPopUp.Location = new System.Drawing.Point(0, 383);
            this.ButtonPanelPopUp.Name = "ButtonPanelPopUp";
            this.ButtonPanelPopUp.Size = new System.Drawing.Size(845, 100);
            this.ButtonPanelPopUp.TabIndex = 1;
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
            // 
            // MainPanelPopUp
            // 
            this.MainPanelPopUp.Controls.Add(this.label2);
            this.MainPanelPopUp.Controls.Add(this.label1);
            this.MainPanelPopUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelPopUp.Location = new System.Drawing.Point(0, 0);
            this.MainPanelPopUp.Name = "MainPanelPopUp";
            this.MainPanelPopUp.Size = new System.Drawing.Size(845, 383);
            this.MainPanelPopUp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "To do: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fade Background";
            // 
            // AddPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 483);
            this.Controls.Add(this.MainPanelPopUp);
            this.Controls.Add(this.ButtonPanelPopUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPopUp";
            this.ButtonPanelPopUp.ResumeLayout(false);
            this.MainPanelPopUp.ResumeLayout(false);
            this.MainPanelPopUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ButtonPanelPopUp;
        private System.Windows.Forms.Button CancelButtonPopUp;
        private System.Windows.Forms.Button SaveButtonPopUp;
        private System.Windows.Forms.Panel MainPanelPopUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}