namespace FirestationSystem.View
{
    partial class IncidentView
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.GpsTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.cbmResponderBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DeletionTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(115, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(660, 263);
            this.DataGrid.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(8, 354);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(9, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(9, 77);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(9, 127);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 5;
            // 
            // GpsTextBox
            // 
            this.GpsTextBox.Location = new System.Drawing.Point(9, 179);
            this.GpsTextBox.Name = "GpsTextBox";
            this.GpsTextBox.Size = new System.Drawing.Size(100, 20);
            this.GpsTextBox.TabIndex = 6;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(9, 243);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.StatusTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(8, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(25, 23);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // cbmResponderBox
            // 
            this.cbmResponderBox.FormattingEnabled = true;
            this.cbmResponderBox.Location = new System.Drawing.Point(8, 308);
            this.cbmResponderBox.Name = "cbmResponderBox";
            this.cbmResponderBox.Size = new System.Drawing.Size(101, 21);
            this.cbmResponderBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Responding team";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(172, 353);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Delete incident";
            // 
            // DeletionTextBox
            // 
            this.DeletionTextBox.Location = new System.Drawing.Point(172, 309);
            this.DeletionTextBox.Name = "DeletionTextBox";
            this.DeletionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeletionTextBox.TabIndex = 18;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(115, 252);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 19;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // IncidentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 389);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeletionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbmResponderBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.GpsTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DataGrid);
            this.Name = "IncidentView";
            this.Text = "Incidents";
            this.Load += new System.EventHandler(this.IncidentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox GpsTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox cbmResponderBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DeletionTextBox;
        private System.Windows.Forms.Button RefreshButton;
    }
}