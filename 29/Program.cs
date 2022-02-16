// Написать программу вычисления произведения чисел от 1 до N

// Найти кубы чисел от 1 до N

Console.Write("Введите число больше ноля и  нажмите клавишу Enter: ");
int N = int.Parse (Console.ReadLine());

for ( int i = 1; i <= N; i++ )
b = i * (i+1);
i = b;

Console.WriteLine ( i*i*i);
