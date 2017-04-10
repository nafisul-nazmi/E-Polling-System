namespace EPollingSystem.UI
{
    partial class VoterForm
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
            this.voterGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectDistrcitComboBox = new System.Windows.Forms.ComboBox();
            this.selectSeatComboBox = new System.Windows.Forms.ComboBox();
            this.selectCenterComboBox = new System.Windows.Forms.ComboBox();
            this.showVoterButton = new System.Windows.Forms.Button();
            this.deleteVoterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.seatComboBox = new System.Windows.Forms.ComboBox();
            this.centerComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nIdTextBox = new System.Windows.Forms.TextBox();
            this.addVoterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.voterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // voterGrid
            // 
            this.voterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voterGrid.Location = new System.Drawing.Point(55, 48);
            this.voterGrid.Name = "voterGrid";
            this.voterGrid.Size = new System.Drawing.Size(377, 208);
            this.voterGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "District:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Center:";
            // 
            // selectDistrcitComboBox
            // 
            this.selectDistrcitComboBox.FormattingEnabled = true;
            this.selectDistrcitComboBox.Location = new System.Drawing.Point(137, 285);
            this.selectDistrcitComboBox.Name = "selectDistrcitComboBox";
            this.selectDistrcitComboBox.Size = new System.Drawing.Size(295, 21);
            this.selectDistrcitComboBox.TabIndex = 2;
            this.selectDistrcitComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDistrcitComboBox_SelectedIndexChanged);
            // 
            // selectSeatComboBox
            // 
            this.selectSeatComboBox.FormattingEnabled = true;
            this.selectSeatComboBox.Location = new System.Drawing.Point(137, 323);
            this.selectSeatComboBox.Name = "selectSeatComboBox";
            this.selectSeatComboBox.Size = new System.Drawing.Size(295, 21);
            this.selectSeatComboBox.TabIndex = 2;
            this.selectSeatComboBox.SelectedIndexChanged += new System.EventHandler(this.selectSeatComboBox_SelectedIndexChanged);
            // 
            // selectCenterComboBox
            // 
            this.selectCenterComboBox.FormattingEnabled = true;
            this.selectCenterComboBox.Location = new System.Drawing.Point(137, 358);
            this.selectCenterComboBox.Name = "selectCenterComboBox";
            this.selectCenterComboBox.Size = new System.Drawing.Size(295, 21);
            this.selectCenterComboBox.TabIndex = 2;
            // 
            // showVoterButton
            // 
            this.showVoterButton.Location = new System.Drawing.Point(55, 400);
            this.showVoterButton.Name = "showVoterButton";
            this.showVoterButton.Size = new System.Drawing.Size(148, 23);
            this.showVoterButton.TabIndex = 3;
            this.showVoterButton.Text = "Show Voters";
            this.showVoterButton.UseVisualStyleBackColor = true;
            this.showVoterButton.Click += new System.EventHandler(this.showVoterButton_Click);
            // 
            // deleteVoterButton
            // 
            this.deleteVoterButton.Location = new System.Drawing.Point(284, 400);
            this.deleteVoterButton.Name = "deleteVoterButton";
            this.deleteVoterButton.Size = new System.Drawing.Size(148, 23);
            this.deleteVoterButton.TabIndex = 3;
            this.deleteVoterButton.Text = "Delete Selected Voter";
            this.deleteVoterButton.UseVisualStyleBackColor = true;
            this.deleteVoterButton.Click += new System.EventHandler(this.deleteVoterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "District:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Center:";
            // 
            // districtComboBox
            // 
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(137, 492);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(295, 21);
            this.districtComboBox.TabIndex = 2;
            this.districtComboBox.SelectedIndexChanged += new System.EventHandler(this.districtComboBox_SelectedIndexChanged);
            // 
            // seatComboBox
            // 
            this.seatComboBox.FormattingEnabled = true;
            this.seatComboBox.Location = new System.Drawing.Point(137, 530);
            this.seatComboBox.Name = "seatComboBox";
            this.seatComboBox.Size = new System.Drawing.Size(295, 21);
            this.seatComboBox.TabIndex = 2;
            this.seatComboBox.SelectedIndexChanged += new System.EventHandler(this.seatComboBox_SelectedIndexChanged);
            // 
            // centerComboBox
            // 
            this.centerComboBox.FormattingEnabled = true;
            this.centerComboBox.Location = new System.Drawing.Point(137, 565);
            this.centerComboBox.Name = "centerComboBox";
            this.centerComboBox.Size = new System.Drawing.Size(295, 21);
            this.centerComboBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "NID:";
            // 
            // nIdTextBox
            // 
            this.nIdTextBox.Location = new System.Drawing.Point(137, 456);
            this.nIdTextBox.Name = "nIdTextBox";
            this.nIdTextBox.Size = new System.Drawing.Size(295, 20);
            this.nIdTextBox.TabIndex = 4;
            // 
            // addVoterButton
            // 
            this.addVoterButton.Location = new System.Drawing.Point(55, 608);
            this.addVoterButton.Name = "addVoterButton";
            this.addVoterButton.Size = new System.Drawing.Size(148, 23);
            this.addVoterButton.TabIndex = 3;
            this.addVoterButton.Text = "Add New Voter";
            this.addVoterButton.UseVisualStyleBackColor = true;
            this.addVoterButton.Click += new System.EventHandler(this.addVoterButton_Click);
            // 
            // VoterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 659);
            this.Controls.Add(this.nIdTextBox);
            this.Controls.Add(this.deleteVoterButton);
            this.Controls.Add(this.addVoterButton);
            this.Controls.Add(this.showVoterButton);
            this.Controls.Add(this.centerComboBox);
            this.Controls.Add(this.selectCenterComboBox);
            this.Controls.Add(this.seatComboBox);
            this.Controls.Add(this.selectSeatComboBox);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectDistrcitComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voterGrid);
            this.Name = "VoterForm";
            this.Text = "VoterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VoterForm_FormClosed);
            this.Load += new System.EventHandler(this.VoterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView voterGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectDistrcitComboBox;
        private System.Windows.Forms.ComboBox selectSeatComboBox;
        private System.Windows.Forms.ComboBox selectCenterComboBox;
        private System.Windows.Forms.Button showVoterButton;
        private System.Windows.Forms.Button deleteVoterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.ComboBox seatComboBox;
        private System.Windows.Forms.ComboBox centerComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nIdTextBox;
        private System.Windows.Forms.Button addVoterButton;
    }
}