//Есть два массива info и data.
//Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
//Числа идут друг за другом без разделителей.
//Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
//Составить массив десятичных представлений чисел массива data с учётом информации 
//из массива info.

using System;

Console.WriteLine();
Console.Write("Введите длинну массива data ( лучше больше 50)  и  нажмите клавишу Enter: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите длинну массива info ( лучше от 3 до 7) и  нажмите клавишу Enter: ");
int m = int.Parse(Console.ReadLine());

int[] data = new int[n];
int[] info = new int[m];
int i = 0;
int j = 0;
int temp = 0;
string str = "";

Console.WriteLine();
Console.Write($"Это массив data");
Console.WriteLine();

for (int count1 = 0; count1 < n; count1++)
{
    data[count1] = new Random().Next(0,2); // задаем цифры, которые могут составить число в 2-зн. системе
    Console.Write($"{data[count1]}");
}
Console.WriteLine();
Console.WriteLine();
Console.Write($"Это массив info");
Console.WriteLine();

for (int count2 = 0; count2 < m; count2++)
{
    info[count2] = new Random().Next(1,15); // задаем min и max длину числа в двузначном счислении 
    Console.Write($"{info[count2]}");
}
Console.WriteLine();
Console.WriteLine();

for (int count3 = 0; count3 < info.Length; count3++) // сколько чисел нужно ( можно по факту) создать
{
    str = "";
    for (int count4 = 0; count4 < info[i]; count4++) // наполняем каждое новое число знаками. Количество 
                                                     // знаков = величине индекса i массива info
        {
        int array = data[j];
        str = str.Insert(0,$"{array}");
        j = j + 1;
        }
                                    // Строка str получилась задом наперед. Нужно развернуть 

    char[] str1 = str.ToCharArray(); 
    Array.Reverse(str1);
    ///Console.Write(str1);            // str1 - это развернутая строка str

    string txt = new string (str1); // тип char переводим в тип string. Получили число в двоичной
    ///Console.Write (txt);            // системе

    string bin = $"{txt}";        // в этом блоке конвертируем из двоичной системы в десятеричную
    Console.Write($"двоичное число - ");
    Console.Write(bin);
    int dec = Convert.ToInt32(bin, 2);
    Console.Write($", десятичное число - ");
    Console.WriteLine(dec);
    Console.WriteLine();
    
    i = i + 1;
}
//Console.WriteLine();


