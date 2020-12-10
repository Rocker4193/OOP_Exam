using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Book_Classes
{
    class Title
    {
        public Title(string name)
        {
            this.name = name;
        }
        public string name { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Title: {name}");
            Console.ResetColor();
        }
    }
}
