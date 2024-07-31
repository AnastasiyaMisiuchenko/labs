using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPhone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Класс "Телефон"
            Создайте класс Phone с полями brand, model и price. Реализуйте метод для вывода информации о телефоне. */
            Phone Iphone = new Phone("Iphone", "15", 1000);
            Iphone.printInfo();
            Phone Samsung = new Phone("Samsung", "A53", 300);
            Samsung.printInfo();
            Console.ReadKey();  
        }
    }
    class Phone
    {
        public string brand;
        public string model;
        public int price;

        public Phone(string brand, string model, int price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price; 
        }

        public void printInfo()
        {
            Console.WriteLine("Бренд: " + brand + "\nМодель: " + "" + model + "\nЦена: " + price + "$");
            Console.WriteLine();
        }
    }
}
