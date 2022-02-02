Console.Write("Введите любое целое число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);

if ( arg1 % 2 == 0 )
{
Console.WriteLine (arg1);  
Console.WriteLine (" Это число четное");}

else
{
Console.WriteLine (arg1);  
Console.WriteLine (" Это число четное. Не очень  (Борат)");}