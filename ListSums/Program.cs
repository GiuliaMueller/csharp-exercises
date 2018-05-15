using System;
using System.Collections.Generic;
using System.Linq;

namespace ListSums
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<int> listSums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(FindEvenSum(listSums));
            Console.ReadLine();
        }
        static int FindEvenSum (List <int> myList)
        {
            int sums = 0;

            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] % 2 == 0)
                    sums += myList[i];                
            }
            return sums;
        }
    }
}

