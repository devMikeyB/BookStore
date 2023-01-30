namespace Michael_Baldwin_Lab_6
{
    partial class LoginForm
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
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.websiteButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.videoButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(153, 117);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 20);
            this.userTextBox.TabIndex = 0;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(153, 161);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(100, 20);
            this.passTextBox.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(101, 120);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(101, 164);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(101, 206);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Phone";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(397, 110);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(98, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // websiteButton
            // 
            this.websiteButton.Location = new System.Drawing.Point(397, 154);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.Size = new System.Drawing.Size(98, 23);
            this.websiteButton.TabIndex = 7;
            this.websiteButton.Text = "Visit Website";
            this.websiteButton.UseVisualStyleBackColor = true;
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(397, 196);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(98, 23);
            this.emailButton.TabIndex = 8;
            this.emailButton.Text = "Email Order";
            this.emailButton.UseVisualStyleBackColor = true;
            // 
            // videoButton
            // 
            this.videoButton.Location = new System.Drawing.Point(397, 238);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(98, 23);
            this.videoButton.TabIndex = 9;
            this.videoButton.Text = "Video";
            this.videoButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 279);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(153, 203);
            this.phoneTextBox.Mask = "(999) 000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 539);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.videoButton);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.websiteButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button websiteButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
    }
}