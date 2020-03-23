using System;
using System.Net;
using System.Text;

namespace AnotherDraft05
{
    class AnotherDraft05
    {
        static void Main(string[] args)
        {
            #region Char
            while (true)
            {
                char c = Console.ReadKey().KeyChar;
                if (c >= '0' && c <= '9') Console.WriteLine(" Hurrey!");
                else Console.WriteLine(" Shame on me =/");

                Console.WriteLine(Char.IsDigit(c) ? "+" : "-");

                if ((c >= 'A' && c <= 'Z') || (c >= 'А' && c <= 'Я') || c == 'Ё')
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }

                Console.WriteLine(Char.IsUpper(c) ? "+" : "-");

            }
            #endregion

            #region String 1. Пример с получением тайтлов сайтов

            //    string[] urls = new string[]
            //    {
            //        "https://jira.esphere.ru/browse/SBINV-17191",
            //        "https://yandex.ru/",
            //        "https://www.google.ru/",
            //        "https://vk.com",
            //        "https://market.yandex.ru/"
            //    };

            //    foreach (var url in urls)
            //    {
            //        Console.WriteLine(GetWebPageTitle(url));
            //    }
            #endregion
        }

        private static string GetWebPageTitle(string Url)
        {
            string html = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(Url);

            int posStart = html.IndexOf("<title>") + "<title>".Length;
            int posEnd = html.IndexOf("</title>");
            int lenght = posEnd - posStart;

            string title = html.Substring(posStart, lenght);
            return title;
        }
    }
}