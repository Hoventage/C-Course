using System;

namespace Anketa
{
    class Anketa
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 1.1
            /// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
            /// рост, вес). В результате вся информация выводится в одну строчку:
            /// а) используя склеивание;
            /// б) используя форматированный вывод;
            /// в) используя вывод со знаком $.
            /// </summary>


            Console.WriteLine("Заполните, пожалуйста, анкету!");
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            double age = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вывод введенных данных в одну строку, используя склеивание: ");
            // а) Склеивание строки
            Console.WriteLine(name + " " + surname + ", " + age + ", " + height + ", " + weight);

            Console.WriteLine("Вывод введенных данных в одну строку, используя форматированный вывод: ");
            // б) Форматированный вывод
            Console.WriteLine("{0} {1}, {2}, {3}, {4}", name, surname, age, height, weight);

            Console.WriteLine("Вывод введенных данных в одну строку, используя вывод со знаком $: ");
            // в) Вывод со знаком $
            Console.WriteLine($"{name} {surname}, {age}, {height}, {weight}");

            //Оставить консоль открытой (черный экран)
            Console.ReadKey();
        }
    }
}