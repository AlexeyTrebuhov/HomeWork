// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите любое число от 1 до 7 и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);

if (arg1 < 8)
{
if (arg1 == 1)
    Console.WriteLine ("Это совсем не выходной. Это понедельник");
if (arg1 == 2)
    Console.WriteLine ("Это не похоже на выходной. Это вторник");
if (arg1 == 3)
    Console.WriteLine ("Выходной где-то рядом, но это только среда"); 
if (arg1 == 4)
    Console.WriteLine ("Выходной уже близко, это уже четверг"); 
if (arg1 == 5)
    Console.WriteLine ("Это почти выходной. Это пятница"); 
if (arg1 == 6)
    Console.WriteLine ("Это выходной. Суббота"); 
if (arg1 == 7)
    Console.WriteLine ("Это выходной. Воскресенье"); 
}

else
Console.WriteLine ("Этот день недели - 32 мартобря. Ученые еще не решили. к какому типу относится этот день");