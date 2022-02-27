// Показать двумерный массив размером m×n, заполненный вещественными числами

using System;
using static System.Console;
using System.Collections.Generic;

Console.Write("Введите значение высоты массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение ширины массива и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());

double[,] array = new double[x, y];
Random random = new Random();

Console.WriteLine();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
        {
        array[i, j] = random.NextDouble() * 100;
        Console.Write($"{array[i, j] + " "}");
        }
    Console.WriteLine();
}
Console.WriteLine();
