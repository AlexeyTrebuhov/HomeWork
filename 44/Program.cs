/// Найти точку пересечения двух прямых заданных уравнением 
///y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы

using System;
using System.Threading;
class Sample
{
    public static void Main()
    {


double x = 0;
double y = 0;


        Console.WriteLine("Введите переменную b1");
        double b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите переменную k1");
        double k1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите переменную b2");
        double b2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите переменную k2");
        double k2 = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
       
        Console.WriteLine ("Для формул y=k1*x1 = b1  и y=k2*x2 + b2 ");
        Console.WriteLine("точка пересечения будет иметь координаты");
        Console.WriteLine ($" х равно {x}, y равно {y}");



        



    }}