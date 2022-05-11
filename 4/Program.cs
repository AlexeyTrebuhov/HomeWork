// Найти максимальное из трех чисел

using System;

Console.Write("Введите первое число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);

Console.Write("Введите второе число и нажмите клавишу Enter: ");
string string2 = Console.ReadLine();
int arg2 = Convert.ToInt32(string2);

Console.Write("Введите третье число и нажмите клавишу Enter: ");
string string3 = Console.ReadLine();
int arg3 = Convert.ToInt32(string3);

int max = arg1;
if ( arg2 > max ) max = arg2;
if ( arg3 > max ) max = arg3;

Console.WriteLine ("Из этих трех чисел - самое большое, это "); 
Console.WriteLine (max);  