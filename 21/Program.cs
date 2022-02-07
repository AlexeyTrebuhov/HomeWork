// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();

if (string1.Length == 5)
    {   
    
    
    if (string1[0] == string1[4]);
    if (string1[1] == string1[3])
        {
        Console.WriteLine("Это число -  палиндром");}
    
        else
        {
            Console.WriteLine("Это число -  не палиндром");}
    }   
else
    {
       Console.WriteLine(" Введите корректные данные");
    }
    