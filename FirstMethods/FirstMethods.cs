using System;

namespace methods
{
    public class FirstMethods
    {
        /// <summary>
        /// Задание 1.6
        /// Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
        /// </summary>
        
        public void PauseWindow()
        {
            Console.ReadKey();
        }

        public void SetCursorAtMid()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
        }

        // Разве обязательно должен быть entry point? Если нет, то как этого избежать?
        static void Main(string[] args)
        {
        }
    }
}