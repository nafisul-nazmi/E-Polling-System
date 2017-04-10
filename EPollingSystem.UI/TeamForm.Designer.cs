namespace EPollingSystem.UI
{
    partial class TeamForm
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
            this.teamGrid = new System.Windows.Forms.DataGridView();
            this.showTeamsButton = new System.Windows.Forms.Button();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamSymbolTextBox = new System.Windows.Forms.TextBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // teamGrid
            // 
            this.teamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGrid.Location = new System.Drawing.Point(44, 40);
            this.teamGrid.Name = "teamGrid";
            this.teamGrid.Size = new System.Drawing.Size(521, 268);
            this.teamGrid.TabIndex = 0;
            // 
            // showTeamsButton
            // 
            this.showTeamsButton.Location = new System.Drawing.Point(44, 345);
            this.showTeamsButton.Name = "showTeamsButton";
            this.showTeamsButton.Size = new System.Drawing.Size(189, 23);
            this.showTeamsButton.TabIndex = 1;
            this.showTeamsButton.Text = "Show All Teams";
            this.showTeamsButton.UseVisualStyleBackColor = true;
            this.showTeamsButton.Click += new System.EventHandler(this.showTeamsButton_Click);
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Location = new System.Drawing.Point(44, 387);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(189, 23);
            this.deleteTeamButton.TabIndex = 1;
            this.deleteTeamButton.Text = "Delete Selected Team";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Symbol:";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(136, 441);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(297, 20);
            this.teamNameTextBox.TabIndex = 3;
            // 
            // teamSymbolTextBox
            // 
            this.teamSymbolTextBox.Location = new System.Drawing.Point(136, 474);
            this.teamSymbolTextBox.Name = "teamSymbolTextBox";
            this.teamSymbolTextBox.Size = new System.Drawing.Size(297, 20);
            this.teamSymbolTextBox.TabIndex = 3;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(44, 517);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(189, 23);
            this.addTeamButton.TabIndex = 1;
            this.addTeamButton.Text = "Add New Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 577);
            this.Controls.Add(this.teamSymbolTextBox);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.showTeamsButton);
            this.Controls.Add(this.teamGrid);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeamForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView teamGrid;
        private System.Windows.Forms.Button showTeamsButton;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.TextBox teamSymbolTextBox;
        private System.Windows.Forms.Button addTeamButton;
    }
}