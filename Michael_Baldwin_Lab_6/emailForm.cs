using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using System.Xml;
using System.Xml.Linq;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

namespace Michael_Baldwin_Lab_6
{
    public partial class emailForm : Form
    {
        internal XElement credentials; //Initialize variables for use.
        internal XElement pass;
        internal XElement user;

        public emailForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MimeMessage myMessage = new MimeMessage(); //Init message.
            try
            {

                myMessage.From.Add(MailboxAddress.Parse(user.Value)); //Format FROM 
                myMessage.To.Add(MailboxAddress.Parse(recipTextBox.Text)); // TO
                myMessage.Subject = subjectTextBox.Text; //Subject
                myMessage.Body = new TextPart("html") { Text = bodyRTB.Text }; //Body

                MimePart attatchment = new MimePart() //Multipart for attachment
                {
                    Content = new MimeContent(File.OpenRead(attachTextBox.Text), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(attachTextBox.Text)
                };

                Multipart multipart = new Multipart("mixed");
                multipart.Add(myMessage.Body);
                multipart.Add(attatchment);

                myMessage.Body = multipart; //Include attachment in body

            }
            catch { MessageBox.Show("Unable to format email. Please Try again."); }

            try
            {
                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient()) //Use gmail
                {
                    client.Connect("smtp.gmail.com", 587); //Set port
                    client.Authenticate(user.Value, pass.Value); //Auth
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

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            //chooseFile.ShowDialog();
            if(chooseFile.ShowDialog() == DialogResult.OK)
            { //Select file
                attachTextBox.Text = chooseFile.FileName;
            }
        }

        private void emailForm_Load(object sender, EventArgs e)
        {//Load credentials from credentials file located in bin/Debug.
            credentials = XElement.Load("Credentials.xml");
            pass = credentials.Element("pass");
            user = credentials.Element("user");
            Console.WriteLine(pass.Value+ " "+ user);
        }
    }
}
