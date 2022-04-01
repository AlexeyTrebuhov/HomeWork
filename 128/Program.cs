using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        string path = @"D:\Temp\text.txt";
       
        // Open the file to read from.
        string[] readText = File.ReadAllLines(path, Encoding.UTF8);
        foreach (string s in readText)
        {
            Console.WriteLine(s);
                 
 int [] newarray = new int [5];

       for ( int i = 0; i < s.Length; i ++)
          {
         if (s.Length <= 3)
        newarray[i] = s[i];
         }
        Console.WriteLine (s);
       }
    }

    }

