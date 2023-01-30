using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michael_Baldwin_Lab_6
{
    public partial class discountBookPlace : Form
    {
        public discountBookPlace(string userName, string userPhone)
        {
            InitializeComponent();
            this.usernameTextBox.Text = userName;
            this.phoneMaskedTextBox.Text = userPhone;
        }
        internal List<Book> BookList = new List<Book>();

        private void totalPriceLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            timeTimer.Start();


            //Category Images
            Image programmingCategoryImage = null;
            Image englishCategoryImage = null;
            Image artCategoryImage = null;
            Image cSharpImage = null;
            Image pythonImage = null;
            Image sqlImage = null;
            Image selfRelianceImage = null;
            Image civilDisobedienceImage = null;
            Image bigWordsImage = null;
            Image drawingBookImage = null;
            Image paintingBookImage = null;
            Image caligraphyBookImage = null;

            //Toolstrip images
            Image toolStripExitImage = null;
            Image toolStripClearImage = null;

            try // Attempt to assign images to variables.
            {
                programmingCategoryImage = Image.FromFile("images/categories/programmingCategory.png");
                englishCategoryImage = Image.FromFile("images/categories/English.jpeg");
                artCategoryImage = Image.FromFile("images/categories/art.jpeg");
                cSharpImage = Image.FromFile("images/books/c#Book.jpeg");
                pythonImage = Image.FromFile("images/books/pythonBook.jpeg");
                sqlImage = Image.FromFile("images/books/sqlBook.jpeg");
                selfRelianceImage = Image.FromFile("images/books/selfRelianceBook.jpeg");
                civilDisobedienceImage = Image.FromFile("images/books/civilDisobedienceBook.jpeg");
                bigWordsImage = Image.FromFile("images/books/bigWordsBook.png");
                drawingBookImage = Image.FromFile("images/books/drawingBook.jpeg");
                paintingBookImage = Image.FromFile("images/books/paintingBook.jpeg");
                caligraphyBookImage = Image.FromFile("images/books/caligraphyBook.jpeg");
                toolStripExitImage = Image.FromFile("images/toolStrip/X.jpg");
                toolStripClearImage = Image.FromFile("images/toolStrip/clear.png");

            }
            catch (Exception ex){ MessageBox.Show(ex.ToString()); }

            Image[] toolStripImageList = { toolStripExitImage, toolStripClearImage };
            

            //Build our Book Library
            Book ProgrammingBook = new Book("C# Intro", 49.54, "Programming", programmingCategoryImage, cSharpImage);
            Book ProgrammingBook1 = new Book("Python Intro", 35.43, "Programming", programmingCategoryImage, pythonImage);
            Book ProgrammingBook2 = new Book("SQL Intro", 60.61, "Programming", programmingCategoryImage, sqlImage);
            Book LiteratureBook = new Book("Self-Reliance", 13.48, "English", englishCategoryImage, selfRelianceImage);
            Book LiteratureBook1 = new Book("Big Words and How To Use Them", 44.44, "English", englishCategoryImage, bigWordsImage);
            Book LiteratureBook2 = new Book("Civil Disobedience", 18.55, "English", englishCategoryImage, civilDisobedienceImage);
            Book ArtBook = new Book("Drawing", 10.11, "Art", artCategoryImage, drawingBookImage);
            Book ArtBook1 = new Book("Painting", 30.32, "Art", artCategoryImage, paintingBookImage);
            Book ArtBook2 = new Book("Calligraphy", 44.53, "Art", artCategoryImage, caligraphyBookImage);

            //We initialized a Dict within the Book class to house misc. properties we may need down the road.
            //Add keys for each video for the video player.
            ProgrammingBook.PropBag.Add("C# Intro", "https://www.youtube.com/embed/KJgsSFOSQv0");
            ProgrammingBook1.PropBag.Add("Python Intro", "https://www.youtube.com/embed/kqtD5dpn9C8");
            ProgrammingBook2.PropBag.Add("SQL Intro", "https://www.youtube.com/embed/h0nxCDiD-zg");
            LiteratureBook.PropBag.Add("Self-Reliance", "https://www.youtube.com/embed/6AZBW7CY5h8");
            LiteratureBook1.PropBag.Add("Big Words and How To Use Them", "https://www.youtube.com/embed/Ba68h3O_7vs");
            LiteratureBook2.PropBag.Add("Civil Disobedience", "https://www.youtube.com/embed/FCb5GubMZh0");
            ArtBook.PropBag.Add("Drawing", "https://www.youtube.com/embed/oQm8Df4UYNw");
            ArtBook1.PropBag.Add("Painting", "https://www.youtube.com/embed/6tOgL86F3RU");
            ArtBook2.PropBag.Add("Calligraphy", "https://www.youtube.com/embed/sBoVGqiSzr4");


            //Add all books to List for easy access.
            BookList.AddRange(new List<Book> { ProgrammingBook, ProgrammingBook1, ProgrammingBook2, LiteratureBook, LiteratureBook1, LiteratureBook2, ArtBook, ArtBook1, ArtBook2 });
            //Book[] BookList = new Book[9] { ProgrammingBook, ProgrammingBook1, ProgrammingBook2, LiteratureBook, LiteratureBook1, LiteratureBook2, ArtBook, ArtBook1, ArtBook2 };

            for(int i = 0; i < BookList.Count; i++)
            {
                if (!bookSelectionComboBox.Items.Contains(BookList[i].Category)){ //Search for Category property.
                    bookSelectionComboBox.Items.Add(BookList[i].Category); //Populate bookSelectionComboBox with Categories.
                    categoryToolStripMenuItem.DropDownItems.Add(BookList[i].Category);
                }
            }

            exitToolStripButton.Image = toolStripImageList[0];
            clearToolStripButton.Image = toolStripImageList[1];


        }

        private void resetForm()
        {///Return form to default

            bookSelectionComboBox.SelectedIndex = -1;
            usernameTextBox.Text = String.Empty;
            phoneMaskedTextBox.Text = String.Empty;
            bookStockListBox.Items.Clear();
            bookStockListBox.Text = String.Empty;
            categoryPictureBox.Image = null;
            bookCoverPictureBox.Image = null;
            receiptListView.Items.Clear();
            receiptListView.Visible = false;
            commentRichTextBox.Text = String.Empty;
            receiptTotalAmountLabel.Text = "$0.00";
            totalPriceLabel.Text = "$0.00";
            bookPriceAmountLabel.Text = "$0.00";
            shoppingCartComboBox.Items.Clear();
            receiptTotalAmountLabel.Visible = false;
            receiptTotalLabel.Visible = false;
            bookWebView2.Visible = false;
            bookWebView2.Source = new Uri("https://www.google.com");


        }


        internal Book searchBookListforValue(List<Book> bookList, string searchableValue = "Unknown")
        {//Function which returns a book which matches the searchable value entered. Can be altered to include books containing the value in any property..
            foreach(Book book in bookList)
            {
                if (book.Name == searchableValue)
                {
                    return book;
                }
            }

            return null;
        }

        public double updateCartValue(ComboBox comboBox)
        { // Updates the value of the shopping cart.
            double cartValue = 0;
            foreach (string item in comboBox.Items)
            {
                Book book = searchBookListforValue(BookList, item);
                cartValue += book.Price;
            }

            return cartValue;
        }

        private void bookSelectionComboBox_SelectedValueChanged(object sender, EventArgs e)
        { //Populate list with books of a selected category.

            bookStockListBox.Items.Clear(); //Clear items
            bookCoverPictureBox.Image = null; //Reset bookCoverPictureBox.
            bookPriceAmountLabel.Text = "$0.00"; //Reset Text

            for(int i=0; i < BookList.Count; i++)
            {
                if (bookSelectionComboBox.SelectedIndex == -1)
                {
                    categoryPictureBox.Image = null;
                }
                else if (BookList[i].Category == bookSelectionComboBox.SelectedItem.ToString())
                {
                    bookStockListBox.Items.Add(BookList[i].Name);
                    categoryPictureBox.Image = BookList[i].CategoryImage;
                }
            }
           /* if (bookSelectionComboBox.SelectedIndex != -1)
            {
                updatebookSelectionToolStripMenu1(bookSelectionComboBox.SelectedItem.ToString()); // Update toolStripMenu
            } */

        }

        private void bookStockListBox_SelectedValueChanged(object sender, EventArgs e)
        { //Display price of book and update image.
            for(int i=0; i < BookList.Count; i++)
            {
                if (BookList[i].Name == bookStockListBox.SelectedItem.ToString())
                {
                    bookPriceAmountLabel.Text = $"${BookList[i].Price.ToString()}";
                    bookCoverPictureBox.Image = BookList[i].BookImage; //Update bookCoverPictureBox
                }
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        { //Adds selected book to cart.
            if (bookStockListBox.SelectedItem == null) //Do nothing if null.
            {
                MessageBox.Show("You have no selected item to add to the cart.");
                //return;
            }
            else if (bookStockListBox.SelectedItem != null && !shoppingCartComboBox.Items.Contains(bookStockListBox.SelectedItem))
            {
                try
                {
                    shoppingCartComboBox.Items.Add(bookStockListBox.SelectedItem); // Add to cart
                    totalPriceLabel.Text = updateCartValue(shoppingCartComboBox).ToString(); // Update price label
                    receiptTotalAmountLabel.Text = totalPriceLabel.Text;
                
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Please select an item to add to the cart.");
                }
            } else
            {
                MessageBox.Show("You've already added that book to your cart. \nLimit 1 per customer, please select another.");
            }


        }

        private void clearCartButton_Click(object sender, EventArgs e)
        { //Clear shopping cart.
            shoppingCartComboBox.Items.Clear(); // Clear Cart
            shoppingCartComboBox.Text = "Thanks For Shopping!"; // Restore text
            totalPriceLabel.Text = $"${updateCartValue(shoppingCartComboBox).ToString()}";//; // Update cart value

        }

        private void removeFromCartButton_Click(object sender, EventArgs e)
        { //Remove selected item from cart.
            shoppingCartComboBox.Items.Remove(shoppingCartComboBox.SelectedItem);
            if( shoppingCartComboBox.Items.Count < 1) // If count is back to 0
            {
                shoppingCartComboBox.Text = "Thanks For Shopping!"; // Restore Text
                totalPriceLabel.Text = "$0.00";
            }
            if(updateCartValue(shoppingCartComboBox) > 0)
            {
                totalPriceLabel.Text = $"${updateCartValue(shoppingCartComboBox).ToString()}"; // Update cart value
            }


        }

        private void finalizeSalesButton_Click(object sender, EventArgs e)
        { //Create receipt if sale is finalized.
            
            if(shoppingCartComboBox.Items.Count > 0 && (MessageBox.Show(
                "All sales will be final", "Yes or No", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                receiptListView.Items.Clear();
                receiptListView.Visible = true;
                receiptTotalAmountLabel.Visible = true;
                receiptTotalLabel.Visible = true;
                foreach (string item in shoppingCartComboBox.Items)
                {
                    dynamic[] row = { item, searchBookListforValue(BookList, item).Price };
                    receiptListView.Items.Add(item).SubItems.Add(row[1].ToString());
                }
            }
            else
            {
                MessageBox.Show("There are no items in the shopping cart. \nPlease add items before finalizing.");
            }

        }



        private void clearAllButton_Click(object sender, EventArgs e)
        { //Resets form.
            resetForm();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { // Only accept reasonable input, throw warning if invalid input is used.
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 ) //8 is backspace.
            {
                mainErrorProvider.Clear();                                      //Opted for char.IsLetter() instead of a keychar change.
            }                                                                   //This allows for easier readability. Case is forced to UPPERCASE on form load so no need to validate against lowercase key press.

            else
            {
                mainErrorProvider.SetError(usernameTextBox, "Please enter a valid input.");
                e.Handled = true;
            }
        }

        private void phoneMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { // Only accepts reasonable input, throw warning if invalid input is used.
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) //8 is backspace.
            {
                mainErrorProvider.Clear(); //Opted for char.IsDigit() instead of a keychar change.
            }else
            {
                mainErrorProvider.SetError(phoneMaskedTextBox, "Please only enter numbers.");
                e.Handled = true;
            }

        }

        private void nameCommentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8) //8 is backspace.
            {
                mainErrorProvider.Clear();                                      //Opted for char.IsLetter() instead of a keychar change.
            }                                                                   

            else
            {
                mainErrorProvider.SetError(nameCommentTextBox, "Please enter a valid input.");
                e.Handled = true;
            }
        }

        private void titleCommentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '#') //8 is backspace.
            {
                mainErrorProvider.Clear();                                      //Opted for char.IsLetter() instead of a keychar change.
            }                                                                   

            else
            {
                mainErrorProvider.SetError(titleCommentTextBox, "Please enter a valid input.");
                e.Handled = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        { //Saves comment to text file.
            string commentName = $"Name: {nameCommentTextBox.Text}\n";
            string bookName = $"Book: {titleCommentTextBox.Text}\n";
            string commentContent = $"Comment: {commentRichTextBox.Text}";
            if (nameCommentTextBox.Text == string.Empty || titleCommentTextBox.Text == string.Empty || commentRichTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must fill out all fields to leave a comment.");
                return;
            }
            commentRichTextBox.Text = $"{commentName}{bookName}{commentContent}";
            //commentRichTextBox.SaveFile("comment-file.txt", RichTextBoxStreamType.PlainText);

            string currentContent = File.ReadAllText("comment-file.txt");
            File.WriteAllText("comment-file.txt", commentRichTextBox.Text +"\n\n"+ currentContent);
            commentRichTextBox.Clear();
            MessageBox.Show("Comment saved, thank you for your feedback!");
        }

        private void clearCommentButton_Click(object sender, EventArgs e)
        { //Clears comment field.
            nameCommentTextBox.Text = string.Empty;
            titleCommentTextBox.Text = string.Empty;
            commentRichTextBox.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        { //Exit application
            this.Close();
        }


        private void viewVideoButton_Click(object sender, EventArgs e)
        { //Changes Source field of WebView2 Controller to full-size video for each book.

            if (bookStockListBox.SelectedItem != null)
            {
                string selectedBook = bookStockListBox.SelectedItem.ToString();
                for (int i = 0; i < BookList.Count; i++)
                {
                    if (BookList[i].Name == selectedBook)
                    {
                        try
                        {
                            bookWebView2.Source = new System.Uri(BookList[i].PropBag[selectedBook]);
                            bookWebView2.Visible = true;
                        }
                        catch { MessageBox.Show("Unable to load video."); }
                    }
                }

            }
            else { MessageBox.Show("You must select a book in order to view a video about it."); }
            
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        { //Update time each second.
            timeToolStripStatusLabel.Text = $"Time: {DateTime.Now}";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bookSelectionGroupBox.Visible = true;
            selectedBookGroupBox.Visible = true;
            shoppingCartGroupBox.Visible = true;
            receiptGroupBox.Visible = true;
            commentGroupBox.Visible = true;
            videoGroupBox.Visible = true;
            mainToolStrip.Visible = true; //Here
            statusStrip1.Visible = true;
            menuStrip1.Visible = true;


        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginButton_Click(sender, e);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = String.Empty;
            phoneMaskedTextBox.Text = String.Empty;
        }

        private void addToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToCartButton_Click(sender, e);
        }

        private void removeFromCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFromCartButton_Click(sender, e);
        }

        private void clearCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearCartButton_Click(sender, e);
        }

        private void finalizeSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finalizeSalesButton_Click(sender, e);
        }

        private void clearAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAllButton_Click(sender, e);
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void submitCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            submitButton_Click(sender, e);
        }

        private void clearCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearCommentButton_Click(sender, e);
        }

        private void viewVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewVideoButton_Click(sender, e);
        }

        private void updatebookSelectionToolStripMenu1(string inputText)
        {
            bookSelectionToolStripMenuItem1.DropDownItems.Clear();

            foreach (Book book in BookList)
            {
                if (book.Category == inputText)
                {
                    bookSelectionToolStripMenuItem1.DropDownItems.Add(book.Name);
                }
            }
        }

        private void categoryToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (bookSelectionComboBox.Items.Contains(e.ClickedItem.Text))
            {
                bookSelectionComboBox.SelectedItem = e.ClickedItem.Text;
            }

            updatebookSelectionToolStripMenu1(e.ClickedItem.Text);


        }

        private void bookSelectionToolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (bookStockListBox.Items.Contains(e.ClickedItem.Text))
            {
                bookStockListBox.SelectedItem = e.ClickedItem.Text;
            }
        }

        private void shoppingCartToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            shoppingCartItemsToolStripMenuItem.DropDownItems.Clear();
            foreach (string shoppingCartItem in shoppingCartComboBox.Items)
            {
                shoppingCartItemsToolStripMenuItem.DropDownItems.Add(shoppingCartItem);
            }
        }

        private void shoppingCartItemsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (shoppingCartComboBox.Items.Contains(e.ClickedItem.Text))
            {
                shoppingCartComboBox.SelectedItem = e.ClickedItem.Text;
            }
        }

        private void bookSelectionToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (bookSelectionComboBox.SelectedIndex != -1)
            {
                updatebookSelectionToolStripMenu1(bookSelectionComboBox.SelectedItem.ToString());
            }
            else
            {
                bookSelectionToolStripMenuItem1.DropDownItems.Clear();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to close this page?", 
                "Close Form Validation", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button1 ) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripButton_Click(object sender, EventArgs e)
        {
            clearAllButton_Click(sender, e);
        }

        public bool processIsRunning(System.Diagnostics.Process process)
        {
            process.Refresh();
            try { Process.GetProcessById(process.Id); }
            catch (InvalidOperationException) { return false; }
            catch (ArgumentException) { return false; }
            return true;

        }

        private void takeNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (processIsRunning(notepadProcess)) {
                MessageBox.Show("Notepad process is already running.");
                return;
            }
            else { 
                notepadProcess.Start();
            }
        }

        private void quitNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processIsRunning(notepadProcess))
            {
                notepadProcess.Kill();
            }
            else
            {
                MessageBox.Show("Notepad is not running.");
            }
        }

        private void searchWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processIsRunning(chromeProcess))
            {
                MessageBox.Show("Chrome is already running.");
                return;

            }else
            {
                chromeProcess.Start();
            }
        }

        private void quitChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processIsRunning(chromeProcess))
            {
                chromeProcess.Kill();
            }
            else
            {
                MessageBox.Show("Notepad is not running.");
            }
        }

        private void categoryPictureBox_MouseHover(object sender, EventArgs e)
        {
            if (bookSelectionComboBox.SelectedItem != null && bookSelectionComboBox.SelectedIndex != -1) {

            mainToolTip.SetToolTip(this.categoryPictureBox, $"{bookSelectionComboBox.SelectedItem.ToString()} Category");
            }
            else mainToolTip.SetToolTip(this.bookCoverPictureBox, String.Empty);
        }

        private void bookCoverPictureBox_MouseHover(object sender, EventArgs e)
        {
            if (bookStockListBox.SelectedItem != null && bookStockListBox.SelectedIndex != -1)
            {
                mainToolTip.SetToolTip(this.bookCoverPictureBox, $"{bookStockListBox.SelectedItem.ToString()} Book Image");
            }
            else mainToolTip.SetToolTip(this.bookCoverPictureBox, String.Empty);
        }
    }
}
