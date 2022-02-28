/// Показать натуральные числа от 1 до N, N задано
string NumberLook (int n)
{

string result = string.Empty;
if ( n ==1) return result+n;
else return NumberLook (n-1) + n + " ";
}
Console .WriteLine (NumberLook(10));
