namespace FirestationSystem.View
{
    partial class AccountView
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusCmbBox = new System.Windows.Forms.ComboBox();
            this.StatusConfirmButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(76, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(68, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team:";
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Location = new System.Drawing.Point(76, 32);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(37, 13);
            this.TeamLabel.TabIndex = 3;
            this.TeamLabel.Text = "TEAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(76, 56);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(50, 13);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Update status:";
            // 
            // StatusCmbBox
            // 
            this.StatusCmbBox.FormattingEnabled = true;
            this.StatusCmbBox.Location = new System.Drawing.Point(15, 105);
            this.StatusCmbBox.Name = "StatusCmbBox";
            this.StatusCmbBox.Size = new System.Drawing.Size(121, 21);
            this.StatusCmbBox.TabIndex = 7;
            // 
            // StatusConfirmButton
            // 
            this.StatusConfirmButton.Location = new System.Drawing.Point(142, 105);
            this.StatusConfirmButton.Name = "StatusConfirmButton";
            this.StatusConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.StatusConfirmButton.TabIndex = 8;
            this.StatusConfirmButton.Text = "Confirm";
            this.StatusConfirmButton.UseVisualStyleBackColor = true;
            this.StatusConfirmButton.Click += new System.EventHandler(this.StatusConfirmButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(194, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = ">";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 133);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StatusConfirmButton);
            this.Controls.Add(this.StatusCmbBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "AccountView";
            this.Text = "AccountView";
            this.Load += new System.EventHandler(this.AccountView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StatusCmbBox;
        private System.Windows.Forms.Button StatusConfirmButton;
        private System.Windows.Forms.Button BackButton;
    }
}