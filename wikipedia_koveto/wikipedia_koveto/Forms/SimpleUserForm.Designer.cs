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
            this.WikipediaPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sensitivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.sensitivityNumericBox = new System.Windows.Forms.NumericUpDown();
            this.refreshRateNumericBox = new System.Windows.Forms.NumericUpDown();
            this.newWikipediaPageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subscribeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNumericBox)).BeginInit();
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
            this.NotificationNumber,
            this.RefreshRate});
            this.dataGridView1.Location = new System.Drawing.Point(32, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // NotificationNumber
            // 
            this.NotificationNumber.HeaderText = "Notification Number Today";
            this.NotificationNumber.Name = "NotificationNumber";
            this.NotificationNumber.Width = 157;
            // 
            // RefreshRate
            // 
            this.RefreshRate.HeaderText = "Refresh Rate";
            this.RefreshRate.Name = "RefreshRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subsrcibe to a new Wikipedia page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sensitivityNumericBox
            // 
            this.sensitivityNumericBox.Location = new System.Drawing.Point(384, 181);
            this.sensitivityNumericBox.Name = "sensitivityNumericBox";
            this.sensitivityNumericBox.Size = new System.Drawing.Size(120, 20);
            this.sensitivityNumericBox.TabIndex = 4;
            // 
            // refreshRateNumericBox
            // 
            this.refreshRateNumericBox.Location = new System.Drawing.Point(529, 181);
            this.refreshRateNumericBox.Name = "refreshRateNumericBox";
            this.refreshRateNumericBox.Size = new System.Drawing.Size(120, 20);
            this.refreshRateNumericBox.TabIndex = 5;
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
            this.label3.Location = new System.Drawing.Point(381, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sensitivity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Refresh Rate";
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(666, 177);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(102, 23);
            this.subscribeButton.TabIndex = 10;
            this.subscribeButton.Text = "Subscribe!";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // SimpleUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 574);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn WikipediaPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sensitivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefreshRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sensitivityNumericBox;
        private System.Windows.Forms.NumericUpDown refreshRateNumericBox;
        private System.Windows.Forms.TextBox newWikipediaPageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button subscribeButton;
    }
}