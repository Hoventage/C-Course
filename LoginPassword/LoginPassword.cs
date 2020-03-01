using System;

namespace LoginPassword
{
    class LoginPassword
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 2.4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
            /// выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password:
            /// GeekBrains).Используя метод проверки логина и пароля, написать программу: пользователь
            /// вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
            /// цикла do while ограничить ввод пароля тремя попытками.
            /// </summary>>

            string login, password;
            int n = 0;

            do
            {
                Console.WriteLine($"Попытка авторизации № {n+1}");

                Console.Write("Введите логин: ");
                login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                password = Console.ReadLine();

                n++;

            } while (!(AuthorizeOrNot(login, password)) && n <= 2);

            static bool AuthorizeOrNot(string login, string password)
            {

                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Авторизационные данные введены верно!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Вы неверно ввели авторизационные данные :(");
                    return false;
                }
            }
            Console.ReadKey();
        }
    }
}