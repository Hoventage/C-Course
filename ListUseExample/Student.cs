using System;
using System.Collections.Generic;
using System.IO;

namespace ListUseExample
{
    /// <summary>
    /// Лекция 6. Задание 3. Переделать программу Пример использования коллекций для решения следующих задач:
    /// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    /// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    /// в) отсортировать список по возрасту студента;
    /// г) * отсортировать список по курсу и возрасту студента;
    /// </summary>

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        // Создаем конструктор
        public Student(string firstName, string lastName, string university,
        string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
    class Program
    {
        
        static int AgeCompare(Student st1, Student st2)          // Создаем метод для сравнения
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());          // Сравниваем две строки
        }

        // Создаем метод для сравнения возраста и курса
        static int CourseAndAgeCompare(Student st1, Student st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int course5 = 0;
            int course6 = 0;

            List<Student> list = new List<Student>();                             // Создаем список студентов

            DateTime dt = DateTime.Now;

            Dictionary<int, int> cousreFrequency = new Dictionary<int, int>(); // Создаем словарь для последующей записи в него информации о студентах

            StreamReader sr = new StreamReader(@"students_6.csv"); // Будем считывать данные из .csv файла, который нужно заранее создать. Открываем стрим

            while (!sr.EndOfStream) // Пока стрим не закончился...
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                    // Одновременно подсчитываем количество магистров и бакалавров
                    if (int.Parse(s[5]) < 5) bakalavr++; else magistr++;

                    // Считаем количество студентов 5го курса
                    if (int.Parse(s[5]) == 5) course5++;

                    // Считаем количество студентов 6го курса
                    if (int.Parse(s[5]) == 6) course6++;

                    // Заполняем словарь cousreFrequency (студенты по возрасту)
                    if (int.Parse(s[6]) >= 18 && int.Parse(s[6]) <= 20) // Если возраст подпадает под интересующий нас интервал, то...
                    {
                        if (cousreFrequency.ContainsKey(int.Parse(s[6]))) // Проверяем, содержит ли наш словарь данный ключ
                            cousreFrequency[int.Parse(s[6])] += 1; // Если ДА, то просто увеличиваем value для данного key
                        else
                            cousreFrequency.Add(int.Parse(s[6]), 1); // Если НЕТ, то записываем новый key с value 1
                    }
                }
                catch (Exception e) // В любой непонятной ситуации ловим эксепшн, выводим его в консоли и добавляем дефолтное сообщение
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");

                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close(); // Закрываем стрим

            Console.WriteLine("Всего студентов:" + list.Count);

            Console.WriteLine($"Бакалавров {bakalavr}");

            Console.WriteLine($"Магистров {magistr}");

            Console.WriteLine($"Студентов 5го курса {course5}");

            Console.WriteLine($"Студентов 6го курса {course6}");

            Console.WriteLine("\nПосмотрим, сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся.");

            // Покурить ICollection и Format. Верна ли реализация?
            ICollection<int> keys = cousreFrequency.Keys;

            String result = String.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");

            foreach (int key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n", key, cousreFrequency[key]);

            Console.WriteLine($"\n{result}");

            // Отсортируем список студентов по возрасту
            list.Sort(new Comparison<Student>(AgeCompare));

            Console.WriteLine("Отсортируем студентов по возрасту: ");

            // Выведем в консоль наших студентов с указанием имени и возраста
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

            // Отсортируем список студентов по возрасту и курсу
            list.Sort(new Comparison<Student>(CourseAndAgeCompare));

            Console.WriteLine("\nОтсортируем студентов по курсу и возрасту: ");

            // Выведем в консоль наших студентов с указанием имени, курса и возраста
            foreach (var v in list) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");

            Console.WriteLine(DateTime.Now - dt);

            Console.ReadKey();
        }
    }

}