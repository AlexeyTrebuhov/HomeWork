// Создание таблиц на 10.000 строк

string s="";
for (int i=0; i<10; i++)
{
    s+=$"{i}; фио_{i}; Мама={new Random().Next(10)}; Папа={new Random().Next (11,22)};\n";
}
File.WriteAllText("db.csv",s);