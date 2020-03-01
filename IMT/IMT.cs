using System;
using System.Collections.Generic;
using System.Text;

namespace IMT
{
    class IMT
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 1.2
            /// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
            /// I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            /// </summary>>

            Console.WriteLine("Давайте рассчитаем IMT человека!");
            Console.Write("Введите вес человека в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите рост человека в сантиметрах: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double i = weight / (height * height);

            Console.WriteLine("IMT = " + i);

            Console.ReadKey();
        }
    }
}