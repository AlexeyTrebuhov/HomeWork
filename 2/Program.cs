Console.Write("Введите первое число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);

Console.Write("Введите второе число и нажмите клавишу Enter: ");
string string2 = Console.ReadLine();
int arg2 = Convert.ToInt32(string2);
int result = arg1 - arg2;

    if (result == 0)
    {
    Console.Write(" Числа ");
    Console.Write(arg1);
    Console.Write(" и ");
    Console.Write(arg2);
    Console.Write(" одинаковые. Не морочьте людям голову");}
            
    else if (result > 0)
    {
    Console.Write(arg1);
    Console.Write("- большее число ");
    Console.Write(arg2);
    Console.Write("- меньшее число");}
    
    else 
    { 
    Console.Write(arg2);
    Console.Write("- большее число ");
    Console.Write(arg1);
    Console.Write("- меньшее число");}