using System;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// Задание 1.3
            /// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
            /// y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
            /// используя спецификатор формата .2f(с двумя знаками после запятой);
            /// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            /// </summary>>

            Console.WriteLine("Введите, пожалуйста, координаты для двух точек:");
            Console.Write("Введите значение для x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение для y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение для x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение для y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine($"Расстояние между точками = {distance:f2}");

            static double method(double x1, double y1, double x2, double y2)
            {
                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            };

            Console.WriteLine($"Расстояние между точками =  {method(x1, x2, y1, y2):f2}");
            Console.ReadKey();
        }
    }
}