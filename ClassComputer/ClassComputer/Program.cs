using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassComputer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Класс "Компьютер"
            Создайте класс Computer с полями processor, ram и storage. Добавьте метод, который выводит информацию о компьютере.*/
            Computer first = new Computer("AMD Ryzen", 32, 560);
            first.printinfo();

            Computer second = new Computer("Intel Core", 24, 400);
            second.printinfo();

            Console.ReadKey();
        }
    }
    class Computer
    {
        public string processor;
        public int ram;
        public int storage;

        public Computer(string processor, int ram, int storage)
        {
            this.processor = processor;
            this.ram = ram;
            this.storage = storage; 
        }

        public void printinfo()
        {
            Console.WriteLine("Процессор: " + processor + "\nОперативная память: " + ram + "Gb" + "\nХранилище: " + storage + "Gb");
            Console.WriteLine();
        }
    }
}
