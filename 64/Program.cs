// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.

Console.Write("Выберите число N и  нажмите клавишу Enter: ");
int str1 = int.Parse(Console.ReadLine());
Console.Write("Выберите число M и  нажмите клавишу Enter: ");
int str2 = int.Parse(Console.ReadLine());

string NumberLook(int str2, int str1)
{
    string result = string.Empty;
    if (str2 == str1) return str1.ToString();
    else return str2 + " " + NumberLook(str2 + 1, str1);
}
Console.WriteLine(NumberLook(str1, str2));
