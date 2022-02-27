// Конвертация из десятичной системы счисления в другие

using static System.Console;
using System.Linq;

DidSys[] didSyss = new DidSys[16]
{
    new DidSys(){num =0,val= "0"},
    new DidSys(){num =1,val="1"},
    new DidSys(){num =2,val="2"},
    new DidSys(){num =3,val="3"},
    new DidSys(){num =4,val="4"},
    new DidSys(){num =5,val="5"},
    new DidSys(){num =6,val="6"},
    new DidSys(){num =7,val="7"},
    new DidSys(){num =8,val="8"},
    new DidSys(){num =9,val="9"},
    new DidSys(){num =10,val="A"},
    new DidSys(){num =11,val="B"},
    new DidSys(){num =12,val="C"},
    new DidSys(){num =13,val="D"},
    new DidSys(){num =14,val="E"},
    new DidSys(){num =15,val="F"}

};

WriteLine("Введите основание системы");
int n = int.Parse(ReadLine());
WriteLine("Введите число");
int num = int.Parse(ReadLine());
string result = string.Empty;
while (num >= n)
{
    result = didSyss.First(x => x.num == num % n).val + result;
    num /= n;
}
result = didSyss.First(x => x.num == num).val + result;
WriteLine(result);

struct DidSys
{
    public int num;
    public string val;
}