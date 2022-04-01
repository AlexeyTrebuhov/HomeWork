var A = new System.Collections.Generic.List<string>()
{
    "BF","C", "BA", "A", "IFD4", "I1989IGOR", "AGOR1989", "P1989PETRO", "PETRO1989", "S1989SERGEY", "SERGEY1989",
        "A1989ANNA","ANNA1989", "TERAB1989", "T1989TERAB"
};

int L = 10;

var resultList = A.TakeWhile(x => x.Length <= L)
    .Where(str => Char.IsLetter(str.Last()))
    .OrderByDescending(str => str.Length)
    .ThenBy(str => str)
    .ToList();

foreach (var x in resultList)
{
    Console.WriteLine(x);
}