using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    class Invoice
    {
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public int Account { get; private set; }
        public string Customer { get; private set; }
        public string Provider { get; private set; }

        string[] goods = { "Процессор", "Материнская плата", "Видеокарта", "Блок питания", "Корпус", "Роутер", "Мышь", "Клавиатура", "Монитор", "Колонки" };

        const double tax = 20;

        public void Price()
        {
            double[] price = { 7000, 3000, 5000, 2700, 1500, 700, 1199.99, 1799.99, 3000, 2099.99 };

            Console.WriteLine($"Выберите номер товара, который хотите заказать:");
            for (int i = 0; i < goods.Length; i++)
                Console.WriteLine($"{i + 1}. {goods[i]} по цене: {price[i]} UAH");

            Console.Write("--> ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(

                $"\nАккаунт: {Account}\n" +
                $"Покупатель: {Customer}\n" +
                $"Поставщик: {Provider}\n" +
                $"Товар: {goods[n - 1]}\n" +
                $"Цена: {price[n - 1]}\n" +
                $"Цена с НДС: {(price[n - 1] * tax / 100) + price[n - 1]}");
        }
    }
}
