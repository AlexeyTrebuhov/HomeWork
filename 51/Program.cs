// Задать двумерный массив следующим правилом: Aₘₙ = m+n.

using System;
using static System.Console;
using System.Collections.Generic;

int x = 7;
int y = 11;

int[,] array = new int[x, y];
Random random = new Random();

Console.WriteLine();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        array[i, j] = i + j;
        Console.Write($"{array[i, j] + " "}");
    }
    Console.WriteLine();
}
