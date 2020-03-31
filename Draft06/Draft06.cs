using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Draft06
{
    class Draft06
    {
        static void Main(string[] args)
        {

            #region Коллекции, словари

            //List<double> collectionDouble = new List<double>() { 1, 2, 3, 4, 5, 6, 1, 2, 2, 2, 3, 4, 5, 1, 2, 3, 4, 1000 };

            ////int[] a = new int[] { 1, 2, 3, 4, 5, 6, 1, 2, 2, 2, 3, 4, 5, 1, 2, 3, 4, 1000 };

            ////Array.Resize(ref a, a.Length + 1);
            ////a[a.Length - 1] = 2020;

            //collectionDouble.Add(2021);

            ////double[] c = new double[(int)collectionDouble.Max() + 1];

            //Dictionary<double, int> dict = new Dictionary<double, int>();



            //collectionDouble.RemoveAt(0);

            //for (int i = 0; i < collectionDouble.Count; i++)
            //{
            //    //c[(int)collectionDouble[i]]++;

            //    if (dict.ContainsKey(collectionDouble[i]))
            //    {
            //        dict[collectionDouble[i]]++;
            //    }
            //    else
            //    {
            //        dict.Add(collectionDouble[i], 1);
            //    }

            //}

            ////for (int i = 0; i < c.Length; i++)
            ////{
            ////    if (c[i] != 0)
            ////    {
            ////        Console.WriteLine($"{i} встречается {c[i]} раз");
            ////    }

            ////}

            //foreach(var e in dict)
            //{
            //    Console.WriteLine(e);
            //}

            #endregion

            #region Файлы 1

            //var fileLines = File.ReadAllLines(@"holyCrap.txt").ToList();


            ////List<string> fileLines = new List<string>();

            ////using (StreamReader stream = new StreamReader(@"holyCrap.txt"))
            ////{
            ////    while (!stream.EndOfStream)
            ////    {
            ////        fileLines.Add(stream.ReadLine());
            ////    }

            ////}


            //foreach (var i in fileLines)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Файлы 2

            //Directory.CreateDirectory(@"C:\\TestingIsLife");

            //FileInfo file = new FileInfo(@"C:\\TestingIsLife");

            //Console.WriteLine(file.Directory);


            #endregion

        }
    }
}
