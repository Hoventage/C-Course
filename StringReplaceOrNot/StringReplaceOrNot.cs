using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringReplaceOrNot
{
    class StringReplaceOrNot
    {
        /// <summary>
        /// Задание 5.3 Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа предназначена для определения, являются ли строки перестановкой друг друга");
            Console.WriteLine("Вам предлагается ввести два набора символов. Можно вводить: буквы, цифры и пробел");
            M:
            Console.WriteLine("Введите первый набор символов: ");
            string firstString = Console.ReadLine();
            Console.WriteLine("Введите второй набор символов: ");
            string secondString = Console.ReadLine();

            if (firstString == secondString)
            {
                Console.WriteLine("Введенные наборы символов идентичны. Повторите ввод!");
                goto M;
            }

            if (IsReplaced(firstString, secondString))
            {
                Console.WriteLine($"Вторая строка ({secondString}) является перестановкой первой ({firstString})");
            }
            else
            {
                Console.WriteLine($"Вторая строка ({secondString}) не является перестановкой первой ({firstString})");
            }
             
            
        }

        private static bool IsReplaced(string First, string Second)
        {
            return First.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(Second.Select(Char.ToUpper).OrderBy(x => x));
        }
    }
}
