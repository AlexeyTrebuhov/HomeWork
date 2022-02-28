// Найти сумму цифр числа

using System;

int number (int A)
{
if(A<10) return A;
else return A%10+(number(A/10));
}
Console.WriteLine(number(1329));