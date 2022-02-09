// Найти расстояние между точками в пространстве 2D/3D

using static System.Console;

Console.Write("Выберите пространство 2D (цифра 2 ) или 3D (цифра 3)  и  нажмите клавишу Enter: ");
int str = int.Parse (Console.ReadLine());
int N = Convert.ToInt32(str);

if ( N == 1)
    {
    Console.WriteLine("Это прямая линия. Расстояние между точками - отрезок. Длину отрезка найти не сложно");
    }

if ( N == 2)
    {
    Console.WriteLine(" Введите координату X для точки 1 и нажмите Enter");
    string x01 = Console.ReadLine ();
    int x1 = int.Parse (x01);
    
    Console.WriteLine(" Введите координату Y для точки 1 и нажмите Enter");
    string y01 = Console.ReadLine ();
    int y1 = int.Parse (y01);

    Console.WriteLine(" Введите координату X для точки 2 и нажмите Enter");
    string x02 = Console.ReadLine ();
    int x2 = int.Parse (x02);
      
    Console.WriteLine(" Введите координату Y для точки 2 и нажмите Enter");
    string y02 = Console.ReadLine ();
    int y2 = int.Parse (y02);
            
    int x = (x1 - x2) * (x1 - x2);
    int y = (y1 - y2) * (y1 - y2);
    int h = x + y;
    var c = Math.Sqrt (h);
 
     Console.WriteLine($" расстояние между точками по прямой составит {c}");   
     }
   
if ( N == 3)
    {
    Console.WriteLine(" Введите координату X для точки 1 и нажмите Enter");
    string x01 = Console.ReadLine ();
    int x1 = int.Parse (x01);
    
    Console.WriteLine(" Введите координату Y для точки 1 и нажмите Enter");
    string y01 = Console.ReadLine ();
    int y1 = int.Parse (y01);

    Console.WriteLine(" Введите координату Z для точки 1 и нажмите Enter");
    string z01 = Console.ReadLine ();
    int z1 = int.Parse (z01);

    Console.WriteLine(" Введите координату X для точки 2 и нажмите Enter");
    string x02 = Console.ReadLine ();
    int x2 = int.Parse (x02);
      
    Console.WriteLine(" Введите координату Y для точки 2 и нажмите Enter");
    string y02 = Console.ReadLine ();
    int y2 = int.Parse (y02);

    Console.WriteLine(" Введите координату Z для точки 2 и нажмите Enter");
    string z02 = Console.ReadLine ();
    int z2 = int.Parse (z02);
            
    int x = (x1 -x2) * (x1 - x2);
    int y = (y1 -y2) * (y1 - y2);
    int h = x + y;
    int f = (z1 - z2) * (z1 - z2);
    int d = h + f;

    var c = Math.Sqrt (d);

 
     Console.WriteLine($" расстояние между точками по прямой составит {c}");   
     }

if ( N > 3)
    {
    Console.WriteLine("Теория струн и многомерного пространства будет рассмотрена позже");
    }

return;