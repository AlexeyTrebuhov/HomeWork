// Написать программу замену элементов массива на противоположные

using static System.Console;
Console.WriteLine(" ");
Console.Write("Введите значение длины массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());

int[] table = new int[x];

Console.WriteLine();
for (int count = 0; count < x; count++)
    {
    table[count] = new Random().Next(0, 100);
    Console.Write($"{table[count] + " "}");
    }
WriteLine(" ");
WriteLine(" ");
WriteLine("Массив с противоположными знаками");
WriteLine(" ");
    int z = 0;
    for (int i = 0; i < x; i++)
    {
    z = 0 - table[i];
    table[i] = z;

    Console.Write($"{table[i] + " "}");
    }
WriteLine(" ");
WriteLine(" ");