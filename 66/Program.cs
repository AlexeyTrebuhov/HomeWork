// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

Console.Write("Выберите число N и  нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Выберите число M и  нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());

int sum(int x, int y)
{
    return x == y ? y : x + sum(x + 1, y);
}
Console.WriteLine (sum (x , y));


