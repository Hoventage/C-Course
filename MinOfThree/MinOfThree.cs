using System;

namespace MinOfThree
{
    class MinOfThree
    {
        static void Main(string[] args)
        {
            ///<summary>
            /// Задание 2.1. Написать метод, возвращающий минимальное из трёх чисел.
            /// </summary>>

            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            minNumber(a, b, c);

            static void minNumber(int a, int b, int c)
            {
                int min;

                if (a < b && a < c)
                {
                    min = a;
                }
                else
                {
                    if (b < c)
                    {
                        min = b;
                    }
                    else
                    {
                        min = c;
                    }
                }
                Console.WriteLine($"min is {min}");
            }
        }
    }
}