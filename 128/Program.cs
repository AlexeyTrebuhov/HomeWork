StreamReader f = new StreamReader("test.txt");
while (!f.EndOfStream)
{
    string s = f.ReadLine();
    Console.WriteLine($"{s},");
}
f.Close();