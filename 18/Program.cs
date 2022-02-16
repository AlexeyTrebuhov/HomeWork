// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


using System;
class Program
{
    static void Main(string[] arg)
    {
        bool x, y;
        bool b1 = true;
        bool b2 = false;
        x = false;
        y = false;
        ///bool no = false;
        ///bool yes = true;
        
        Console.Write("Укажите значение операнда Х: 1 - если True, 2 - если False  ");
        int x1 = int.Parse (Console.ReadLine());
        Console.Write("Укажите значение операнда Y: 1 - если True, 2 - если False  ");
        int y1 = int.Parse (Console.ReadLine());

    if ( x1 == 1)
        {
        x = b1;
        }    
    if ( x1 == 2 )
        {
        x = b2;
        }
    if ( y1 == 1)
        {
        y = b1;
        }
    if ( y1 == 2 )
        {
        y = b2;
        }
        
    
        ///Console.WriteLine (! ( x | y ) == !x && !y);
    } 
}
