///Определить сколько чисел больше 0 введено с клавиатуры

using System;
using System.Threading;
class Sample
{
public static void Main()
{

string userString = ""; 
int summ = 0;
Console.WriteLine("Для расчета введите число, выхода - букву");

        do
        {
            
            userString = Console.ReadLine();
            double arg = Convert.ToDouble(userString);
                if (arg * arg >= 0) 
                {
                if (arg > 0)
                    summ = summ + 1;
                if (arg <= 0)
                    summ = summ;

                Console.WriteLine($"Чисел больше ноля введено {summ}");
                }
          }
        while (userString != "asd");
}
}