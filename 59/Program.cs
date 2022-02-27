// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
//В прямоугольной матрице найти строку с наименьшей суммой элементов.

using System;
using static System.Console;
using System.Collections.Generic;

Console.Write("Введите значение стороны массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
int y = x;

int[,] array = new int[x, y];
Random random = new Random();

Console.WriteLine();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        array[i, j] = new Random().Next(0, 9);
        Console.Write($"{array[i, j] + "   "}");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Сумма по строкам");
Console.WriteLine();
Console.WriteLine();

int sum = 0;
int[] arraymin = new int[x];

for (int j = 0; j < y; j++)
{
    for (int i = 0; i < y; i++)
    {
    sum += array[j, i];
    }
    Console.WriteLine("Столбец " + (j + 1) + " = " + sum);
    sum = 0;    
    arraymin[x] = sum;
    }
    
   Console.WriteLine($"{arraymin[x]}");  
   
 


