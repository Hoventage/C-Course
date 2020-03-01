using System;

namespace NumeralCount
{
    class NumeralCount
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 2.2. Написать метод подсчета количества цифр числа.
            /// </summary>>

            Console.WriteLine("Введите произвольное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            howMuchNums(a);

            static void howMuchNums(int a)
            {
                int count = 0;

                while (a != 0)
                {
                    count++;
                    a = a / 10;
                }
                Console.WriteLine($"count = {count}");
            }
        }
    }
}
