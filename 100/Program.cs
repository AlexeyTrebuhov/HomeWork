// Проверка совпадения букв в двух массивах

using System.IO;
using System;
using System.Linq;

StreamReader sr = new StreamReader("input");
string[] names = sr.ReadLine().Split(" ");
int [] name1 = names[0].ToString().ToLower().Select(x => Convert.ToInt32((byte)x)).OrderBy(x => x).ToArray();
int [] name2 = names[1].ToString().ToLower().Select(x => Convert.ToInt32((byte)x)).OrderBy(x => x).ToArray();
Console.WriteLine(name1);
Console.WriteLine(name2);
if (name1.Count() != name2.Length)
{
    Console.WriteLine("No1");
    return;
}

for (int i=0; i < name1.Count();  i++)
{
    if (name1[i] != name2[i])
    {
    Console.WriteLine("No2");
    return;
    }
}

 Console.WriteLine("Yes!");
