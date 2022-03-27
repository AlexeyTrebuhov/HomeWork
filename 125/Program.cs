// Работа с выборками

string s1 = "";
for (int i = 0; i < 10_000; i++)
{
    s1 += $"{i}; фио_{i}; День рождения={new Random().Next(1950, 2000)}; Статус={new Random().Next(0, 2)};\n";
}
File.WriteAllText("db1.csv", s1);

string s2 = "";
for (int i = 0; i < 10_000; i++)
{
    s2 += $"{i}; Адрес={i}; Комментарий={new Random().Next(0, 5)};\n";
}
File.WriteAllText("db2.csv", s2);

string s3 = "";
for (int i = 0; i < 10_00; i++)
{
    s3 += $"{i}; Телефон={i}; Уточнение={new Random().Next(11, 15)};\n";
}
File.WriteAllText("db3.csv", s3);