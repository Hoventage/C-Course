using System;

namespace EvenAmount
{
    class EvenAmount
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 2.3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            /// </summary>>

            Console.WriteLine("Введите произвольное число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int amount = 0;

            while (num != 0)
            {
                if (num > 0 && num % 2 != 0)
                {
                    amount += num;
                }
                Console.WriteLine("Введите произвольное число: ");
                num = Convert.ToInt32(Console.ReadLine());
            };
            Console.WriteLine($"The amount is {amount}");
        }
    }
}