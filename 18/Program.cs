﻿// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

Console.Write("Укажите значение операнда Х: 1 - если True, 2 - если False  ");
int x1 = int.Parse (Console.ReadLine());
Console.Write("Укажите значение операнда Y: 1 - если True, 2 - если False  ");
int y1 = int.Parse (Console.ReadLine());

bool x, y;
bool b1, b2;
b1 = true;
b2 = false;

    if ( x1 == 1)
        {
        x = b1;
        }    
    if ( x1 ==2 )
        {
        x = b2;
        }
    if ( y1 == 1)
        {
        y = b1;
        }
    if ( y1 ==2 )
        {
        y = b2;
        }

 bool c = !( x | y );
 bool e = !x && !y;

    if ( c == e)
    {
        Console.WriteLine ("Это выражение имеет значение True");
    }
    else
        Console.WriteLine ("Это выражение имеет значение Else.");
