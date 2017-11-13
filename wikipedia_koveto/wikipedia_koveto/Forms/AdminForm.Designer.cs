namespace wikipedia_koveto.Forms
{
    partial class AdminForm
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
            this.userLabel = new System.Windows.Forms.Label();
            this.adminTitle = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.subsLabel = new System.Windows.Forms.Label();
            this.refreshLabel = new System.Windows.Forms.Label();
            this.modifyRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.modifySubscriptionNumericBox = new System.Windows.Forms.NumericUpDown();
            this.modifyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modifyRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifySubscriptionNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(12, 69);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(69, 26);
            this.userLabel.TabIndex = 12;
            this.userLabel.Text = "Users";
            // 
            // adminTitle
            // 
            this.adminTitle.AutoSize = true;
            this.adminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTitle.Location = new System.Drawing.Point(12, 9);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(160, 26);
            this.adminTitle.TabIndex = 13;
            this.adminTitle.Text = "Admin Settings";
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(17, 110);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(243, 21);
            this.usersComboBox.TabIndex = 14;
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
            // 
            // subsLabel
            // 
            this.subsLabel.AutoSize = true;
            this.subsLabel.Location = new System.Drawing.Point(16, 150);
            this.subsLabel.Name = "subsLabel";
            this.subsLabel.Size = new System.Drawing.Size(165, 13);
            this.subsLabel.TabIndex = 23;
            this.subsLabel.Text = "Maximum number of subscriptions";
            // 
            // refreshLabel
            // 
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Location = new System.Drawing.Point(16, 176);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(129, 13);
            this.refreshLabel.TabIndex = 22;
            this.refreshLabel.Text = "Number of refresh per day";
            // 
            // modifyRefreshRate
            // 
            this.modifyRefreshRate.Location = new System.Drawing.Point(193, 174);
            this.modifyRefreshRate.Name = "modifyRefreshRate";
            this.modifyRefreshRate.Size = new System.Drawing.Size(67, 20);
            this.modifyRefreshRate.TabIndex = 21;
            // 
            // modifySubscriptionNumericBox
            // 
            this.modifySubscriptionNumericBox.Location = new System.Drawing.Point(193, 148);
            this.modifySubscriptionNumericBox.Name = "modifySubscriptionNumericBox";
            this.modifySubscriptionNumericBox.Size = new System.Drawing.Size(67, 20);
            this.modifySubscriptionNumericBox.TabIndex = 20;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(17, 218);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(102, 23);
            this.modifyButton.TabIndex = 19;
            this.modifyButton.Text = "Modify!";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 260);
            this.Controls.Add(this.subsLabel);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.modifyRefreshRate);
            this.Controls.Add(this.modifySubscriptionNumericBox);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.adminTitle);
            this.Controls.Add(this.userLabel);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.modifyRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifySubscriptionNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label adminTitle;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Label subsLabel;
        private System.Windows.Forms.Label refreshLabel;
        private System.Windows.Forms.NumericUpDown modifyRefreshRate;
        private System.Windows.Forms.NumericUpDown modifySubscriptionNumericBox;
        private System.Windows.Forms.Button modifyButton;
    }
}