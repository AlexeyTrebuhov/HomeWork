//Есть два массива info и data.
//Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
//Числа идут друг за другом без разделителей.
//Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
//Составить массив десятичных представлений чисел массива data с учётом информации 
//из массива info.

using System;

Console.WriteLine();
Console.Write("Введите длинну массива data и  нажмите клавишу Enter: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите длинну массива info и  нажмите клавишу Enter: ");
int m = int.Parse(Console.ReadLine());

int[] table1 = new int[n];
int[] table2 = new int[m];

Console.Write($"Это массив data");
Console.WriteLine();
for (int count1 = 0; count1 < n; count1++)
    {
        table1[count1] = new Random().Next(0, 2);
        Console.Write($"{table1[count1]}");
    }
Console.WriteLine();

Console.Write($"Это массив info");
Console.WriteLine();
for (int count2 = 0; count2 < m; count2++)
{
    table2[count2] = new Random().Next(0, 2);
    Console.Write($"{table2[count2]}");
}
Console.WriteLine();

Console.Write($"Это выходные данные в двоичном исчислении");
Console.WriteLine();
Console.Write($"{table2[0]}");


/*// Показать вторую цифру трёхзначного числа.

Console.Write("Введите трехзначное число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);
Console.WriteLine("Вторая цифра данного числа - это");
Console.WriteLine(string1[1]);

// Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);
Console.WriteLine("Если удалить вторую цифру, получится число");
Console.WriteLine(string1.Remove(1, 1));
*/