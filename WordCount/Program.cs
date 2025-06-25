
var filePath = args?.Length > 0 ? args[0] : "poe-fall-of-the-house-of-usher.txt";

WordCount(filePath);

void WordCount(string inputFilePath)
{
    string fileText = File.ReadAllText(inputFilePath);

    int fileWordcount = fileText.Split(new char[] { ' ', '\n', '\r', '\t' },
    StringSplitOptions.RemoveEmptyEntries).Length;

    Console.WriteLine($"# of words: {fileWordcount}");
}
