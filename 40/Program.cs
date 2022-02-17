// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

using static System.Console;
Console.WriteLine(" ");
Console.Write("Введите значение длины массива и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());

double[] table = new double[x];

Console.WriteLine();
for (int count = 0; count < x; count++)
    {
    table[count] = new Random ().Next(-100,100);
    Console.Write("{0,6:F2}",table[count]);
    }
WriteLine(" ");
WriteLine(" ");
WriteLine("Разница между min и max значениями");
WriteLine(" ");

double min = 0;
double max = 0;

for (int i = 0; i < x; i++)
{
    if (min > table[i])
        min = table[i];

    if (max < table[i])
        max = table[i];
}

WriteLine($"Min ={min}");
WriteLine($"Max ={max}"); 
WriteLine(" ");  

Console.WriteLine($"Разница равна {max - min}");
WriteLine(" ");
WriteLine(" ");