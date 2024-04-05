using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу");
            string str=Console.ReadLine();
            string str2 = "";
            foreach(char c in str) 
            {
                str2= c+str2;
            }
                if (str2 == str) 
                {
                    Console.WriteLine("Данная фраза является палиндромом");
                }
                else
                {
                    Console.WriteLine("Данная фраза не является палиндромом");
                }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
