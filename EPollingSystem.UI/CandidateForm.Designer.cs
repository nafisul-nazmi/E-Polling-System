namespace EPollingSystem.UI
{
    partial class CandidateForm
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
            this.candidateGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectDistrictComboBox = new System.Windows.Forms.ComboBox();
            this.selectSeatComboBox = new System.Windows.Forms.ComboBox();
            this.showCandidateButton = new System.Windows.Forms.Button();
            this.deleteCandidateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.candidateNameTextBox = new System.Windows.Forms.TextBox();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.seatComboBox = new System.Windows.Forms.ComboBox();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.addCandidateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // candidateGrid
            // 
            this.candidateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateGrid.Location = new System.Drawing.Point(53, 31);
            this.candidateGrid.Name = "candidateGrid";
            this.candidateGrid.Size = new System.Drawing.Size(569, 232);
            this.candidateGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select District:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Seat:";
            // 
            // selectDistrictComboBox
            // 
            this.selectDistrictComboBox.FormattingEnabled = true;
            this.selectDistrictComboBox.Location = new System.Drawing.Point(164, 286);
            this.selectDistrictComboBox.Name = "selectDistrictComboBox";
            this.selectDistrictComboBox.Size = new System.Drawing.Size(293, 21);
            this.selectDistrictComboBox.TabIndex = 2;
            this.selectDistrictComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDistrictComboBox_SelectedIndexChanged);
            // 
            // selectSeatComboBox
            // 
            this.selectSeatComboBox.FormattingEnabled = true;
            this.selectSeatComboBox.Location = new System.Drawing.Point(164, 317);
            this.selectSeatComboBox.Name = "selectSeatComboBox";
            this.selectSeatComboBox.Size = new System.Drawing.Size(293, 21);
            this.selectSeatComboBox.TabIndex = 2;
            // 
            // showCandidateButton
            // 
            this.showCandidateButton.Location = new System.Drawing.Point(50, 366);
            this.showCandidateButton.Name = "showCandidateButton";
            this.showCandidateButton.Size = new System.Drawing.Size(162, 23);
            this.showCandidateButton.TabIndex = 3;
            this.showCandidateButton.Text = "Show Candidates";
            this.showCandidateButton.UseVisualStyleBackColor = true;
            this.showCandidateButton.Click += new System.EventHandler(this.showCandidateButton_Click);
            // 
            // deleteCandidateButton
            // 
            this.deleteCandidateButton.Location = new System.Drawing.Point(295, 366);
            this.deleteCandidateButton.Name = "deleteCandidateButton";
            this.deleteCandidateButton.Size = new System.Drawing.Size(162, 23);
            this.deleteCandidateButton.TabIndex = 3;
            this.deleteCandidateButton.Text = "Delete Selected Candidate";
            this.deleteCandidateButton.UseVisualStyleBackColor = true;
            this.deleteCandidateButton.Click += new System.EventHandler(this.deleteCandidateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Candidate Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "District:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Team:";
            // 
            // candidateNameTextBox
            // 
            this.candidateNameTextBox.Location = new System.Drawing.Point(164, 423);
            this.candidateNameTextBox.Name = "candidateNameTextBox";
            this.candidateNameTextBox.Size = new System.Drawing.Size(293, 20);
            this.candidateNameTextBox.TabIndex = 5;
            // 
            // districtComboBox
            // 
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(164, 452);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(293, 21);
            this.districtComboBox.TabIndex = 2;
            this.districtComboBox.SelectedIndexChanged += new System.EventHandler(this.districtComboBox_SelectedIndexChanged);
            // 
            // seatComboBox
            // 
            this.seatComboBox.FormattingEnabled = true;
            this.seatComboBox.Location = new System.Drawing.Point(164, 482);
            this.seatComboBox.Name = "seatComboBox";
            this.seatComboBox.Size = new System.Drawing.Size(293, 21);
            this.seatComboBox.TabIndex = 2;
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(164, 513);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(293, 21);
            this.teamComboBox.TabIndex = 2;
            // 
            // addCandidateButton
            // 
            this.addCandidateButton.Location = new System.Drawing.Point(50, 554);
            this.addCandidateButton.Name = "addCandidateButton";
            this.addCandidateButton.Size = new System.Drawing.Size(162, 23);
            this.addCandidateButton.TabIndex = 3;
            this.addCandidateButton.Text = "Add New Candidate";
            this.addCandidateButton.UseVisualStyleBackColor = true;
            this.addCandidateButton.Click += new System.EventHandler(this.addCandidateButton_Click);
            // 
            // CandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 612);
            this.Controls.Add(this.candidateNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteCandidateButton);
            this.Controls.Add(this.addCandidateButton);
            this.Controls.Add(this.showCandidateButton);
            this.Controls.Add(this.teamComboBox);
            this.Controls.Add(this.seatComboBox);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.selectSeatComboBox);
            this.Controls.Add(this.selectDistrictComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.candidateGrid);
            this.Name = "CandidateForm";
            this.Text = "CandidateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CandidateForm_FormClosed);
            this.Load += new System.EventHandler(this.CandidateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidateGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView candidateGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectDistrictComboBox;
        private System.Windows.Forms.ComboBox selectSeatComboBox;
        private System.Windows.Forms.Button showCandidateButton;
        private System.Windows.Forms.Button deleteCandidateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox candidateNameTextBox;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.ComboBox seatComboBox;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.Button addCandidateButton;
    }
}