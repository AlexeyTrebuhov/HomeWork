Console.Write("Введите любое целое проверяемое число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);

Console.Write("Введите любое целое предположительно кратное число и нажмите клавишу Enter: ");
string string2 = Console.ReadLine();
int arg2 = Convert.ToInt32(string1);

if ( arg1%arg2== 0 )
{
Console.WriteLine (arg1);  
Console.WriteLine (" Это число кратно ");
Console.WriteLine (arg2);}

else
{
Console.WriteLine (arg1);  
Console.WriteLine (" Это число не кратно");
Console.WriteLine (arg2);}
