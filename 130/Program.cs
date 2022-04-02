// Задача контрольная

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
 
namespace wordscount
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string[] textMass;
            StreamReader sr = new StreamReader(@"D:\Temp\text.txt");

            while (sr.EndOfStream != true)
            {
                s += sr.ReadLine();
            }
            textMass = s.Split(' ');
        
for ( int i = 0; i < textMass.Length; i++)
{
    Console.WriteLine (textMass[i]);
}
            Console.WriteLine(textMass.Length);

            sr.Close();
            Console.ReadLine();
        }
    }
}