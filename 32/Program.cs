// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

using static System.Console;

int[,] table = new int [2,4];

Console.WriteLine();
for (int count = 0; count <2; count++)
{
    for (int count1 = 0; count1 <4; count1++)
    {   
    table [count,count1] = new Random().Next(0,2);
    
    Console.Write($"{table[count,count1]}");
    }
    Console.WriteLine();
    }
Console.WriteLine();

