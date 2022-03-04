//В указанном диапазоне, вывести все взаимнопростые числа заданному числу

using System;

Console.Write("Введите начальное значение диапазона и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите конечное число диапзона и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите число N и нажмите клавишу Enter: ");
int n = int.Parse(Console.ReadLine());

if ( n % 2 == 0)
{
    for ( int i =x; i < y; i++)
    {
        if ( i % 2 > 0)
        { 
         Console.WriteLine(i);
       }
       
    }
}
if (n % 3 == 0)
{
    for (int i = x; i < y; i++)
    {
        if (i % 3 > 0)
        {
            Console.WriteLine(i);
        }

    }
}
if (n % 5 == 0)
{
    for (int i = x; i < y; i++)
    {
        if (i % 5 > 0)
        {
            Console.WriteLine(i);
        }

    }
}
if (n % 7 == 0)
{
    for (int i = x; i < y; i++)
    {
        if (i % 7 > 0)
        {
            Console.WriteLine(i);
        }

    }
}