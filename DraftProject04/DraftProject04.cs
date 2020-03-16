using System;
using System.IO;

namespace DraftProject04
{
    class DraftProject04
    {

        struct Man
        {
            public Man(string Name, int Age, int Salary, int[] ArrayName)
            {
                this.Name = Name;
                this.Age = Age;
                this.Salary = Salary;

                testArray = ArrayName;
            }

            public int Age { get; set; }
            public int Salary { get; set; }
            public string Name { get; set; }

            int[] testArray;

            public override string ToString()
            {
                return $"{Name} {Age} {Salary}";
            }
        }



        //struct Ppls
        //{
        //    public int Age { get; set; }
        //    public int Salary { get; set; }
        //    public string Name { get; set; }

        //    public override string ToString()
        //    {
        //        return $"{Name} {Age} {Salary}";
        //    }
        //}


        static void Main(string[] args)
        {
            #region Example 1
            ////Пример метода, полностью отвязанного от потенциального интерфейса

            //int WhatIsMax(int a, int b)
            //{   
            //    // is this true or not? yes : no
            //    return a > b ? a : b;
            //}

            //Console.WriteLine(WhatIsMax(-4, 11));
            //Console.ReadKey();
            #endregion

            //Arrays

            #region Array1
            //Ppls[] people = new Ppls[7]
            //{
            //    new Ppls() { Age = 10, Salary = 1000, Name = "Andrew1" },
            //    new Ppls() { Age = 10, Salary = 1000, Name = "Andrew2" },
            //    new Ppls() { Age = 10, Salary = 1000, Name = "Andrew3" },
            //    new Ppls() { Age = 10, Salary = 1000, Name = "Andrew4" },
            //    new Ppls() { Age = 10, Salary = 1000, Name = "Andrew5" },
            //    new Ppls() { Age = 10, Salary = 1000, Name = "Andrew6" },
            //    new Ppls() { Age = 10, Salary = 1000, Name = "Andrew7" }
            //};

            //Console.WriteLine(people[0].ToString());

            #endregion

            #region Array2
            //Ppls[] people2 = new Ppls[2];

            //people2[0] = new Ppls { Age = 10, Name = "qwerty7", Salary = 1000 };
            //people2[1] = new Ppls { Age = 10, Name = "qwerty7", Salary = 1000 };
            //people2[2] = new Ppls { Age = 10, Name = "qwerty7", Salary = 1000 };
            #endregion

            #region Array3
            //int[] newArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            //foreach (var item in newArray) Console.Write($"{item} "); Console.WriteLine();

            //Array.Sort(newArray);

            //foreach (var item in newArray) Console.Write($"{item} "); Console.WriteLine();
            #endregion

            #region Array4

            //string[,] kindaMatrix = new string[4, 3]
            //{
            //    {"00", "01", "02" },
            //    {"10", "11", "12" },
            //    {"20", "21", "22" },
            //    {"30", "31", "32" }
            //};

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int q = 0; q < 3; q++)
            //    {
            //        Console.Write($"{kindaMatrix[i,q]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Array5

            //int[,] pascal = new int[10, 10];

            //for (int i = 0; i < pascal.GetLength(0); i++)
            //{
            //    pascal[i, 0] = 1;
            //    pascal[i, i] = 1;
            //};

            //for (int i = 0; i < pascal.GetLength(0); i++)
            //{
            //    for (int j = 0; j < pascal.GetLength(1); j++)
            //    {
            //        if (j <= i) Console.Write($"{pascal[i,j],5}");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Пример работы с файлом

            string[] allLines =  File.ReadAllLines("TestFile.txt");

            for (int i = 0; i < allLines.Length; i++)
            {
                int q = Convert.ToInt32(allLines[i]);
                Console.WriteLine(q*10);
            }

            #endregion

        }

    }
}