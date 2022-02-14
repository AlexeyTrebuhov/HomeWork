// Подсчитать сумму цифр в числе

Console.Write("Введите любое число и нажмите клавишу Enter: ");
double N = double.Parse (Console.ReadLine());

double summ = 0;
double x = 0;
double i=0;

for ( i=0; i <=N; i++)
{
   x = N % 10;
   summ = summ + x;
   N = (N - x) / 10;
}

Console.WriteLine ( summ);