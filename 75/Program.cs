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
int i = 0;
int j = 0;

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
    table2[count2] = new Random().Next(0,9);
    Console.Write($"{table2[count2]}");
}
Console.WriteLine();

Console.Write($"Это выходные данные в двоичном исчислении");
Console.WriteLine();

for (int count3 = 0; count3 < table2.Length; count3++) 
    {    
        for (int count4 = 0; count4 < table2[i]; count4++)
        {
        Console.Write(table1[j]);

        /*int k = table1[j]; // это задаем степень числа 2 ( прописыва ем двузначное число)
        string sBynary = string.Join("", Enumerable.Range(0, table2[i]) // 0-9 - Это длина числа 
        .Select((v, p) => p + 1 == k || p + 1 == 1 - k - 1 ? '1' : '0'));
        Console.WriteLine("{0} десятичное = {1} ", sBynary, Convert.ToInt32(sBynary, 2));
        */
        j = j + 1;
        }
    Console.WriteLine();
    i = i + 1; 
    }
Console.WriteLine();

Console.Write($"Это выходные данные в десятичном исчислении");
Console.WriteLine();


