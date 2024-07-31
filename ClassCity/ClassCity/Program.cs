using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Класс "Город"
            Создайте класс City с полями name, population и area. Реализуйте метод для вычисления плотности населения.*/
            City Budapest = new City("Budapest", 1671004, 525.2);
            Budapest.PopulationDensity();

            City NY = new City("New York", 8467513, 783.8);
            NY.PopulationDensity();

            Console.ReadKey();
        }
    }
    class City
    {
        public string name;
        public int population;
        public double area;

        public City(string name, int population, double area)
        {
            this.name = name;
            this.population = population;
            this.area = area;
        }

        public void PopulationDensity()
        {
            double PopulationDensity = population / area;
            Console.WriteLine("Плотность населения " + name + ":\t" + PopulationDensity + " чел./км2.");
        }
    }
}
