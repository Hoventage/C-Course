using methods;
using System;

namespace CenterLine
{
    class CenterLine : FirstMethods
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 1.5
            /// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            /// б) *Сделать задание, только вывод организовать в центре экрана.
            /// в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int
            /// x, int y).
            /// </summary>>


            string name = "Илья";
            string surname = "Филимонов";
            string city = "Санкт - Петербург";

            // а) Простой вывод строки
            //Console.WriteLine(name + " " + sename + ", " + city);

            // б) Вывод строки по центру экрана консоли
            SetCursorAtMid();
            WriteMyInfo(name, surname, city);
            PauseWindow();

            // в) Собственные методы
            static void PauseWindow()
            {
                Console.ReadKey();
            }

            static void SetCursorAtMid()
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            }

            static void WriteMyInfo(string name, string surname, string city)
            {
                Console.WriteLine(name + " " + surname + ", " + city);
            }
        }
    }
}