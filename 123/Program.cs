// Переворот строки

///Console.WriteLine(new string("Hello world!".ToCharArray().Reverse().ToArray()));
/// второй вариант ниже



    Console.WriteLine("Введите значение");
    string s = Console.ReadLine();
    char[] str = s.ToCharArray();
    Array.Reverse(str);
    Console.Write(str);
    Console.ReadKey();
