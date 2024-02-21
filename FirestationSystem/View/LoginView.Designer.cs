namespace FirestationSystem.View
{
    partial class LoginView
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
            this.Label = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(68, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(33, 13);
            this.Label.TabIndex = 7;
            this.Label.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(50, 106);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(9, 78);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(162, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.AccessibleDescription = "";
            this.UsernameTextBox.AccessibleName = "";
            this.UsernameTextBox.Location = new System.Drawing.Point(9, 41);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(162, 20);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // RegisterViewButton
            // 
            this.RegisterViewButton.Location = new System.Drawing.Point(202, 106);
            this.RegisterViewButton.Name = "RegisterViewButton";
            this.RegisterViewButton.Size = new System.Drawing.Size(59, 23);
            this.RegisterViewButton.TabIndex = 8;
            this.RegisterViewButton.Text = "Register";
            this.RegisterViewButton.UseVisualStyleBackColor = true;
            this.RegisterViewButton.Click += new System.EventHandler(this.RegisterViewButton_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 135);
            this.Controls.Add(this.RegisterViewButton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button RegisterViewButton;
    }
}