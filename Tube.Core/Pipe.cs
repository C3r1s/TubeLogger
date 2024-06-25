namespace Tube;

public class Pipe
{
    public int Diameter { get; set; }
    public int Length { get; set; }
    public int Thickness { get; set; }
    public string Manufacturer { get; set; }
    
    public static int CheckParameter(int parameter)
    {
        if (parameter <= 0)
        {
            throw new Exception($"Parameter {parameter} must be positive and be more than 0");
        }

        return parameter;
    }

    public static string CheckManufacture(string manufacter)
    {
        if (manufacter == "")
        {
            throw new ArgumentNullException($"Ivalid input");
        }

        return manufacter;
    }
}