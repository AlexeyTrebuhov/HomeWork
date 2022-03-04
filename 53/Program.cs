// В двумерном массиве показать позиции числа, заданного пользователем, 
//или указать, что такого элемента нет.

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
        Console.Write($"{array[i, j] + " "}");
        }
        Console.WriteLine();
    }
Console.Write("Через пробел введите позицию числа в массиве, сначала по горизонтали" );
Console.WriteLine (" потом по вертикали и нажмите Enter: ");

string text = Console.ReadLine();
var data = text.Split(" ");
int w = text [0] - 48;
int z = text [2] - 48;

if ((w <= x) & ( z <= y))
{
Console.WriteLine($"Число с индексами [{w}] и [{z}] - это {array[w,z]}");
}
if ((w > x) | (z > y))
{
Console.WriteLine();
Console.Write($"Число с координатами {w} {z} находится вне матрицы");
Console.WriteLine();
}
