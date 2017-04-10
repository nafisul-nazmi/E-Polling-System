namespace EPollingSystem.UI
{
    partial class CenterForm
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
            this.centerGrid = new System.Windows.Forms.DataGridView();
            this.showCenterButton = new System.Windows.Forms.Button();
            this.deleteCenterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.centerTextBox = new System.Windows.Forms.TextBox();
            this.agentTextBox = new System.Windows.Forms.TextBox();
            this.seatComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addCenterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selectDistrictComboBox = new System.Windows.Forms.ComboBox();
            this.selectSeatComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.centerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // centerGrid
            // 
            this.centerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.centerGrid.Location = new System.Drawing.Point(48, 43);
            this.centerGrid.Name = "centerGrid";
            this.centerGrid.Size = new System.Drawing.Size(463, 278);
            this.centerGrid.TabIndex = 0;
            // 
            // showCenterButton
            // 
            this.showCenterButton.Location = new System.Drawing.Point(48, 424);
            this.showCenterButton.Name = "showCenterButton";
            this.showCenterButton.Size = new System.Drawing.Size(171, 23);
            this.showCenterButton.TabIndex = 1;
            this.showCenterButton.Text = "Show All Centers";
            this.showCenterButton.UseVisualStyleBackColor = true;
            this.showCenterButton.Click += new System.EventHandler(this.showCenterButton_Click);
            // 
            // deleteCenterButton
            // 
            this.deleteCenterButton.Location = new System.Drawing.Point(346, 424);
            this.deleteCenterButton.Name = "deleteCenterButton";
            this.deleteCenterButton.Size = new System.Drawing.Size(171, 23);
            this.deleteCenterButton.TabIndex = 1;
            this.deleteCenterButton.Text = "Delete Selected Center";
            this.deleteCenterButton.UseVisualStyleBackColor = true;
            this.deleteCenterButton.Click += new System.EventHandler(this.deleteCenterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Center Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agent Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // centerTextBox
            // 
            this.centerTextBox.Location = new System.Drawing.Point(135, 471);
            this.centerTextBox.Name = "centerTextBox";
            this.centerTextBox.Size = new System.Drawing.Size(382, 20);
            this.centerTextBox.TabIndex = 4;
            // 
            // agentTextBox
            // 
            this.agentTextBox.Location = new System.Drawing.Point(135, 505);
            this.agentTextBox.Name = "agentTextBox";
            this.agentTextBox.Size = new System.Drawing.Size(382, 20);
            this.agentTextBox.TabIndex = 4;
            // 
            // seatComboBox
            // 
            this.seatComboBox.FormattingEnabled = true;
            this.seatComboBox.Location = new System.Drawing.Point(385, 539);
            this.seatComboBox.Name = "seatComboBox";
            this.seatComboBox.Size = new System.Drawing.Size(132, 21);
            this.seatComboBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(135, 573);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(132, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(385, 573);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(132, 20);
            this.confirmPasswordTextBox.TabIndex = 4;
            // 
            // addCenterButton
            // 
            this.addCenterButton.Location = new System.Drawing.Point(48, 620);
            this.addCenterButton.Name = "addCenterButton";
            this.addCenterButton.Size = new System.Drawing.Size(171, 23);
            this.addCenterButton.TabIndex = 1;
            this.addCenterButton.Text = "Add New Center";
            this.addCenterButton.UseVisualStyleBackColor = true;
            this.addCenterButton.Click += new System.EventHandler(this.addCenterButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Select District:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Select Seat:";
            // 
            // selectDistrictComboBox
            // 
            this.selectDistrictComboBox.FormattingEnabled = true;
            this.selectDistrictComboBox.Location = new System.Drawing.Point(129, 342);
            this.selectDistrictComboBox.Name = "selectDistrictComboBox";
            this.selectDistrictComboBox.Size = new System.Drawing.Size(382, 21);
            this.selectDistrictComboBox.TabIndex = 7;
            this.selectDistrictComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDistrictComboBox_SelectedIndexChanged);
            // 
            // selectSeatComboBox
            // 
            this.selectSeatComboBox.FormattingEnabled = true;
            this.selectSeatComboBox.Location = new System.Drawing.Point(129, 379);
            this.selectSeatComboBox.Name = "selectSeatComboBox";
            this.selectSeatComboBox.Size = new System.Drawing.Size(382, 21);
            this.selectSeatComboBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "District";
            // 
            // districtComboBox
            // 
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(135, 539);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(132, 21);
            this.districtComboBox.TabIndex = 5;
            this.districtComboBox.SelectedIndexChanged += new System.EventHandler(this.districtComboBox_SelectedIndexChanged);
            // 
            // CenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 676);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectSeatComboBox);
            this.Controls.Add(this.selectDistrictComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.seatComboBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.agentTextBox);
            this.Controls.Add(this.centerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCenterButton);
            this.Controls.Add(this.deleteCenterButton);
            this.Controls.Add(this.showCenterButton);
            this.Controls.Add(this.centerGrid);
            this.Name = "CenterForm";
            this.Text = "CenterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CenterForm_FormClosed);
            this.Load += new System.EventHandler(this.CenterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView centerGrid;
        private System.Windows.Forms.Button showCenterButton;
        private System.Windows.Forms.Button deleteCenterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox centerTextBox;
        private System.Windows.Forms.TextBox agentTextBox;
        private System.Windows.Forms.ComboBox seatComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Button addCenterButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectDistrictComboBox;
        private System.Windows.Forms.ComboBox selectSeatComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox districtComboBox;
    }
}