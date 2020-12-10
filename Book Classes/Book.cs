using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Book_Classes
{
    class Book
    {
        Title title;
        Author author;
        Content content;
        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
