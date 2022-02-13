// Подсчитать сумму цифр в числе

class Program
   {
      static void Main(string[] args)
      {
      Console.WriteLine("Введите целое число:");
      var s = Console.ReadLine();
      int i = 0; 
      int count = s.Length; 
      int sum = 0;
      {
           
            while (i < count)
            {
                if (char.IsDigit(s[i]))
                   sum += s[i++];
            }
            Console.WriteLine(sum);
 
        }
    }
 }

