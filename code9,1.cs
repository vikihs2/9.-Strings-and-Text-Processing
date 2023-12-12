string[] words = Console.ReadLine().Split();
string result = "";
foreach (string word in words)
{
    int reps = word.Length;
    for (int i = 0; i < reps; i++)
    {
        result += word;
    }
}
Console.WriteLine(result);