using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string title = null;
        private string author = null;
        private string publisher = null;
        private string year = null;
        private string isbn = null;

        public string Title { get => title; set => title = value; }

        public string Author { get => author; set => author = value; }

        public string Publisher { get => publisher; set => publisher = value; }

        public string Year { get => year; set => year = value; }

        public string Isbn { get => isbn; set => isbn = value; }

        public Book(string title, string author, string publisher, string year, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Year = year;
            this.Isbn = isbn;
        }
              
                

    }
}
