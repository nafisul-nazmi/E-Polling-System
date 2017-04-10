namespace EPollingSystem.UI
{
    partial class DistrictForm
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
            this.districtGrid = new System.Windows.Forms.DataGridView();
            this.showDistrictsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteDistrictButton = new System.Windows.Forms.Button();
            this.addDistrictTextBox = new System.Windows.Forms.TextBox();
            this.addDistrictButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.districtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // districtGrid
            // 
            this.districtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.districtGrid.Location = new System.Drawing.Point(47, 37);
            this.districtGrid.Name = "districtGrid";
            this.districtGrid.Size = new System.Drawing.Size(195, 165);
            this.districtGrid.TabIndex = 0;
            // 
            // showDistrictsButton
            // 
            this.showDistrictsButton.Location = new System.Drawing.Point(47, 231);
            this.showDistrictsButton.Name = "showDistrictsButton";
            this.showDistrictsButton.Size = new System.Drawing.Size(134, 23);
            this.showDistrictsButton.TabIndex = 1;
            this.showDistrictsButton.Text = "Show All Districts";
            this.showDistrictsButton.UseVisualStyleBackColor = true;
            this.showDistrictsButton.Click += new System.EventHandler(this.showDistrictsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New District:";
            // 
            // deleteDistrictButton
            // 
            this.deleteDistrictButton.Location = new System.Drawing.Point(47, 275);
            this.deleteDistrictButton.Name = "deleteDistrictButton";
            this.deleteDistrictButton.Size = new System.Drawing.Size(134, 23);
            this.deleteDistrictButton.TabIndex = 3;
            this.deleteDistrictButton.Text = "Delete Selected District";
            this.deleteDistrictButton.UseVisualStyleBackColor = true;
            this.deleteDistrictButton.Click += new System.EventHandler(this.deleteDistrictButton_Click);
            // 
            // addDistrictTextBox
            // 
            this.addDistrictTextBox.Location = new System.Drawing.Point(139, 328);
            this.addDistrictTextBox.Name = "addDistrictTextBox";
            this.addDistrictTextBox.Size = new System.Drawing.Size(157, 20);
            this.addDistrictTextBox.TabIndex = 4;
            
            // 
            // addDistrictButton
            // 
            this.addDistrictButton.Location = new System.Drawing.Point(47, 371);
            this.addDistrictButton.Name = "addDistrictButton";
            this.addDistrictButton.Size = new System.Drawing.Size(134, 23);
            this.addDistrictButton.TabIndex = 5;
            this.addDistrictButton.Text = "Add District";
            this.addDistrictButton.UseVisualStyleBackColor = true;
            this.addDistrictButton.Click += new System.EventHandler(this.addDistrictButton_Click);
            // 
            // DistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 428);
            this.Controls.Add(this.addDistrictButton);
            this.Controls.Add(this.addDistrictTextBox);
            this.Controls.Add(this.deleteDistrictButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDistrictsButton);
            this.Controls.Add(this.districtGrid);
            this.Name = "DistrictForm";
            this.Text = "DistrictForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DistrictForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.districtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView districtGrid;
        private System.Windows.Forms.Button showDistrictsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteDistrictButton;
        private System.Windows.Forms.TextBox addDistrictTextBox;
        private System.Windows.Forms.Button addDistrictButton;
    }
}