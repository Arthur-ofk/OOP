using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Problem2
{
    public class Book
    {
        string author;
        string title;
        double price;
        public Book(string author, string title, double price)
        {
            this.Author = author;
            this.title = title;
            this.price = price;
        }
        public string Author
        {
            get { return author; }

            set
            {

            }

        }
    }
}
