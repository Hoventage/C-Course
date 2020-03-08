using System;

namespace ComplexProgram
{
        /// <summary>
        /// Задание 3.1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        /// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
        /// в) Добавить диалог с использованием switch демонстрирующий работу класса.
        /// </summary>
        struct Complex
        {
            public double a, b;

            public Complex(double v1, double v2)
            {
                a = v1;
                b = v2;
            }
            public static Complex Sum(Complex N1, Complex N2)
            {
                return new Complex(N1.a + N2.a, N1.b + N2.b);
            }
            public static Complex Subtraction(Complex M1, Complex M2)
            {
                return new Complex(M1.a - M2.a, M1.b - M2.b);
            }
            public static Complex Multi(Complex Z1, Complex Z2)
            {
                return new Complex(((Z1.a*Z2.a) - (Z1.b*Z2.b)), ((Z1.a*Z2.b) + (Z1.b*Z2.a)));
            }
            public static Complex Division(Complex Q1, Complex Q2)
            {
            return new Complex((((Q1.a * Q2.a) + (Q1.b * Q2.b))) / ((Math.Pow(Q2.a, 2)) + (Math.Pow(Q2.b, 2))), ((Q1.b * Q2.a) - (Q1.a * Q2.b)) / ((Math.Pow(Q2.a, 2)) + (Math.Pow(Q2.b, 2))));
            }

            public string Print()
            {
             return $"{a} + {b}i";
            }
        }

        class ComplexClass
        {

        }
        class ComplexProgram
        {
            static void Main(string[] args)
            {

            Complex com = new Complex(4, 8);
            Complex com1 = new Complex(2, 4);
            Complex com2 = Complex.Sum(com, com1);
            Complex com3 = Complex.Subtraction(com, com1);
            Complex com4 = Complex.Multi(com, com1);

            #region Проверка методов для Complex

            Console.WriteLine($"Первое комплексное число = {com.Print()}");
            Console.WriteLine($"Второе комплексное число = {com1.Print()}");
            Console.WriteLine($"Сумма комплексных чисел = {com2.Print()}");
            Console.WriteLine($"Разница комплексных чисел = {com3.Print()}");
            Console.WriteLine($"Произведение комплексных чисел = {com4.Print()}");

            #endregion

            Console.WriteLine("Введите a для компл. числа a + bi: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b для компл. числа a + bi: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c для компл. числа c + di: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d для компл. числа c + di: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Complex complex1 = new Complex(a, b);
            Complex complex2 = new Complex(c, d);

            Console.WriteLine("Введите оператор: + (сложение), - (вычитание), / (деление) или * (умножение)");
            string action = Convert.ToString(Console.ReadLine());

            switch (action)
            {
                case "+":
                    Complex complex3 = Complex.Sum(complex1, complex2);
                    Console.WriteLine($"Сумма комплексных чисел = {complex3.Print()}");
                    break;
                case "-":
                    Complex complex4 = Complex.Subtraction(complex1, complex2);
                    Console.WriteLine($"Разница комплексных чисел = {complex4.Print()}");
                    break;
                case "*":
                    Complex complex5 = Complex.Multi(complex1, complex2);
                    Console.WriteLine($"Произведение комплексных чисел = {complex5.Print()}");
                    break;
                case "/":
                    Complex complex6 = Complex.Division(complex1, complex2);
                    Console.WriteLine($"Частное комплексных чисел = {complex6.Print()}");
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректный оператор!");
                    break;
            }
            Console.ReadKey();
            }
        }
    }