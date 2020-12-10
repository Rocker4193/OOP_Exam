using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OOP_Exam.Book_Classes;
using OOP_Exam.Figure_n_Points;

namespace OOP_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress(25002, "Ukraine", "Kropyvnytskyi", "Peremogi", 14, 120);
            adress.ShowInfo();

            Console.WriteLine(new string('-', 50));

            Rectangle rectangle = new Rectangle(44, 66);
            Console.WriteLine($"Area: {rectangle.Area}");
            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");

            Console.WriteLine(new string('-', 50));

            Book MyBook = new Book
                (new Title("White Fang"),
                new Author("Jack London"),
                new Content("White Fang examines the violent world of wild animals and the equally violent world of humans. " +
                "The book also explores complex themes including morality and redemption."));
            MyBook.Show();

            Console.WriteLine(new string('-', 50));

            Figure MyFigure = new Figure
                (new Point(-2, 1, "A"), new Point(3, 2, "B"), new Point(7, 4, "C"));
            MyFigure.PerimeterCalculator();

            Console.WriteLine(new string('-', 50));

            User user = new User("5421", "Oleg", "Karanskiy", 18, "15.09.2020");
            user.ShowInfo();

            Console.WriteLine(new string('-', 50));

            Converter converter = new Converter(15, 30, 500, 5);
            converter.ValueConverter();

            Console.WriteLine(new string('-', 50));

            Employee employee = new Employee("Oleg", "Karansky");
            employee.GetInfo();

            Console.WriteLine(new string('-', 50));

            Invoice invoice = new Invoice(1513, "Oleg", "IBM");
            invoice.Price();
        }
    }
}