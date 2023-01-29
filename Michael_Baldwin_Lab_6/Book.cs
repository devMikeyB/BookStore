using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael_Baldwin_Lab_6
{
    internal class Book
    {
        public Book()
        {
            this.Name = "Unknown";
            this.PropBag = new Dictionary<string, string>();
        }

        public Book(string name, double price, string category, Image categoryImage, Image bookImage)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.CategoryImage = categoryImage;
            this.BookImage = bookImage;
            this.PropBag = new Dictionary<string, string>();
        }

        public string Name { get; }
        public double Price { get; }
        public string Category { get; }
        public Image CategoryImage { get; }
        public Image BookImage { get; }
        public Dictionary<string, string> PropBag { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
