namespace Michael_Baldwin_Lab_6
{
    partial class emailForm
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
            this.recipLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.recipTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.bodyRTB = new System.Windows.Forms.RichTextBox();
            this.attachmentGroupBox = new System.Windows.Forms.GroupBox();
            this.attachLabel = new System.Windows.Forms.Label();
            this.attachTextBox = new System.Windows.Forms.TextBox();
            this.attachButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.attachmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipLabel
            // 
            this.recipLabel.AutoSize = true;
            this.recipLabel.Location = new System.Drawing.Point(114, 93);
            this.recipLabel.Name = "recipLabel";
            this.recipLabel.Size = new System.Drawing.Size(23, 13);
            this.recipLabel.TabIndex = 0;
            this.recipLabel.Text = "To:";
            this.recipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(114, 130);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Subject:";
            this.subjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recipTextBox
            // 
            this.recipTextBox.Location = new System.Drawing.Point(173, 90);
            this.recipTextBox.Name = "recipTextBox";
            this.recipTextBox.Size = new System.Drawing.Size(475, 20);
            this.recipTextBox.TabIndex = 2;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(173, 127);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(475, 20);
            this.subjectTextBox.TabIndex = 3;
            // 
            // bodyRTB
            // 
            this.bodyRTB.Location = new System.Drawing.Point(173, 165);
            this.bodyRTB.Name = "bodyRTB";
            this.bodyRTB.Size = new System.Drawing.Size(475, 164);
            this.bodyRTB.TabIndex = 4;
            this.bodyRTB.Text = "";
            // 
            // attachmentGroupBox
            // 
            this.attachmentGroupBox.Controls.Add(this.attachButton);
            this.attachmentGroupBox.Controls.Add(this.attachTextBox);
            this.attachmentGroupBox.Controls.Add(this.attachLabel);
            this.attachmentGroupBox.Location = new System.Drawing.Point(117, 338);
            this.attachmentGroupBox.Name = "attachmentGroupBox";
            this.attachmentGroupBox.Size = new System.Drawing.Size(582, 73);
            this.attachmentGroupBox.TabIndex = 5;
            this.attachmentGroupBox.TabStop = false;
            this.attachmentGroupBox.Text = "Attachment Required";
            // 
            // attachLabel
            // 
            this.attachLabel.AutoSize = true;
            this.attachLabel.Location = new System.Drawing.Point(8, 28);
            this.attachLabel.Name = "attachLabel";
            this.attachLabel.Size = new System.Drawing.Size(67, 13);
            this.attachLabel.TabIndex = 0;
            this.attachLabel.Text = "Attachment: ";
            // 
            // attachTextBox
            // 
            this.attachTextBox.Location = new System.Drawing.Point(81, 25);
            this.attachTextBox.Name = "attachTextBox";
            this.attachTextBox.ReadOnly = true;
            this.attachTextBox.Size = new System.Drawing.Size(425, 20);
            this.attachTextBox.TabIndex = 1;
            // 
            // attachButton
            // 
            this.attachButton.Location = new System.Drawing.Point(232, 50);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(101, 23);
            this.attachButton.TabIndex = 2;
            this.attachButton.Text = "Add Attachment";
            this.attachButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(349, 417);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(101, 23);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // emailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.attachmentGroupBox);
            this.Controls.Add(this.bodyRTB);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.recipTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.recipLabel);
            this.Name = "emailForm";
            this.Text = "emailForm";
            this.attachmentGroupBox.ResumeLayout(false);
            this.attachmentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox recipTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.RichTextBox bodyRTB;
        private System.Windows.Forms.GroupBox attachmentGroupBox;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.TextBox attachTextBox;
        private System.Windows.Forms.Label attachLabel;
        private System.Windows.Forms.Button sendButton;
    }
}