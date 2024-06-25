namespace Tube;

public class Cli
{
    public static int InputInt(string message)
    {
        string inputData;
        Console.Write(message);
        inputData = Console.ReadLine();
        return Convert.ToInt32(inputData);
    }
    
    public static string InputString(string message)
    {
        string inputData;
        Console.Write(message);
        inputData = Console.ReadLine();
        return inputData;
    }
    
    private static void PrintLine(string message, ConsoleColor colorText = ConsoleColor.White, ConsoleColor colorBackground = ConsoleColor.Black)
    {
        Console.ForegroundColor = colorText;
        Console.BackgroundColor = colorBackground;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintError(string message)
    {
        PrintLine(message, ConsoleColor.Red);
    }
}