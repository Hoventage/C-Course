using System;
using System.Collections.Generic;

namespace Draft0601
{
    //public delegate void Prorab();

    class Delegates
    {
        //static void Builder1() { Console.WriteLine("Подвал строим"); }
        //static void Builder2() { Console.WriteLine("Стены строим"); }
        //static void Builder3() { Console.WriteLine("Крышу страим"); }

        static bool HeHeHe(int a)
        {
            return a % 3 == 0 && a != 0;
        }

        delegate bool TestRab(int e);



        static void Main(string[] args)
        {

            static List<int> TestFindAll(List<int> Test, TestRab find)
            {
                List<int> temp = new List<int>();

                foreach(var item in Test)
                {
                    if (find(item))
                    {
                        temp.Add(item);
                    }
                }
                return temp;
            }


            //Prorab Ali;

            //Ali = Builder1;

            
            List<int> firstList = new List<int>() { 1,2,3,4,5,6,6,6,6,7,8,9,0,9,8,7,6,5,5,4,4,3,2,3,2};

            var answer = TestFindAll(firstList, HeHeHe);

            //var answer = firstList.FindAll(HeHeHe);

            //List<int> secondList = new List<int>();

            //foreach (var item in firstList)
            //{
            //    if (item%3==0 && item != 0)
            //    {
            //        secondList.Add(item);
            //    }
            //}

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }



        }
    }
}
