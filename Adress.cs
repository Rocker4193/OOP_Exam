using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    class Adress
    {
        public Adress(int Index, string Country, string City, string Street, int House, int Apartment)
        {
            this.Index = Index;
            this.Country = Country;
            this.City = City;
            this.Street = Street;
            this.House = House;
            this.Apartment = Apartment;
        }
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Index: {Index}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Street: {Street}");
            Console.WriteLine($"House: {House}");
            Console.WriteLine($"Apartment: {Apartment}");
        }
    }
}
