// Написать программу замену элементов массива на противоположные

using static System.Console;
using System;

namespace massiv1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите n");
            //int n = int.Parse(Console.ReadLine());
            int n = 0;
            int[] a = new int[n];
            int i = 0;
            
            Console.WriteLine("Введите {0}-й элемент", i + 1);
            a[i] = int.Parse(Console.ReadLine());
            
            int k = 0;
            for (int i = 0; i < a.Length; i++) 
                if (a[i] % 2 == 0) 
                    k++;  
            Console.WriteLine(k);
            Console.ReadKey();
 
        }
    }
}
