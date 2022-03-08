// Вставка символа в строку ( по поиску элемента)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку S1: ");
            String s1 = Console.ReadLine();
            Console.Write("Введите строку S2: ");
            String s2 = Console.ReadLine();
            Console.Write("Введите символ для поиска: ");
            String c = Console.ReadLine();
            int count = s1.Length;
            int pos;
 
            while ((pos = s1.LastIndexOf(c, count, count)) != -1)
            {
                s1 = s1.Insert(pos + 1, s2); // Вставляем после найденного символа. 
                //s1 = s1.Insert(pos, s2); // Вставляем перед найденным символом
                count = pos - 1;
            }
 
            Console.WriteLine("Полученная строка: " + s1);
            Console.ReadLine();
        }
    }
}