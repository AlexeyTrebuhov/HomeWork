// Найти третью цифру числа или сообщить, что её нет.

Console.Write("Введите любое число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);

if ((arg1 + 100 ) / 100 > 1)
    {
    Console.WriteLine ("Третья цифра данного числа - это");
    Console.WriteLine(string1[2]);
    }
    
else
{
Console.WriteLine (" В этом числе нет третьей цифры");}