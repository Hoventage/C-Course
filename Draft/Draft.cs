using System;

namespace Draft
{
    class Draft
    {
        static void Main(string[] args)
        {
            #region Пример 2

            Random rand = new Random();

            int weather = rand.Next(-30, 30);

            Console.WriteLine($"weather =  {weather}");

            if (weather <= -5)
            {
                Console.WriteLine("шапка!");
                Console.WriteLine("Дубово");
            }
            else
            {
                if ((weather >= -4) && (weather <= 9))
                {
                    Console.WriteLine("по настроению :)");
                }
                else
                {
                    if (weather >= 10)
                    {
                        Console.WriteLine("лучше без шапки!");
                    }
                }
            }
            #endregion



            #region Пример 1

            //Console.WriteLine("введите первое число: "); int q = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите второе число: "); int w = Convert.ToInt32(Console.ReadLine());

            //if (q == w)
            //{
            //    Console.WriteLine($"{q} = {w}");
            //}
            //else if (q > w)
            //{
            //    Console.WriteLine($"{q} > {w} Да");
            //}
            //else
            //{
            //    Console.WriteLine($"{q} > {w} Нет");
            //}
            #endregion
        }
    }
}
