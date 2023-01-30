namespace Michael_Baldwin_Lab_6
{
    partial class browserForm
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
            this.urlComboBox = new System.Windows.Forms.ComboBox();
            this.navigateButton = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.refreshButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlComboBox
            // 
            this.urlComboBox.FormattingEnabled = true;
            this.urlComboBox.Location = new System.Drawing.Point(12, 12);
            this.urlComboBox.Name = "urlComboBox";
            this.urlComboBox.Size = new System.Drawing.Size(756, 21);
            this.urlComboBox.TabIndex = 0;
            // 
            // navigateButton
            // 
            this.navigateButton.Location = new System.Drawing.Point(791, 10);
            this.navigateButton.Name = "navigateButton";
            this.navigateButton.Size = new System.Drawing.Size(148, 23);
            this.navigateButton.TabIndex = 1;
            this.navigateButton.Text = "Navigate";
            this.navigateButton.UseVisualStyleBackColor = true;
            this.navigateButton.Click += new System.EventHandler(this.navigateButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 56);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(927, 477);
            this.webBrowser.TabIndex = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(226, 539);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(307, 539);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(388, 539);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 23);
            this.forwardButton.TabIndex = 5;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(469, 539);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(550, 539);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 7;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(631, 539);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // browserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 583);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.navigateButton);
            this.Controls.Add(this.urlComboBox);
            this.Name = "browserForm";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.browserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox urlComboBox;
        private System.Windows.Forms.Button navigateButton;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button closeButton;
    }
}