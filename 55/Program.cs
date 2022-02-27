// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


using System;
using static System.Console;
using System.Collections.Generic;

Console.Write("Введите значение высоты массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение ширины массива и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());

int[,] array = new int[x, y];
Random random = new Random();

Console.WriteLine();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        array[i, j] = new Random().Next(-500, 500);
        Console.Write($"{array[i, j] + "   "}");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Среднеарифметические значения по столбцам");
Console.WriteLine();
Console.WriteLine();

int sum = 0;

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
    sum += array[j, i]; 
    sum = sum / x; 
    }
    Console.WriteLine("Столбец " + (i + 1) + " = " + sum);  
    sum = 0;    
    }





 