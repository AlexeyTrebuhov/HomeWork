// Проверка, является ли номер автомобильным знаком
// нужно создать файл unput

using System.IO;
using System;
using System.Linq;

StreamReader sr = new StreamReader("input");
int yes = 0;
int i = 0;
string chars = "0123456789ABCEHKMOPTXYАВСЕНКМОРТХУ";
while (!sr.EndOfStream)
{
    string number = sr.ReadLine();
    if ((chars.IndexOf(number[0]) > 9)
    && (chars.IndexOf(number[1]) < 9)
    && (chars.IndexOf(number[2]) < 9)
    && (chars.IndexOf(number[2]) >= 0)
    && (chars.IndexOf(number[3]) < 9)
    && (chars.IndexOf(number[3]) >= 0)
    && (chars.IndexOf(number[4]) > 9)
    && (chars.IndexOf(number[4]) >= 0)
    && (chars.IndexOf(number[5]) > 9)
    ) yes++;
    i++;
}

Console.WriteLine($"{yes}  {i - yes}");

// Сравниваются номера из файла input на поиндексовое
// совпадение со знаками в string char
// но работает криво. нужно допилить