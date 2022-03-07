// Написать программу вычисления функции Аккермана

Console.Write("Выберите число N и  нажмите клавишу Enter: ");
uint x = uint.Parse(Console.ReadLine());
Console.Write("Выберите число M и  нажмите клавишу Enter: ");
uint y = uint.Parse(Console.ReadLine());

static uint A(uint x, uint m)
{
  if (x == 0)
    return y + 1;
  else
    if ((x != 0) && (y == 0))
      return A(x - 1, 1);
    else
      return A(x - 1, A(x, y - 1));
}