using System;

namespace EvenAmount
{
    class EvenAmount
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 3.2 С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
            /// Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.
            /// </summary>>

            int num, amount = 0;

            Console.WriteLine("Вводите целые числа по одному.\nВведите 0, чтобы посчитать сумму");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Вы уверены, что ввели число?");
                }

                if (num > 0 && num % 2 != 0)
                {
                    amount += num;
                }

            } while (num != 0);

            Console.WriteLine($"Сумма введенных положительных нечетных чисел = {amount}");
            Console.ReadKey();
        }
    }
}