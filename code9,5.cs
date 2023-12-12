string filePath = Console.ReadLine();
 Use System.IO.Path - extractva file name and extension
string fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);
string fileExtension = System.IO.Path.GetExtension(filePath).TrimStart('.');
Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {(string.IsNullOrEmpty(fileExtension) ? "No extension" : fileExtension)}");