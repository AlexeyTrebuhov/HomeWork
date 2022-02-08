// Задать номер четверти, показать диапазоны.

Console.Write("Введите число от 1 до 4 и нажмите клавишу Enter: ");
int string1 = int.Parse (Console.ReadLine());

if ( string1 < 5  && string1 > 0)
    {   
    if ( string1 == 1)
        {
        Console.WriteLine("Для I  четверти диапазон координат:");
        Console.WriteLine("для Х : [0 + oo");
        Console.WriteLine("для Y : [0 + oo");}
        
        
    if ( string1 == 2)
        {
        Console.WriteLine("Для II  четверти диапазон координат:");
        Console.WriteLine("для Х : [0 - oo ");
        Console.WriteLine("для Y : [0 + oo ");}

    if ( string1 == 3)
        {
        Console.WriteLine("Для III  четверти диапазон координат:");
        Console.WriteLine("для Х : [0 - oo ");
        Console.WriteLine("для Y : [0 - oo ");}

    if ( string1 == 4)
        {
        Console.WriteLine("Для IV  четверти диапазон координат:");
        Console.WriteLine("для Х : [0 + oo ");
        Console.WriteLine("для Y : [0 - oo ");}
        }   
else
    {
       Console.WriteLine(" Такой четверти не бывает");
    }
    