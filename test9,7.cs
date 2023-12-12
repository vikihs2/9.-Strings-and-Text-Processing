int n = int.Parse(Console.ReadLine());
List<string> outputLines = new List<string>();
for (int i = 0; i < n; i++)
{
    string inputLine = Console.ReadLine();
    int nameStartIndex = inputLine.IndexOf('@');
    int nameEndIndex = inputLine.IndexOf('|', nameStartIndex);
    int ageStartIndex = inputLine.IndexOf('#', nameEndIndex);
    int ageEndIndex = inputLine.IndexOf('*', ageStartIndex);
    if (nameStartIndex != -1 && nameEndIndex != -1 && ageStartIndex != -1 && ageEndIndex != -1)
    {
        string name = inputLine.Substring(nameStartIndex + 1, nameEndIndex - nameStartIndex - 1);
        string ageStr = inputLine.Substring(ageStartIndex + 1, ageEndIndex - ageStartIndex - 1);
        if (int.TryParse(ageStr, out int age))
        {
            string outputLine = $"{name} is {age} years old.";
           outputLines.Add(outputLine);
        }
    }
}
foreach (string outputLine in outputLines)
{
    Console.WriteLine(outputLine);
}