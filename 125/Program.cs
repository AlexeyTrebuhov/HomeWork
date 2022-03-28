// Работа с выборками

string s1 = "";
for (int i = 1; i < 101; i++)
{
    s1 += $"{i}; фио_{i}; {new Random().Next(1950, 2000)}; {new Random().Next(0, 2)};\n";
}
File.WriteAllText("db1.csv", s1);

string s2 = "";
for (int i = 1; i < 301; i++)
{
    s2 += $"{i}; {new Random().Next(1, 101)};Адрес={new Random().Next(1, 10)}; Комментарий={new Random().Next(0, 5)};\n";
}
File.WriteAllText("db2.csv", s2);

string s3 = "";
for (int i = 1; i < 501; i++)
{
    s3 += $"{i}; id={new Random().Next(1, 101)}; Телефон={new Random().Next(1, 180)}; Уточнение={new Random().Next(11, 15)};\n";
}
File.WriteAllText("db3.csv", s3);