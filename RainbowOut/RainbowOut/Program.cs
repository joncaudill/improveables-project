var inputText = args?.Length > 0 ? args[0] : "Hello World!";

rainbowOut(inputText);

void rainbowOut(string inputString, ConsoleColor[]? inputColors = null)
{
    ConsoleColor[] rainbowColors = [
        ConsoleColor.Red,
        ConsoleColor.Yellow,
        ConsoleColor.Green,
        ConsoleColor.Blue,
        ConsoleColor.Magenta
    ];
    //check for valid input
    if (inputColors == null)
    {
        inputColors = rainbowColors;
    }
    if (inputString == null || inputString.Length == 0)
    {
        return;
    }
    //get initial state of console foreground color so that it can be set back 
    //at the end of the routine
    var originalColor = Console.ForegroundColor;

    var numColors = inputColors.Length;
    for (int i = 0; i < inputString.Length; i++)
    {
        var color = inputColors[i % numColors];
        Console.ForegroundColor = color;
        Console.Write(inputString[i]);
    }
    Console.Write(Environment.NewLine);
    Console.ForegroundColor = originalColor;
}
