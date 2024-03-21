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
            this.VehicleViewButton = new System.Windows.Forms.Button();
            this.EmployeesView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountViewButton
            // 
            this.AccountViewButton.Location = new System.Drawing.Point(16, 15);
            this.AccountViewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccountViewButton.Name = "AccountViewButton";
            this.AccountViewButton.Size = new System.Drawing.Size(128, 28);
            this.AccountViewButton.TabIndex = 0;
            this.AccountViewButton.Text = "my account";
            this.AccountViewButton.UseVisualStyleBackColor = true;
            this.AccountViewButton.Click += new System.EventHandler(this.AccountViewButton_Click);
            // 
            // DisasterViewButton
            // 
            this.DisasterViewButton.Location = new System.Drawing.Point(16, 51);
            this.DisasterViewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisasterViewButton.Name = "DisasterViewButton";
            this.DisasterViewButton.Size = new System.Drawing.Size(128, 28);
            this.DisasterViewButton.TabIndex = 1;
            this.DisasterViewButton.Text = "Disasters";
            this.DisasterViewButton.UseVisualStyleBackColor = true;
            this.DisasterViewButton.Click += new System.EventHandler(this.DisasterViewButton_Click);
            // 
            // VehicleViewButton
            // 
            this.VehicleViewButton.Location = new System.Drawing.Point(16, 87);
            this.VehicleViewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VehicleViewButton.Name = "VehicleViewButton";
            this.VehicleViewButton.Size = new System.Drawing.Size(128, 28);
            this.VehicleViewButton.TabIndex = 2;
            this.VehicleViewButton.Text = "Vehicles";
            this.VehicleViewButton.UseVisualStyleBackColor = true;
            this.VehicleViewButton.Click += new System.EventHandler(this.VehicleViewButton_Click);
            // 
            // EmployeesView
            // 
            this.EmployeesView.Location = new System.Drawing.Point(16, 123);
            this.EmployeesView.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeesView.Name = "EmployeesView";
            this.EmployeesView.Size = new System.Drawing.Size(128, 28);
            this.EmployeesView.TabIndex = 3;
            this.EmployeesView.Text = "Employees";
            this.EmployeesView.UseVisualStyleBackColor = true;
            this.EmployeesView.Click += new System.EventHandler(this.EmployeesView_Click);
            // 
            // PortalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 163);
            this.Controls.Add(this.EmployeesView);
            this.Controls.Add(this.VehicleViewButton);
            this.Controls.Add(this.DisasterViewButton);
            this.Controls.Add(this.AccountViewButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PortalView";
            this.Text = "PortalView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AccountViewButton;
        private System.Windows.Forms.Button DisasterViewButton;
        private System.Windows.Forms.Button VehicleViewButton;
        private System.Windows.Forms.Button EmployeesView;
    }
}