using System;

namespace StructureExample
{
    class StructureExample
    {
        struct Complex
        {
            public double a, b;

            public Complex (double v1, double v2)
            {
                a = v1;
                b = v2;

            }

            public string Print()
            {
               return $"{a} + {b}i";
            }

            public static Complex Sum(Complex N1, Complex N2)
            {
                return new Complex(N1.a + N2.a, N1.b + N2.b);
            }

        }

        static void Print (int a)
        {
            Console.Write("+ ");
            if (a<100) Print(++a);
        }


        #region Работник. Структура + конструктор

        //struct Employee
        //{
        //    public Employee(string Name, int Age, int Salary)
        //    {
        //        this.Name = Name;
        //        this.Age = Age;
        //        this.Salary = Salary;
        //    }

        //    public string Print()
        //    {
        //        return $"Name = {this.Name}, age = {this.Age}, salary = {this.Salary}";
        //    }

        //    public string Name;
        //    public int Age;
        //    public int Salary;
        //}
        #endregion

        static void Main(string[] args)
        {
            Print(1);


            #region Комплексные числа

            //Complex comp = new Complex(1, 2);
            //Complex comp1 = new Complex(3, 5);
            //Complex comp2 = Complex.Sum(comp, comp1);

            //Console.WriteLine(comp.Print());
            //Console.WriteLine(comp1.Print());
            //Console.WriteLine(comp2.Print());

            #endregion

            #region Пример с работником

            //Employee employee1 = new Employee("Alex", 300, 40000);
            //Employee employee2 = new Employee("Ocultist", 4001, 100);

            //Console.WriteLine(employee1.Print());
            //Console.WriteLine(employee2.Print());

            #endregion

            Console.ReadKey();
        }
    }
}