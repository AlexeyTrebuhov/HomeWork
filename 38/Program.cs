// Найти сумму чисел одномерного массива стоящих на нечетной позиции

using static System.Console;
///using System.Collections.Generic;

Console.Write("Введите значение длины массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());

int[] table = new int[x];

Console.WriteLine();
    for (int count = 0; count < x; count++)
        {
        table[count] = new Random().Next(0, 100);
        Console.Write($"{table[count] + " "}");
        Console.WriteLine();
        }
    
int sum = 0;

    for (int count1 = 0; count1 < x; count1++)
        {
        if (count1 % 2 > 0)
            sum = sum + 0;
        else
            sum = sum + table[count1];
        }        
Console.WriteLine();
Console.WriteLine($"Сумма цифр массива на нечетной позиции = {sum}");
Console.WriteLine();
        