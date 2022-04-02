/*var A = new System.Collections.Generic.List<string>()
{
    "BF","C", "BA", "A", "IFD4", "I1989IGOR", "AGOR1989", "P1989PETRO", "PETRO1989", "S1989SERGEY", "SERGEY1989",
        "A1989ANNA","ANNA1989", "TERAB1989", "T1989TERAB"
};

int L = 9;

var resultList = A.TakeWhile(x => x.Length <= L);
//.Where(str => Char.IsLetter(str.Last()))
//.OrderByDescending(str => str.Length)
// .ThenBy(str => str)
// .ToList();

foreach (var x in resultList)
{
    Console.WriteLine(x);
}
*/

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
                 
 /*int [] array1 = new Random(5);

       for ( int i = 0; i < s.Length; i ++)
          {
         if (s.Length <= 3)
        array1[i] = s[i];
         }
        Console.WriteLine (array1);
        */
       }
    }

    }
    

