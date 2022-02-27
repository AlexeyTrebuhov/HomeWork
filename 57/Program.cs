// Написать программу, которая упорядочивает по убыванию элементы каждой 
//строки двумерного массива.

using System;
using static System.Console;
using System.Collections.Generic;

Console.WriteLine();
int x = 3;
int y = 7;
int[,] array = new int[x, y];
Random random = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        array[i, j] = new Random().Next(10, 99);
        Console.Write($"{array[i, j] + " "}");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Измененный массив");
Console.WriteLine();

int temp = array [0,0];
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (temp < array [i,j])
        {
            array [i,j] = temp;
        }

     }
}


for (int i = 0; i < array.GetLength(0); i++)//вывод массива на экран
    {   
    for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write($"{array[i,j]}  ");
        }
    Console.WriteLine();
    }
Console.ReadKey();

