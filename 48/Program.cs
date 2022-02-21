// Показать двумерный массив размером m×n заполненный целыми числами


using static System.Console;
using System.Collections.Generic;

Console.Write("Введите значение высоты массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение ширины массива и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());

int[,] table = new int[x, y];

Console.WriteLine();
for (int count = 0; count < x; count++)
{
    for (int count1 = 0; count1 < y; count1++)
    {
        table[count, count1] = new Random().Next(99, 1000);

        Console.Write($"{table[count, count1] + " "}");
    }
    Console.WriteLine();
}
Console.WriteLine();


    




