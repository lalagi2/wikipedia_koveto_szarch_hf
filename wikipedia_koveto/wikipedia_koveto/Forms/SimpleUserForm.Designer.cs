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
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.SubsribeLabel.Location = new System.Drawing.Point(12, 358);
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
            // SimpleUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 574);
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
    }
}