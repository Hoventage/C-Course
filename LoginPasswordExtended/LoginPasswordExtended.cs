using System;
using System.IO;

namespace LoginPasswordExtended
{
    /// <summary>
    /// Задание 4.4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    /// Создайте структуру Account, содержащую Login и Password.
    /// </summary>

    class LoginPasswordExtended
    {
        struct Account
        {
            public Account(string Login, string Password)
            {
                this.Login = Login;
                this.Password = Password;
            }
            public string Login { get; set; }
            public string Password { get; set; }

            public override string ToString()
            {
                return $"{Login} {Password}";
            }
        }
        static void Main(string[] args)
        {
            // Записываем данные из файла в массив
            string[] allLines = File.ReadAllLines("LoginPasswordExamples.txt");

            // Выводим массив в консоли
            for (int i = 0; i < allLines.Length; i++)
            {
                Console.WriteLine($"{allLines[i]}");
            }

            // Создаем массив, используя структуру Account. Кладем в него три наших аккаунта (в файле три пары логин-пароль)
            Account[] array = new Account[]
            {
                new Account(allLines[0], allLines[1]),
                new Account(allLines[2], allLines[3]),
                new Account(allLines[4], allLines[5])
            };

            int n = 0;

            // Перебираем пары логин-пароль, пока не наткнемся на нужную нам
            do
            {
                Console.WriteLine($"Попытка авторизации № {n + 1}");

                Console.WriteLine($"Ваши логин и пароль: {array[0 + n]}");

                n++;

            } while (!AuthorizeOrNot(array[0 + (n - 1)]));

            // Немного измененный метод. Теперь на вход мы передаем объект типа Account
            static bool AuthorizeOrNot(Account account)
            {
                if (account.Login == "root" && account.Password == "GeekBrains")
                {
                    Console.WriteLine("Авторизационные данные выбраны верно!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Авторизационные данные выбраны неверно :(");
                    return false;
                }
            }
            Console.ReadKey();
        }
    }
}
