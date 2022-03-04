///Элементы массива уменьшить на 20, умножить на последний элемент и 
///увеличить на число В

Console.Write("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
int[] a = new int[3];
Random r = new Random();
for (int i = 0; i < a.Length; i++)
{
    a[i] = r.Next(-10, 10);
    Console.WriteLine(a[i]);
}
int last = a[a.Length - 1];
Console.WriteLine("Новый массив");
for (int i = 0; i < a.Length; i++)
{
    a[i] -= 20;
    a[i] *= last;
    a[i] += b;
    Console.WriteLine(a[i]);
}
Console.ReadKey();