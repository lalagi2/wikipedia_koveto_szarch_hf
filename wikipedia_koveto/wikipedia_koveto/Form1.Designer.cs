namespace wikipedia_koveto
{
    partial class Form1
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
            this.sourceButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.revisionButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.revisionText = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.revLabel = new System.Windows.Forms.Label();
            this.parentLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.revText = new System.Windows.Forms.TextBox();
            this.timeText = new System.Windows.Forms.TextBox();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.parentText = new System.Windows.Forms.TextBox();
            this.revisionList = new System.Windows.Forms.ListBox();
            this.revisionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(646, 11);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(96, 23);
            this.sourceButton.TabIndex = 0;
            this.sourceButton.Text = "Get Source";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(399, 13);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(241, 20);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "User:Szarch_hf";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(399, 65);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(343, 347);
            this.resultText.TabIndex = 2;
            this.resultText.Text = "";
            // 
            // revisionButton
            // 
            this.revisionButton.Location = new System.Drawing.Point(259, 11);
            this.revisionButton.Name = "revisionButton";
            this.revisionButton.Size = new System.Drawing.Size(96, 23);
            this.revisionButton.TabIndex = 3;
            this.revisionButton.Text = "Get Revisions";
            this.revisionButton.UseVisualStyleBackColor = true;
            this.revisionButton.Click += new System.EventHandler(this.revisionButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // revisionText
            // 
            this.revisionText.Location = new System.Drawing.Point(12, 13);
            this.revisionText.Name = "revisionText";
            this.revisionText.Size = new System.Drawing.Size(241, 20);
            this.revisionText.TabIndex = 5;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(396, 49);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(47, 13);
            this.contentLabel.TabIndex = 6;
            this.contentLabel.Text = "Content:";
            // 
            // revLabel
            // 
            this.revLabel.AutoSize = true;
            this.revLabel.Location = new System.Drawing.Point(12, 322);
            this.revLabel.Name = "revLabel";
            this.revLabel.Size = new System.Drawing.Size(34, 13);
            this.revLabel.TabIndex = 7;
            this.revLabel.Text = "revId:";
            // 
            // parentLabel
            // 
            this.parentLabel.AutoSize = true;
            this.parentLabel.Location = new System.Drawing.Point(12, 347);
            this.parentLabel.Name = "parentLabel";
            this.parentLabel.Size = new System.Drawing.Size(49, 13);
            this.parentLabel.TabIndex = 8;
            this.parentLabel.Text = "parentId:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 371);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(28, 13);
            this.sizeLabel.TabIndex = 9;
            this.sizeLabel.Text = "size:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 395);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(57, 13);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "timestamp:";
            // 
            // revText
            // 
            this.revText.Location = new System.Drawing.Point(90, 319);
            this.revText.Name = "revText";
            this.revText.Size = new System.Drawing.Size(265, 20);
            this.revText.TabIndex = 11;
            // 
            // timeText
            // 
            this.timeText.Location = new System.Drawing.Point(90, 392);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(265, 20);
            this.timeText.TabIndex = 12;
            // 
            // sizeText
            // 
            this.sizeText.Location = new System.Drawing.Point(90, 368);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(265, 20);
            this.sizeText.TabIndex = 13;
            // 
            // parentText
            // 
            this.parentText.Location = new System.Drawing.Point(90, 344);
            this.parentText.Name = "parentText";
            this.parentText.Size = new System.Drawing.Size(265, 20);
            this.parentText.TabIndex = 14;
            // 
            // revisionList
            // 
            this.revisionList.FormattingEnabled = true;
            this.revisionList.Location = new System.Drawing.Point(12, 65);
            this.revisionList.Name = "revisionList";
            this.revisionList.Size = new System.Drawing.Size(343, 238);
            this.revisionList.TabIndex = 15;
            this.revisionList.SelectedIndexChanged += new System.EventHandler(this.revisionList_SelectedIndexChanged);
            // 
            // revisionLabel
            // 
            this.revisionLabel.AutoSize = true;
            this.revisionLabel.Location = new System.Drawing.Point(9, 49);
            this.revisionLabel.Name = "revisionLabel";
            this.revisionLabel.Size = new System.Drawing.Size(53, 13);
            this.revisionLabel.TabIndex = 16;
            this.revisionLabel.Text = "Revisions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 433);
            this.Controls.Add(this.revisionLabel);
            this.Controls.Add(this.revisionList);
            this.Controls.Add(this.parentText);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.revText);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.revLabel);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.revisionText);
            this.Controls.Add(this.revisionButton);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.sourceButton);
            this.Name = "Form1";
            this.Text = "Wikipedia_koveto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Button revisionButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox revisionText;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Label revLabel;
        private System.Windows.Forms.Label parentLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox revText;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.TextBox parentText;
        private System.Windows.Forms.ListBox revisionList;
        private System.Windows.Forms.Label revisionLabel;
    }
}

