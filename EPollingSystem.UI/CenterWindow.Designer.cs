namespace EPollingSystem.UI
{
    partial class CenterWindow
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
            this.nidTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.permitButton = new System.Windows.Forms.Button();
            this.votingWindowButton = new System.Windows.Forms.Button();
            this.blockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter NID:";
            // 
            // nidTextBox
            // 
            this.nidTextBox.Location = new System.Drawing.Point(154, 59);
            this.nidTextBox.Name = "nidTextBox";
            this.nidTextBox.Size = new System.Drawing.Size(231, 20);
            this.nidTextBox.TabIndex = 1;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(61, 111);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(156, 23);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // permitButton
            // 
            this.permitButton.Location = new System.Drawing.Point(229, 111);
            this.permitButton.Name = "permitButton";
            this.permitButton.Size = new System.Drawing.Size(156, 23);
            this.permitButton.TabIndex = 2;
            this.permitButton.Text = "Permit";
            this.permitButton.UseVisualStyleBackColor = true;
            this.permitButton.Click += new System.EventHandler(this.permitButton_Click);
            // 
            // votingWindowButton
            // 
            this.votingWindowButton.Location = new System.Drawing.Point(61, 178);
            this.votingWindowButton.Name = "votingWindowButton";
            this.votingWindowButton.Size = new System.Drawing.Size(324, 31);
            this.votingWindowButton.TabIndex = 3;
            this.votingWindowButton.Text = "Go To Voting Window";
            this.votingWindowButton.UseVisualStyleBackColor = true;
            this.votingWindowButton.Click += new System.EventHandler(this.votingWindowButton_Click);
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(61, 235);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(324, 32);
            this.blockButton.TabIndex = 4;
            this.blockButton.Text = "Block this Center";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // CenterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 319);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.votingWindowButton);
            this.Controls.Add(this.permitButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.nidTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CenterWindow";
            this.Text = "CenterWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CenterWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nidTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button permitButton;
        private System.Windows.Forms.Button votingWindowButton;
        private System.Windows.Forms.Button blockButton;
    }
}