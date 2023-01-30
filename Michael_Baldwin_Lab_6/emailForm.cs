using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace Michael_Baldwin_Lab_6
{
    public partial class emailForm : Form
    {
        private string pass = "xlrwtggbznpxqmoa";
        private string user = "michaelemailproject@gmail.com";

        public emailForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MimeMessage myMessage = new MimeMessage();
            try
            {

                myMessage.From.Add(MailboxAddress.Parse(user));
                myMessage.To.Add(MailboxAddress.Parse(recipTextBox.Text));
                myMessage.Subject = subjectTextBox.Text;
                myMessage.Body = new TextPart("html") { Text = bodyRTB.Text };
            }
            catch { MessageBox.Show("Unable to format email. Please Try again.")}

            try
            {
                using (SmtpClient client = new SmtpClient()) //Use gmail
                {
                    client.Connect("smtp.gmail.com", 587); //Set port
                    client.Authenticate(user, pass);
                    client.Send(myMessage);
                    client.Disconnect(false);
                }
                MessageBox.Show("Email sent.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Message not sent: \n" + ex);
            }
        }
    }
}
