// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
    private static void Main(string[] args)
    {

        int n = 10;
        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("{0} десятичное = {1} ", Convert.ToString(i, 2).PadLeft(8, '0'), i);
        }
        Console.ReadKey();

    }
}
