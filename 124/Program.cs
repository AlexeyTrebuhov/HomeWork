// Создание таблиц на 10.000 строк

string s="";
for (int i=0; i<100; i++)
{
    s+=$"{i}; фио_{i}; День рождения={new Random().Next(1950,2000)}; Статус={new Random().Next (0,2)};\n";
}
File.WriteAllText("db.csv",s);