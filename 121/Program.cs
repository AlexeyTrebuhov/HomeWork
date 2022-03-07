// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
   public static void Main(string[] args)
{
    int n = 10;
    for (int i = 0; i < n; i++)
    {
        string sBynary = string.Join("", Enumerable.Range(0, 3)
            .Select((v, p) => p + 1 == i || p + 1 == n - i - 1 ? '1' : '0'));
        Console.WriteLine("{0} десятичное = {1} ", sBynary, Convert.ToInt32(sBynary, 2));
    }
    Console.ReadKey();
}
}