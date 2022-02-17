// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

using static System.Console;
Console.WriteLine(" ");
Console.Write("Введите значение длины массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());

int[] table = new int[x];

Console.WriteLine();
for (int count = 0; count < x; count++)
{
    table[count] = new Random().Next(-100, 100);
    Console.Write($"{table[count] + " "}");
}
WriteLine(" ");
WriteLine(" ");
WriteLine("Разница между min и max значениями");
WriteLine(" ");

int min = 0;
int max = 0;

for (int i = 0; i < x; i++)
{
    if ( min > table[i])
        min = table[i];

    if ( max < table[i])
        max = table[i];
}

WriteLine($"Min ={min}");
WriteLine($"Max ={max}"); 
WriteLine(" ");  

Console.WriteLine($"Разница равна {max - min}");
WriteLine(" ");
WriteLine(" ");