namespace UI
{
    partial class FrontPageUserControl
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
            this.SynsPunktFrontText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SynsPunktFrontText
            // 
            this.SynsPunktFrontText.AutoSize = true;
            this.SynsPunktFrontText.BackColor = System.Drawing.Color.White;
            this.SynsPunktFrontText.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SynsPunktFrontText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
            this.SynsPunktFrontText.Location = new System.Drawing.Point(357, 314);
            this.SynsPunktFrontText.Name = "SynsPunktFrontText";
            this.SynsPunktFrontText.Size = new System.Drawing.Size(508, 112);
            this.SynsPunktFrontText.TabIndex = 0;
            this.SynsPunktFrontText.Text = "SynsPunkt";
            this.SynsPunktFrontText.Click += new System.EventHandler(this.SynsPunktFrontText_Click);
            // 
            // FrontPageUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SynsPunktFrontText);
            this.Name = "FrontPageUserControl";
            this.Size = new System.Drawing.Size(1211, 774);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SynsPunktFrontText;
    }
}
