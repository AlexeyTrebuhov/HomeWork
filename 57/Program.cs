// Написать программу, которая упорядочивает по убыванию элементы каждой 
//строки двумерного массива.

using System;
using static System.Console;
using System.Collections.Generic;

Console.WriteLine();
Console.Write("Введите значение высоты массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение ширины массива и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());

int[,] array = new int[x, y];
Random random = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        array[i, j] = new Random().Next(10, 99);
        Console.Write($"{array[i, j] + "  "}");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Измененный массив");

int temp = 0;

for (int sum = 0; sum < y-1; sum++)
{
    for (int i = 0; i < x; i++)
        {
           for (int j = 0; j < y-1; j++)
             {
                      
                if (array[i,j] < array [i,j+1])
                    {
                    temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                    
                    }
             }
        }
}

Console.WriteLine();

for (int i = 0; i < x; i++)
    {   
    for (int j = 0; j < y; j++)
        {
        Console.Write($"{array[i,j]}  ");
        }
    Console.WriteLine();
    }
Console.ReadKey();
