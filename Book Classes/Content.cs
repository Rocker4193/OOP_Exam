using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Book_Classes
{
    class Content
    {
        public Content(string text)
        {
            this.text = text;
        }
        public string text { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Content: {text}");
            Console.ResetColor();
        }
    }
}
