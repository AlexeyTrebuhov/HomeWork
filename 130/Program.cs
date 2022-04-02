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
            StreamReader sr = new StreamReader("text.txt");

            while (sr.EndOfStream != true)
            {
                s += sr.ReadLine();
            }
            textMass = s.Split(' ');
            Console.WriteLine();

            Console.WriteLine("Это исходный массив строк, полученный из текстового файла");
            Console.WriteLine();

            int count = 0;
            string mini = "";

            for (int i = 0; i < textMass.Length; i++)
            {
                if (textMass[i].Length < 4)
                {
                    count = count + 1;
                }
                if (textMass[i].Length < 4)
                {
                    mini = String.Concat(mini, " , ");
                    mini = String.Concat(mini, textMass[i]);
                }

                Console.WriteLine(textMass[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Количество строк с тремя символами и меньше = {count}");
            Console.WriteLine();
            Console.WriteLine("Это обработанный массив строк");
            Console.WriteLine();        
            Console.WriteLine(mini);
            Console.WriteLine();
        }
    }
}
