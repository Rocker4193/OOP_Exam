using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        const double MinSalary = 10000;
        const double Tax = 19.5;
        const double IncreaceForExp = 10;
        const double IncreaceForPost = 35;

        public Employee(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public void GetInfo()
        {
            double salary = 0;
            Console.Write(
                "Введите номер должности:\n" +
                "1.Официнт\n" +
                "2.Старший официант\n" +
                "3.Администратор\n" +
                "4.Менеджер\n" +
                "5.Зам. Директор\n" +
                "6.Директор\n" +
                "-->");
            string[] PostName = { "Официант", "Старший официант", "Администратор", "Менеджер", "Зам. Директор", "Директор" };
            int post = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите стаж работы: ");
            int experience = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < post; i++)
            {
                if (post > 6)
                    break;
                salary = (MinSalary * i * IncreaceForPost / 100) + MinSalary;
            }

            int temp = 0;

            for (int i = 0; i <= experience; i += 3)
            {
                salary += temp * IncreaceForExp * salary / 100;
                temp++;
            }

            Console.WriteLine(
                $"\nФамилия: {LastName}\n" +
                $"Имя: {Name}\n" +
                $"Должность: {PostName[post - 1]}\n" +
                $"Оклад: {salary}\n" +
                $"Налоговый сбор: {salary * Tax / 100}");
        }
    }
}
