// Возведите число А в натуральную степень B используя цикл

using static System. Console;

Console.Write("Введите число A и нажмите клавишу Enter: ");
double A = int.Parse(ReadLine());
Console.Write("Введите степень числа А и нажмите клавишу Enter: ");
double B = int.Parse(ReadLine());

double s = 1;

for (int i = 1; i <=B; i++)
{
    s = s * A;
}

WriteLine($"{s}");
