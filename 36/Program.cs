// Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных\четных чисел

using static System.Console;
using System.Collections.Generic;

Console.Write("Введите значение высоты массива и нажмите клавишу Enter: ");
int x = int.Parse (Console.ReadLine());
Console.Write("Введите значение ширины массива и нажмите клавишу Enter: ");
int y = int.Parse (Console.ReadLine());

int[,] table = new int [x,y];

Console.WriteLine();
for (int count = 0; count <x; count++)
{
    for (int count1 = 0; count1 <y; count1++)
    {   
    table [count,count1] = new Random().Next(99,1000);
    
    Console.Write($"{table[count,count1]+" "}");
    }
    Console.WriteLine();
}
Console.WriteLine();

int i = 0;
int j = 0; 
int summ = 0;
int summ1 = 0;

for ( i = 0; i < x; i++ )
    {
        for ( j = 0; j < y; j++ )
        {
            if (table[i,j] % 2 > 0)

                summ = summ + 1; 
            else
                summ1 = summ1 + 1;
        }
    }
    Console.WriteLine($"Четных чисел в массиве {summ1}");
    Console.WriteLine();
    Console.WriteLine($"Нечетных чисел в массиве {summ}");
    Console.WriteLine();
        
      
    


