// Выяснить являются ли три числа сторонами треугольника

Console.Write("Введите размер первой стороны и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);

Console.Write("Введите размер второй стороны и нажмите клавишу Enter: ");
string string2 = Console.ReadLine();
int arg2 = Convert.ToInt32(string2);

Console.Write("Введите размер третьей стороны и нажмите клавишу Enter: ");
string string3 = Console.ReadLine();
int arg3 = Convert.ToInt32(string3);

int min = 0;
int max = 0;

if (arg1 > max) max = arg1;
if (arg2 > max) max = arg2;
if (arg3 > max) max = arg3;

if (arg1 < min) min = arg1;
if (arg2 < min) min = arg2;
if (arg3 < min) min = arg3;

int sum = arg1 + arg2 + arg3;
int x = sum - max - min;


if ((x + min) > max)
{
    Console.WriteLine();
    Console.WriteLine("Размеры этих отрезков позволяют собрать треугольник");
    Console.WriteLine();
}

else
{
    Console.WriteLine();
    Console.WriteLine("Нужно напилить доски другого размера");
    Console.WriteLine();
}

