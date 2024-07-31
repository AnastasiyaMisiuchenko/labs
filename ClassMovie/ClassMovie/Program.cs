using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Класс "Фильм"
            Создайте класс Movie с полями title, director и duration. Напишите метод, который отображает, 
            сколько времени осталось до конца фильма, если известно, сколько времени прошло.*/
            Movie first = new Movie("Век Адалин", "Ли Толанд Кригер", 112);
            first.durationEnd();

            Movie second = new Movie("Аннигиляция", "Алекс Гарленд", 120);
            second.durationEnd();

            Console.ReadKey();
        }
    }
    class Movie
    {
        public string title;
        public string director;
        public double duration;

        public Movie(string title, string director, double duration)
        {
            this.title = title;
            this.director = director;
            this.duration = duration;
        }

        public void durationEnd()
        {
            Console.WriteLine("Сколько минут фильма " + title + " уже просмотрено?");
            int input = int.Parse(Console.ReadLine());
            if (input < duration)
            {
                Console.WriteLine("До конца фильма осталось " + (duration - input) + " минут.");
            }
            else
            {
                Console.WriteLine("Указанное время больше продолжительности фильма");
            }
            Console.WriteLine();
        }

    }
}
