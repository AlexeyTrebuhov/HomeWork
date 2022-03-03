// Напишите программу, которая на вход принимает два числа и 
//выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.

using System;

Console.Write("Введите первое число и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите число N и нажмите клавишу Enter: ");
int n = int.Parse(Console.ReadLine());

int sum1 = 0;
int sum2 = 0;
int count = 0;
int temp1 = x;
int temp2 = y;

for ( int i = 0; i < n; i++)
    {
        sum1 = temp1 + temp2;
        temp1 = sum1;
        count = count + 1;
        //if ( count == n)
        //{
       // Console.WriteLine(sum1);
        //}

        sum2 = temp1 + temp2;
        temp2 = sum2;
        count = count + 1;
        //if ( count == n)
       // {
        //Console.WriteLine(sum2);
        //}
    Console.WriteLine(sum1);
    Console.WriteLine(sum2);
            
    }

