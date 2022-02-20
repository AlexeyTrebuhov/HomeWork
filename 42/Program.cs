///Определить сколько чисел больше 0 введено с клавиатуры

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int summ = 0;
            int z = 2;

            Console.WriteLine();
            Console.WriteLine("0 - выход из программы");
            Console.WriteLine();
            
            do
            {
                Console.Write("Введите число   ");
                value = Int32.Parse(Console.ReadLine());

                if (value > 0)
                    summ = summ + 1;
                if (value <= 0)
                    summ = summ;
            }

            while (value != 0);

            Console.WriteLine();
            Console.WriteLine($"Чисел больше ноля {summ}");
            Console.ReadKey();
        }
    }
}
