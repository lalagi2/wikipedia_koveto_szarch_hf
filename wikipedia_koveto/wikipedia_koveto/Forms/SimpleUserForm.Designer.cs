namespace wikipedia_koveto.Forms
{
    partial class SimpleUserForm
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
            this.components = new System.ComponentModel.Container();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SubsribeLabel = new System.Windows.Forms.Label();
            this.userDataDataSet = new wikipedia_koveto.Data.UserDataDataSet();
            this.userDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDataDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sensitivityNumericBox = new System.Windows.Forms.NumericUpDown();
            this.refreshRateNumericBox = new System.Windows.Forms.NumericUpDown();
            this.newWikipediaPageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.unsubscribeComboBox1 = new System.Windows.Forms.ComboBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.modifySensitivityNumericBox = new System.Windows.Forms.NumericUpDown();
            this.modifyRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WikipediaPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sensitivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifySensitivityNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyRefreshRate)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(27, 21);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(33, 26);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Hi";
            // 
            // SubsribeLabel
            // 
            this.SubsribeLabel.AutoSize = true;
            this.SubsribeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubsribeLabel.Location = new System.Drawing.Point(27, 357);
            this.SubsribeLabel.Name = "SubsribeLabel";
            this.SubsribeLabel.Size = new System.Drawing.Size(455, 26);
            this.SubsribeLabel.TabIndex = 1;
            this.SubsribeLabel.Text = "You are subscribed to these Wikipedia pages:";
            // 
            // userDataDataSet
            // 
            this.userDataDataSet.DataSetName = "UserDataDataSet";
            this.userDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataDataSetBindingSource
            // 
            this.userDataDataSetBindingSource.DataSource = this.userDataDataSet;
            this.userDataDataSetBindingSource.Position = 0;
            // 
            // userDataDataSetBindingSource1
            // 
            this.userDataDataSetBindingSource1.DataSource = this.userDataDataSet;
            this.userDataDataSetBindingSource1.Position = 0;
            // 
            // userDataDataSetBindingSource2
            // 
            this.userDataDataSetBindingSource2.DataSource = this.userDataDataSet;
            this.userDataDataSetBindingSource2.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WikipediaPage,
            this.Sensitivity,
            this.RefreshRate});
            this.dataGridView1.Location = new System.Drawing.Point(32, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subscribe to a new Wikipedia page";
            // 
            // sensitivityNumericBox
            // 
            this.sensitivityNumericBox.Location = new System.Drawing.Point(383, 181);
            this.sensitivityNumericBox.Name = "sensitivityNumericBox";
            this.sensitivityNumericBox.Size = new System.Drawing.Size(51, 20);
            this.sensitivityNumericBox.TabIndex = 4;
            this.sensitivityNumericBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // refreshRateNumericBox
            // 
            this.refreshRateNumericBox.Location = new System.Drawing.Point(470, 182);
            this.refreshRateNumericBox.Name = "refreshRateNumericBox";
            this.refreshRateNumericBox.Size = new System.Drawing.Size(67, 20);
            this.refreshRateNumericBox.TabIndex = 5;
            this.refreshRateNumericBox.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // newWikipediaPageTextBox
            // 
            this.newWikipediaPageTextBox.Location = new System.Drawing.Point(32, 181);
            this.newWikipediaPageTextBox.Name = "newWikipediaPageTextBox";
            this.newWikipediaPageTextBox.Size = new System.Drawing.Size(316, 20);
            this.newWikipediaPageTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wikipedia page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sensitivity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Refresh Rate";
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(573, 178);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(102, 23);
            this.subscribeButton.TabIndex = 10;
            this.subscribeButton.Text = "Subscribe!";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Modify";
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Location = new System.Drawing.Point(703, 283);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(106, 23);
            this.unsubscribeButton.TabIndex = 12;
            this.unsubscribeButton.Text = "Unsubscribe!";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.unsubscribeButton_Click);
            // 
            // unsubscribeComboBox1
            // 
            this.unsubscribeComboBox1.FormattingEnabled = true;
            this.unsubscribeComboBox1.Location = new System.Drawing.Point(32, 285);
            this.unsubscribeComboBox1.Name = "unsubscribeComboBox1";
            this.unsubscribeComboBox1.Size = new System.Drawing.Size(316, 21);
            this.unsubscribeComboBox1.TabIndex = 13;
            this.unsubscribeComboBox1.SelectedIndexChanged += new System.EventHandler(this.unsubscribeComboBox1_SelectedIndexChanged);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(573, 283);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(102, 23);
            this.modifyButton.TabIndex = 14;
            this.modifyButton.Text = "Modify!";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // modifySensitivityNumericBox
            // 
            this.modifySensitivityNumericBox.Location = new System.Drawing.Point(383, 286);
            this.modifySensitivityNumericBox.Name = "modifySensitivityNumericBox";
            this.modifySensitivityNumericBox.Size = new System.Drawing.Size(51, 20);
            this.modifySensitivityNumericBox.TabIndex = 15;
            // 
            // modifyRefreshRate
            // 
            this.modifyRefreshRate.Location = new System.Drawing.Point(470, 286);
            this.modifyRefreshRate.Name = "modifyRefreshRate";
            this.modifyRefreshRate.Size = new System.Drawing.Size(67, 20);
            this.modifyRefreshRate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Refresh Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sensitivity";
            // 
            // WikipediaPage
            // 
            this.WikipediaPage.HeaderText = "WikipediaPage";
            this.WikipediaPage.Name = "WikipediaPage";
            this.WikipediaPage.Width = 200;
            // 
            // Sensitivity
            // 
            this.Sensitivity.HeaderText = "Sensitivity";
            this.Sensitivity.Name = "Sensitivity";
            // 
            // RefreshRate
            // 
            this.RefreshRate.HeaderText = "Refresh Rate";
            this.RefreshRate.Name = "RefreshRate";
            // 
            // SimpleUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modifyRefreshRate);
            this.Controls.Add(this.modifySensitivityNumericBox);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.unsubscribeComboBox1);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newWikipediaPageTextBox);
            this.Controls.Add(this.refreshRateNumericBox);
            this.Controls.Add(this.sensitivityNumericBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SubsribeLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "SimpleUserForm";
            this.Text = "SimpleUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifySensitivityNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyRefreshRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label SubsribeLabel;
        private Data.UserDataDataSet userDataDataSet;
        private System.Windows.Forms.BindingSource userDataDataSetBindingSource;
        private System.Windows.Forms.BindingSource userDataDataSetBindingSource1;
        private System.Windows.Forms.BindingSource userDataDataSetBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sensitivityNumericBox;
        private System.Windows.Forms.NumericUpDown refreshRateNumericBox;
        private System.Windows.Forms.TextBox newWikipediaPageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.ComboBox unsubscribeComboBox1;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.NumericUpDown modifySensitivityNumericBox;
        private System.Windows.Forms.NumericUpDown modifyRefreshRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn WikipediaPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sensitivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefreshRate;
    }
}