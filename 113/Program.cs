// Показать натуральные числа от M до N, N и M  заданы

string NumberLook(int M, int N)
{
string result = string.Empty;
if ( M==N) return N.ToString();
else return M+" "+NumberLook (M+1,N);
}
Console.WriteLine(NumberLook(10,20));
