// Написать программу масштабирования фигуры

using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inputArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько у фигуры координатных точек ");
            int z = int.Parse(Console.ReadLine());
            int[,] mas = new int[2, z];
            Console.WriteLine();
            Console.WriteLine("Введите координаты точек");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    Console.Write(" mas[" + i + "," + j + "]: " + mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
                Console.WriteLine();
                Console.Write(" Введите коэффициент масштабирования ");
            
            int k = int.Parse(Console.ReadLine());
            int[,] mas1 = new int[2, z];
    
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < z; j++)
                    {
                    mas1[i, j] = mas[i, j] * k;
                    Console.Write(mas1[i,j] + "\t");
                    ///Console.WriteLine("mas1[" + i + "," + j + "]: ");
                   }
                Console.WriteLine();
            }
        }
    }   
}       
    


