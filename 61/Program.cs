// Найти произведение двух матриц.


using System;

        Console.Write("Введите значение длины для первой матрицы (это же значение будет");
        Console.Write("являться высотой второй матрицы ) и нажмите клавишу Enter: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите значение высоты для первой матрицы и нажмите клавишу Enter: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Введите значение ширины для второй матрицы и нажмите клавишу Enter: ");
        int z = int.Parse(Console.ReadLine());

        int[,] mas1 = new int[x, y];
        int[,] mas2 = new int[z, x];
        int[,] mas3 = new int[z, y];
        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Массив MAS1");
        Console.WriteLine();

        for (int i = 0; i < x; i++)
                {
                 for (int j = 0; j < y; j++)
                    {
                     mas1[i, j] = new Random().Next(1, 9);
                     Console.Write($"{mas1[i, j] + "  "}");
                    }
                    Console.WriteLine();
                }
        Console.WriteLine();
        Console.WriteLine("Массив MAS2");
        Console.WriteLine();
            
    
            for (int i = 0; i < z; i++)
                {
                    for (int j = 0; j < x; j++)
                        {
                            mas2[i, j] = new Random().Next(1, 9);
                            Console.Write($"{mas2[i, j] + "  "}");
                        }
                        Console.WriteLine();
                }
      
            Console.WriteLine();
            Console.WriteLine("Массив MAS3");
            Console.WriteLine();

            for (var i = 0; i < z; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    mas3[i, j] = 0;

                    for (var k = 0; k < z; k++)
                    {
                        mas3[i, j] = mas2[i, k] * mas1[k, j];
                        Console.Write($"{mas3[i, j] + "  "}");
                    }
                    Console.WriteLine();
                }
            }



