using System;
using System.Text.RegularExpressions;

namespace LoginCorrectness
{
    class LoginCorrectness
    {
        /// <summary>
        /// Задание 5.1 Создать программу, которая будет проверять корректность ввода логина. Корректным
        /// логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
        /// или цифры, при этом цифра не может быть первой:
        /// </summary>

        static void Main(string[] args)
        {
            #region а)
            //M:
            //Console.WriteLine("Введите логин, мы его проверим: ");
            //string login = Console.ReadLine();

            //while (login.Length < 2 || login.Length > 10)
            //{
            //    Console.WriteLine($"Длина логина некорректна и составляет {login.Length}");
            //    goto M;
            //}

            //    for (int i = 0; i < login.Length; i++)
            //    {
            //        if ((login[0] >= '0' && login[0] <= '9'))
            //        {
            //            Console.WriteLine($"Первым символом логина не может быть цифра, Вы ввели: {login[0]}");
            //            goto M;
            //        }

            //        if ((login[i] >= 'A' && login[i] <= 'Z') || (login[i] >= 'a' && login[i] <= 'z') || (login[i] >= '0' && login[i] <= '9'))
            //        {
            //            Console.WriteLine($"Символ {login[i]} прошел проверку!");

            //        }
            //        else
            //        {
            //            Console.WriteLine($"Символ {login[i]} не прошел проверку!");
            //            goto M;
            //        }
            //    }
            #endregion

            #region б)
            string reg = @"^[A-Za-z0-9]+$";

            M:
            Console.WriteLine("Введите логин, мы его проверим: ");
            string login = Console.ReadLine();

            while (login.Length < 2 || login.Length > 10)
            {
                Console.WriteLine($"Длина логина некорректна и составляет {login.Length}");
                goto M;
            }

            for (int i = 0; i < login.Length; i++)
            {
                if (Char.IsDigit(login[0]))
                {
                    Console.WriteLine($"Первым символом логина не может быть цифра, Вы ввели: {login[0]}");
                    goto M;
                }

                if (Regex.Match(login, reg).Success)
                {
                    Console.WriteLine($"Ваш логин, {login}, прекрасен как рассвет!:)");
                    break;
                }
                else
                {
                    Console.WriteLine($"Логин {login} не прошел проверку!");
                    goto M;
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}