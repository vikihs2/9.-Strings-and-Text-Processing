string line = Console.ReadLine();
while (line != "end")
{ 
    line = Console.ReadLine();
}
string reversed = "";
for (int i = line.Length - 1; i >= 0; i--)
{
    reversed += line[i];
}
Console.WriteLine($"{line} = {reversed}");