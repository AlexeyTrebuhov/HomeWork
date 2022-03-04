// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 
///(в случае, если матрица не квадратная).


using static System.Console;
using System.Collections.Generic;

Console.Write("Введите значение высоты массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение ширины массива и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());

int[,] mas = new int[x, y];

Console.WriteLine();

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        mas[i,j] = new Random().Next(99, 1000);

        Console.Write($"{mas[i,j] + " "}");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] mas1 = new int[y, x];
int b = 0;

for (int i = 0; i < y; i++)
{
    for (int j = 0; j < x; j++)
    {
        b = x[i];
        x[i] = y[j];
        y[j] = b;

        Console.Write(mas1[i, j] + "\t");
    }
    Console.WriteLine();
}

            

