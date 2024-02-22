namespace FirestationSystem.View
{
    partial class PortalView
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
            this.AccountViewButton = new System.Windows.Forms.Button();
            this.DisasterViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountViewButton
            // 
            this.AccountViewButton.Location = new System.Drawing.Point(12, 12);
            this.AccountViewButton.Name = "AccountViewButton";
            this.AccountViewButton.Size = new System.Drawing.Size(96, 23);
            this.AccountViewButton.TabIndex = 0;
            this.AccountViewButton.Text = "my account";
            this.AccountViewButton.UseVisualStyleBackColor = true;
            this.AccountViewButton.Click += new System.EventHandler(this.AccountViewButton_Click);
            // 
            // DisasterViewButton
            // 
            this.DisasterViewButton.Location = new System.Drawing.Point(12, 52);
            this.DisasterViewButton.Name = "DisasterViewButton";
            this.DisasterViewButton.Size = new System.Drawing.Size(96, 23);
            this.DisasterViewButton.TabIndex = 1;
            this.DisasterViewButton.Text = "Disasters";
            this.DisasterViewButton.UseVisualStyleBackColor = true;
            this.DisasterViewButton.Click += new System.EventHandler(this.DisasterViewButton_Click);
            // 
            // PortalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 90);
            this.Controls.Add(this.DisasterViewButton);
            this.Controls.Add(this.AccountViewButton);
            this.Name = "PortalView";
            this.Text = "PortalView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AccountViewButton;
        private System.Windows.Forms.Button DisasterViewButton;
    }
}