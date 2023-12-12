string input = Console.ReadLine();
string result = "";
foreach (char c in input)
{
    if ("AEIOUaeiou".Contains(c))
    {
        continue;
    }
    result += c;
}
Console.WriteLine(result);