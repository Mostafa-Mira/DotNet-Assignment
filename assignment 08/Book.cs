using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class Book
    {
        public string Title;
        public string Author;

        public Book()
        {
        }

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
