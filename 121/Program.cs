// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
   public static void Main(string[] args)
{
    int i = 4; // это задаем степень числа 2 ( прописываем двузначное число)
   
        string sBynary = string.Join("", Enumerable.Range(0, 9) // 0-9 - Это длина числа в двоичной системе
            .Select((v, p) => p + 1 == i || p + 1 == 1 - i - 1 ? '1' : '0'));
        Console.WriteLine("{0} десятичное = {1} ", sBynary, Convert.ToInt32(sBynary, 2));
   
    Console.ReadKey();
}
}