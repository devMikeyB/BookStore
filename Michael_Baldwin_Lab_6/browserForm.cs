using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michael_Baldwin_Lab_6
{
    public partial class browserForm : Form
    {
        public browserForm()
        {
            InitializeComponent();
        }

        private void browserForm_Load(object sender, EventArgs e)
        {
            this.urlComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.urlComboBox.AutoCompleteSource = AutoCompleteSource.AllUrl;
            webBrowser.Navigate(new System.Uri(@"file:///" + Application.StartupPath + "/mike.htm"));
        }

        private void navigateButton_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser.Navigate(new Uri(urlComboBox.Text));
            }
            catch
            {
                try
                {
                    webBrowser.Navigate(new Uri(@"http://www." + urlComboBox.Text));
                }
                catch
                {
                    MessageBox.Show("Invalid url.");
                }
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new System.Uri(@"file:///" + Application.StartupPath + "/mike.htm"));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
