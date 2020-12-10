using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Book_Classes
{
    class Author
    {
        public Author(string name)
        {
            this.name = name;
        }
        public string name { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Author: {name}");
            Console.ResetColor();
        }
    }
}
