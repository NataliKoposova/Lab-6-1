﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string max = strArray[1];
            foreach (string s in strArray)
            {
                if (s.Length >= max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine("Самое длинное слово:{0}", max);
            Console.ReadKey();

        }
    }
}
