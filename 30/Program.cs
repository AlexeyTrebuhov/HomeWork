// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число больше ноля и  нажмите клавишу Enter: ");
double N = double.Parse (Console.ReadLine());
double z = -1;

for ( int i = 1; i <= N; i++ )
z = i*i*i;

if ( z % 2 == 0 )
{
Console.WriteLine (" Это число четное");
Console.WriteLine (z);}

else
{
Console.WriteLine (" Это число нечетное. Попробуйте еще раз");
}