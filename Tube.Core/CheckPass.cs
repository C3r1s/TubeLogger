namespace Tube;

public class CheckPass
{
    public static string IntCheck(int parameter)
    {
        try
        {
            var result = Pipe.CheckParameter(parameter);
            Console.WriteLine($"Parameter {result} is positive");
            return "Pass";
        }
        catch (Exception e)
        {
            Cli.PrintError($"!ERROR! {e.Message}");
            return "Error";
        }
    }

    public static string StringCheck(string manufacture)
    {
        try
        {
            var result = Pipe.CheckManufacture(manufacture);
            Console.WriteLine($"Manufacture {result} is correct");
            return "Pass";
        }
        catch (ArgumentNullException e)
        {
            Cli.PrintError($"!ERROR! {e.Message}");
            return "Error";
        }
    }
}