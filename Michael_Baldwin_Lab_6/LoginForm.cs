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
    public partial class loginForm : Form
    {
        //internal List<User> UserList = new List<User>();
        internal User[] UserList = new User[5];

        public loginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Build our users.
            User User0 = new User("Mike", "1111111111", "MikePass");
            User User1 = new User("Tony", "2222222222", "TonyPass");
            User User2 = new User("Marissa", "3333333333", "MarissaPass");
            User User3 = new User("Mikki", "4444444444", "MikkiPass");
            User User4 = new User("Toller", "5555555555", "TollerPass");


            //Add Users to Array for easy access.
            //UserList.AddRange(new List<User> { User, User1, User2, User3, User4 });
            //Add users to array;
            UserList[0] = User0;
            UserList[1] = User1;
            UserList[2] = User2;
            UserList[3] = User3;
            UserList[4] = User4;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            bool loginSuccessful = false;
            string alteredPhone = phoneTextBox.Text;
            string[] badChars = { "(", ")", " ", "-" }; //Array of characters to remove from entered phone number.

            foreach (string badChar in badChars) // Remove Bad Characters from number by replacement.
            {
                alteredPhone = alteredPhone.Replace(badChar, String.Empty);
                //Console.WriteLine(badChar); // Debug text
            }
            // Console.WriteLine(alteredPhone); // Debug text

            foreach (User user in UserList)
            {
                if (user.Name.ToLower() == userTextBox.Text.ToLower() && user.Password == passTextBox.Text && user.Phone == alteredPhone) //Check for matches, letting username be any case.
                {
                    MessageBox.Show($"{user.Name} has successfully logged in. \nThank you for shopping!"); //Display message to user on successful login.
                    Form bookStore = new discountBookPlace(userTextBox.Text, phoneTextBox.Text);
                    bookStore.ShowDialog();

                }
            }
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            Form webBrowser = new browserForm();
            webBrowser.ShowDialog();
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            Form orderForm = new emailForm();
            orderForm.ShowDialog();
        }
    }
}