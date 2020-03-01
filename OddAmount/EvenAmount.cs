using System;

namespace OddAmount
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

            if (num > 0 && num % 2 != 0)
            {
                amount += num;
            }

            while (num != 0)
            {
                //amount = amount;
                Console.WriteLine("Введите произвольное число: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num % 2 != 0)
                {
                    amount += num;
                }
            };
            Console.WriteLine($"The amount is {amount}");
        }
    }
}