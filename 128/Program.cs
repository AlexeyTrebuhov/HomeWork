using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        string path = @"D:\Temp\text.txt";

        string[] readText = File.ReadAllLines(path, Encoding.UTF8);
        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }

    }
}
