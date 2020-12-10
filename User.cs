using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    class User
    {
        public User(string login, string name, string lastName, int age, string date)
        {
            Login = login;
            Name = name;
            LastName = lastName;
            Age = age;
            Date = date;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Date { get; private set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Date of filling: {Date}");
        }
    }
}
