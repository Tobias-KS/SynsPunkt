namespace UI
{
    partial class NotesPopUpUserControl
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
            this.TextBoxNotesPopUpUserControlMainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TextBoxNotesPopUpUserControlMainPanel
            // 
            this.TextBoxNotesPopUpUserControlMainPanel.Location = new System.Drawing.Point(12, 3);
            this.TextBoxNotesPopUpUserControlMainPanel.Name = "TextBoxNotesPopUpUserControlMainPanel";
            this.TextBoxNotesPopUpUserControlMainPanel.Size = new System.Drawing.Size(723, 323);
            this.TextBoxNotesPopUpUserControlMainPanel.TabIndex = 0;
            // 
            // NotesPopUpUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TextBoxNotesPopUpUserControlMainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NotesPopUpUserControl";
            this.Size = new System.Drawing.Size(749, 337);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TextBoxNotesPopUpUserControlMainPanel;
    }
}
