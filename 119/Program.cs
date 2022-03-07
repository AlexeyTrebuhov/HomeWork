int a, b, N, z;

List<string> temp = new List<string>(Console.ReadLine().Split(' '));
var s = new Random();

if (int.TryParse(temp[0], out a) &
    int.TryParse(temp[1], out b) &
    int.TryParse(temp[2], out N))
{
    temp.Clear();
    for (var i = N; i > 0; --i)
    {
        z = s.Next(a, b);
        int[] q = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        temp.Add(z.ToString());
    }
}

Console.WriteLine(string.Join(" ", temp));