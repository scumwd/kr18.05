using System;
using System.Collections.Generic;

namespace kr1
{
    class Program
    {
        static Random rnd = new Random();
        static List<int> CreateList()
        {
            var list = new List<int>();            
            Console.WriteLine();
            for (int i = 0; i < rnd.Next(10, 20); i++)
            {
                list.Add(rnd.Next(0, 100));
            }
            list.Sort();
            foreach (int e in list)
            {
                Console.WriteLine(e);
            }
            return list;
        }
        static void Main(string[] args)
        {
            var num = new List<int>();
            Console.WriteLine("Введите число K");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                num.AddRange(CreateList());
            }
            num.Sort();
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}