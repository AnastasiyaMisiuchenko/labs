using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте класс Car с полями brand, model и year. Напишите метод, который выводит информацию об автомобиле. 
             * Создать 5 объектов машин, спросить у пользователя какого бренда машины его интересуют, вывести все машины 
             * соответственного бренда из существующих. */
            Car[] car = new Car[5];
            car[0] = new Car("Audi", "Q5", 2020);
            car[1] = new Car("BMW", "F3", 2023);
            car[2] = new Car("KIA", "Ceed", 2013);
            car[3] = new Car("Audi", "A8", 2018);
            car[4] = new Car("Audi", "A6 C6", 2005);
            Console.WriteLine("Какая марка автомобиля вас интересует?");
            string brand = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < car.Length; i++)
            {
                
                if (car[i].brand == brand)
                {
                    car[i].printInfo();
                    a++;
                    
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Найдено 0 машин.");
            }


            Console.ReadKey();
        }
        
    }

    class Car
    {
        public string brand;
        public string model;
        public int year;

        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public void printInfo()
        {
            Console.WriteLine("Бренд: " + brand + "\nМодель: " + model + "\nГод выпуска: " + year);
            Console.WriteLine();
        }
    }
}

