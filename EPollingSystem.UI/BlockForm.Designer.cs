namespace EPollingSystem.UI
{
    partial class BlockForm
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
            this.blockGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.showSelectecButton = new System.Windows.Forms.Button();
            this.unblockButton = new System.Windows.Forms.Button();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.seatComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.blockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // blockGrid
            // 
            this.blockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blockGrid.Location = new System.Drawing.Point(57, 56);
            this.blockGrid.Name = "blockGrid";
            this.blockGrid.Size = new System.Drawing.Size(465, 217);
            this.blockGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select District:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Seat:";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(57, 396);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(132, 47);
            this.showAllButton.TabIndex = 2;
            this.showAllButton.Text = "Show All Blocked Centers";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // showSelectecButton
            // 
            this.showSelectecButton.Location = new System.Drawing.Point(225, 396);
            this.showSelectecButton.Name = "showSelectecButton";
            this.showSelectecButton.Size = new System.Drawing.Size(132, 47);
            this.showSelectecButton.TabIndex = 2;
            this.showSelectecButton.Text = "Show Blocked Centers in Seleted Seat";
            this.showSelectecButton.UseVisualStyleBackColor = true;
            this.showSelectecButton.Click += new System.EventHandler(this.showSelectecButton_Click);
            // 
            // unblockButton
            // 
            this.unblockButton.Location = new System.Drawing.Point(390, 396);
            this.unblockButton.Name = "unblockButton";
            this.unblockButton.Size = new System.Drawing.Size(132, 47);
            this.unblockButton.TabIndex = 2;
            this.unblockButton.Text = "Unblock Selected";
            this.unblockButton.UseVisualStyleBackColor = true;
            this.unblockButton.Click += new System.EventHandler(this.unblockButton_Click);
            // 
            // districtComboBox
            // 
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(193, 315);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(329, 21);
            this.districtComboBox.TabIndex = 3;
            this.districtComboBox.SelectedIndexChanged += new System.EventHandler(this.districtComboBox_SelectedIndexChanged);
            // 
            // seatComboBox
            // 
            this.seatComboBox.FormattingEnabled = true;
            this.seatComboBox.Location = new System.Drawing.Point(193, 351);
            this.seatComboBox.Name = "seatComboBox";
            this.seatComboBox.Size = new System.Drawing.Size(329, 21);
            this.seatComboBox.TabIndex = 3;
            // 
            // BlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 474);
            this.Controls.Add(this.seatComboBox);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.unblockButton);
            this.Controls.Add(this.showSelectecButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blockGrid);
            this.Name = "BlockForm";
            this.Text = "BlockForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BlockForm_FormClosed);
            this.Load += new System.EventHandler(this.BlockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blockGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView blockGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button showSelectecButton;
        private System.Windows.Forms.Button unblockButton;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.ComboBox seatComboBox;
    }
}