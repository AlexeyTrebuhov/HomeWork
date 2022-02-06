// Показать вторую цифру трёхзначного числа.

Console.Write("Введите трехзначное число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);


Console.WriteLine ("Вторая цифра данного числа - это");
Console.WriteLine(string1[1]);
