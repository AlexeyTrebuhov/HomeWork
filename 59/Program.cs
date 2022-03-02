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
        array[i, j] = new Random().Next(-9, 9);
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
int temp = 0;
int min = 0;
int count = 0;
int min1 = 0;

for (int j = 0; j < y; j++)
{
    sum = 0;
    for (int i = 0; i < y; i++)
    {
    sum += array[j, i];
    }
    Console.WriteLine(sum);
    count = count + 1;

     temp = sum;
    if ( temp < min )
    {
     min = temp;
     min1 = count;
    }
}
Console.WriteLine();
Console.WriteLine($" Строка с минимальной суммой цифр - ");
Console.WriteLine($" номер {min1}, считая сверху, сумма цифр у нее:  {min}");
Console.WriteLine();

 


