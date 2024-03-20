namespace FirestationSystem.View
{
    partial class VehicleView
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
            this.label1 = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShiftStartTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShiftEndTimeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(776, 277);
            this.DataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(12, 324);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.StatusTextBox.TabIndex = 11;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(142, 324);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 10;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 382);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 23);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "shift start";
            // 
            // ShiftStartTimeTextBox
            // 
            this.ShiftStartTimeTextBox.Location = new System.Drawing.Point(275, 324);
            this.ShiftStartTimeTextBox.Name = "ShiftStartTimeTextBox";
            this.ShiftStartTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShiftStartTimeTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "shift end";
            // 
            // ShiftEndTimeTextBox
            // 
            this.ShiftEndTimeTextBox.Location = new System.Drawing.Point(398, 324);
            this.ShiftEndTimeTextBox.Name = "ShiftEndTimeTextBox";
            this.ShiftEndTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShiftEndTimeTextBox.TabIndex = 16;
            // 
            // VehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShiftEndTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShiftStartTimeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DataGrid);
            this.Name = "VehicleView";
            this.Text = "VehicleView";
            this.Load += new System.EventHandler(this.VehicleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ShiftStartTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ShiftEndTimeTextBox;
    }
}