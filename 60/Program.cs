// Составить частотный словарь элементов двумерного массива

using static System.Console;
using System.Collections.Generic;

Console.Write("Введите значение высоты массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение ширины массива и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());

int[,] table = new int[x, y];

Console.WriteLine();

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        table[i, j] = new Random().Next(0,9);

        Console.Write($"{table[i,j] + " "}");
    }
    Console.WriteLine();
}
Console.WriteLine();

int summ0 = 0;
int summ1 = 0;
int summ2 = 0;
int summ3 = 0;
int summ4 = 0;
int summ5 = 0;
int summ6 = 0;
int summ7 = 0;
int summ8 = 0;
int summ9 = 0;

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (table[i, j] == 0)
            summ0 = summ0 + 1;

        if (table[i, j] == 1)
            summ1 = summ1 + 1;

        if (table[i, j] == 2)
            summ2 = summ2 + 1;

        if (table[i, j] == 3)
            summ3 = summ3 + 1;

        if (table[i, j] == 4)
            summ4 = summ4 + 1;

        if (table[i, j] == 5)
            summ5 = summ5 + 1;

        if (table[i, j] == 6)
            summ6 = summ6 + 1;

        if (table[i, j] == 7)
            summ7 = summ7 + 1;

        if (table[i, j] == 8)
            summ8 = summ8 + 1;

        if (table[i, j] == 9)
            summ9 = summ9 + 1;
        
    }
}
Console.WriteLine($"Цифры 0 в массиве {summ0}");
Console.WriteLine();
Console.WriteLine($"Цифры 1 в массиве {summ1}");
Console.WriteLine();
Console.WriteLine($"Цифры 2 в массиве {summ2}");
Console.WriteLine();
Console.WriteLine($"Цифры 3 в массиве {summ3}");
Console.WriteLine();
Console.WriteLine($"Цифры 4 в массиве {summ4}");
Console.WriteLine();
Console.WriteLine($"Цифры 5 в массиве {summ5}");
Console.WriteLine();
Console.WriteLine($"Цифры 6 в массиве {summ6}");
Console.WriteLine();
Console.WriteLine($"Цифры 7 в массиве {summ7}");
Console.WriteLine();
Console.WriteLine($"Цифры 8 в массиве {summ8}");
Console.WriteLine();
Console.WriteLine($"Цифры 9 в массиве {summ9}");
Console.WriteLine();


