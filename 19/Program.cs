/// о двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите любое целое проверяемое число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);

Console.Write("Введите любое целое предположительно кратное число и нажмите клавишу Enter: ");
string string2 = Console.ReadLine();
int arg2 = Convert.ToInt32(string2);

if (arg1 < arg2)
    {
        if ( arg1*arg1 == arg2 )
        {
        Console.WriteLine (arg2);  
        Console.WriteLine (" Это число является квадратом ");
        Console.WriteLine (arg1);}
        else
        Console.WriteLine (arg2);  
        Console.WriteLine (" Это число не является квадратом");
        Console.WriteLine (arg1);
        }
                
 if  (arg1 > arg2)
        if ( arg2*arg2 == arg1 )
        {
        Console.WriteLine (arg1);  
        Console.WriteLine (" Это число является квадратом ");
        Console.WriteLine (arg2);}
        else
        Console.WriteLine (arg1);  
        Console.WriteLine (" Это число не является квадратом");
        Console.WriteLine (arg2);
        
       