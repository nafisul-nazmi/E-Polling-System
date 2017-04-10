namespace EPollingSystem.UI
{
    partial class VotingWindow
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
            this.nIdTextBox = new System.Windows.Forms.TextBox();
            this.candidateGrid = new System.Windows.Forms.DataGridView();
            this.voteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your NID:";
            // 
            // nIdTextBox
            // 
            this.nIdTextBox.Location = new System.Drawing.Point(166, 55);
            this.nIdTextBox.Name = "nIdTextBox";
            this.nIdTextBox.Size = new System.Drawing.Size(331, 20);
            this.nIdTextBox.TabIndex = 1;
            // 
            // candidateGrid
            // 
            this.candidateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateGrid.Location = new System.Drawing.Point(68, 120);
            this.candidateGrid.Name = "candidateGrid";
            this.candidateGrid.Size = new System.Drawing.Size(429, 220);
            this.candidateGrid.TabIndex = 2;
            // 
            // voteButton
            // 
            this.voteButton.Location = new System.Drawing.Point(68, 369);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(131, 31);
            this.voteButton.TabIndex = 3;
            this.voteButton.Text = "Vote";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // VotingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 432);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.candidateGrid);
            this.Controls.Add(this.nIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "VotingWindow";
            this.Text = "VotingWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VotingWindow_FormClosed);
            this.Load += new System.EventHandler(this.VotingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidateGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nIdTextBox;
        private System.Windows.Forms.DataGridView candidateGrid;
        private System.Windows.Forms.Button voteButton;
    }
}