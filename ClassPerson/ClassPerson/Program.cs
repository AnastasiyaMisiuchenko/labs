using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Класс "Человек"
            Создайте класс Person с полями name и age. Добавьте метод для вывода информации о человеке.
            Спросить у пользователя сколько человек он хочет создать, после этого создать необходимое количество 
            объектов это класса и поместить в массив. Вывести информацию по всем объектам типа "Человек" из созданного массива.*/
            int amount = 0;
            do
            {
                try
                {
                    Console.WriteLine("Какое количество человек вы хотели бы создать?");
                    amount = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: неверный формат.");
                }
            } while (amount < 1);
            Person[] people = new Person[amount]; 

            for (int i = 0; i < amount; i++)
            {
                people[i] = new Person("Name", 1);
                Console.Write("Введите имя человека: ");
                people[i].name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите возраст человека: ");
                people[i].age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            for (int i = 0; i < amount; i++)
            {
                people[i].printInfo();
            }
            Console.ReadKey();
        }
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void printInfo()
        {
            Console.WriteLine("Имя: " + name + "\nВозраст: " + age);
            Console.WriteLine(); 
        }
    }
}
