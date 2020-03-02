using System;

namespace methods
{
    public class FirstMethods
    {
        /// <summary>
        /// Задание 1.6
        /// Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
        /// </summary>
        
        static void Main(string[] args)
        {
            static void PauseWindow()
            {
                Console.ReadKey();
            }

            static void SetCursorAtMid()
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            }
        }
    }
}