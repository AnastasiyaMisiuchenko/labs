using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Класс "Сотрудник"
            Создайте класс Employee с полями name, position и salary. Добавьте метод для вывода информации о сотруднике.*/
            Employee Helen = new Employee("Helen R", "Sales manager", 800);
            Helen.printInfo();

            Employee Mark = new Employee("Mark S", "Head of Sales Department", 1000);
            Mark.printInfo();

            Console.ReadKey();
        }
    }
    class Employee
    {
        public string name;
        public string position;
        public int salary;

        public Employee(string name, string position, int salary)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
        }

        public void printInfo()
        {
            Console.WriteLine("Имя: " + name + "\nДолжность: " + position + "\nЗарплата: " + salary + "$");
            Console.WriteLine();
        }
    }
}
