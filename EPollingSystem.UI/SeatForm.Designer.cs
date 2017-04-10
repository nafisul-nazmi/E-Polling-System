namespace EPollingSystem.UI
{
    partial class SeatForm
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
            this.seatGrid = new System.Windows.Forms.DataGridView();
            this.showSeatsButton = new System.Windows.Forms.Button();
            this.deleteSeatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addSeatTextBox = new System.Windows.Forms.TextBox();
            this.addSeatComboBox = new System.Windows.Forms.ComboBox();
            this.addSeatButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectDistrictComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.seatGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // seatGrid
            // 
            this.seatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seatGrid.Location = new System.Drawing.Point(48, 33);
            this.seatGrid.Name = "seatGrid";
            this.seatGrid.Size = new System.Drawing.Size(356, 261);
            this.seatGrid.TabIndex = 0;
            // 
            // showSeatsButton
            // 
            this.showSeatsButton.Location = new System.Drawing.Point(48, 366);
            this.showSeatsButton.Name = "showSeatsButton";
            this.showSeatsButton.Size = new System.Drawing.Size(162, 23);
            this.showSeatsButton.TabIndex = 1;
            this.showSeatsButton.Text = "Show All Seats";
            this.showSeatsButton.UseVisualStyleBackColor = true;
            this.showSeatsButton.Click += new System.EventHandler(this.showSeatsButton_Click);
            // 
            // deleteSeatButton
            // 
            this.deleteSeatButton.Location = new System.Drawing.Point(242, 366);
            this.deleteSeatButton.Name = "deleteSeatButton";
            this.deleteSeatButton.Size = new System.Drawing.Size(162, 23);
            this.deleteSeatButton.TabIndex = 1;
            this.deleteSeatButton.Text = "Delete Selected Seat";
            this.deleteSeatButton.UseVisualStyleBackColor = true;
            this.deleteSeatButton.Click += new System.EventHandler(this.deleteSeatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seat Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "District:";
            // 
            // addSeatTextBox
            // 
            this.addSeatTextBox.Location = new System.Drawing.Point(127, 417);
            this.addSeatTextBox.Name = "addSeatTextBox";
            this.addSeatTextBox.Size = new System.Drawing.Size(277, 20);
            this.addSeatTextBox.TabIndex = 4;
            // 
            // addSeatComboBox
            // 
            this.addSeatComboBox.FormattingEnabled = true;
            this.addSeatComboBox.Location = new System.Drawing.Point(127, 450);
            this.addSeatComboBox.Name = "addSeatComboBox";
            this.addSeatComboBox.Size = new System.Drawing.Size(277, 21);
            this.addSeatComboBox.TabIndex = 5;
            // 
            // addSeatButton
            // 
            this.addSeatButton.Location = new System.Drawing.Point(48, 497);
            this.addSeatButton.Name = "addSeatButton";
            this.addSeatButton.Size = new System.Drawing.Size(162, 23);
            this.addSeatButton.TabIndex = 1;
            this.addSeatButton.Text = "Add New Seat";
            this.addSeatButton.UseVisualStyleBackColor = true;
            this.addSeatButton.Click += new System.EventHandler(this.addSeatButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select District:";
            // 
            // selectDistrictComboBox
            // 
            this.selectDistrictComboBox.FormattingEnabled = true;
            this.selectDistrictComboBox.Location = new System.Drawing.Point(140, 321);
            this.selectDistrictComboBox.Name = "selectDistrictComboBox";
            this.selectDistrictComboBox.Size = new System.Drawing.Size(264, 21);
            this.selectDistrictComboBox.TabIndex = 7;
            this.selectDistrictComboBox.SelectedValueChanged += new System.EventHandler(this.selectDistrictComboBox_SelectedValueChanged);
            // 
            // SeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 548);
            this.Controls.Add(this.selectDistrictComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addSeatComboBox);
            this.Controls.Add(this.addSeatTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSeatButton);
            this.Controls.Add(this.deleteSeatButton);
            this.Controls.Add(this.showSeatsButton);
            this.Controls.Add(this.seatGrid);
            this.Name = "SeatForm";
            this.Text = "SeatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeatForm_FormClosed);
            this.Load += new System.EventHandler(this.SeatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seatGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView seatGrid;
        private System.Windows.Forms.Button showSeatsButton;
        private System.Windows.Forms.Button deleteSeatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addSeatTextBox;
        private System.Windows.Forms.ComboBox addSeatComboBox;
        private System.Windows.Forms.Button addSeatButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectDistrictComboBox;
    }
}