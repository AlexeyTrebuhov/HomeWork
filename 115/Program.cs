// Написать программу возведения числа А в целую стень B

using System;

int method(int A, int B)
{
    if (B==0) return 1;
    else return A + method (A,B-1);      ;
}
Console.WriteLine(method (2,7));