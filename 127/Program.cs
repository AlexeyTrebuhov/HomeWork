// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

using static System.Console;

int[] table = new int[999];
Console.WriteLine();
Console.WriteLine("Это исходный массив чисел");
for (int count = 0; count < 999; count++)
{
        table[count] = new Random().Next(0,9999);

        Console.Write($"{table[count]} ");
        //Console.WriteLine();
} 
    
Console.WriteLine();
//ReadLine();
