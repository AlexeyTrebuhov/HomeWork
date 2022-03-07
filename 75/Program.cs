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

int[] data = new int[n];
int[] info = new int[m];
int i = 0;
int j = 0;

Console.Write($"Это массив data");
Console.WriteLine();
for (int count1 = 0; count1 < n; count1++)
    {
        data[count1] = new Random().Next(0, 2);
        Console.Write($"{data[count1]}");
    }
Console.WriteLine();

Console.Write($"Это массив info");
Console.WriteLine();
for (int count2 = 0; count2 < m; count2++)
{
    info[count2] = new Random().Next(0,9);
    Console.Write($"{info[count2]}");
}
Console.WriteLine();

Console.Write($"Это выходные данные в двоичном исчислении");
Console.WriteLine();

for (int count3 = 0; count3 < info.Length; count3++) // сколько цифр нужно создать
{
        for (int count4 = 0; count4 < info[i]; count4++) // наполняем цифру знаками. Количество 
                                                         // знаков = величине индекса i 
        {
            int array = data[j];
            Console.Write(array);
        //Console.Write($"Массив array {array[count4] + " "}");
        
        //string bin = ($"{array[count4]}");
        //int dec = Convert.ToInt32(bin, 2);
        //Console.Write(dec);
        j = j + 1;
        }
    Console.WriteLine();
    //Console.Write(array[count4]);
    //Console.Write($"Массив array {array[table2] + " "}");
    i = i + 1; 
    }
Console.WriteLine();

Console.Write($"Это выходные данные в десятичном исчислении");
Console.WriteLine();


