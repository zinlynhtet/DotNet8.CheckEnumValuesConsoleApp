namespace DotNet8.CheckEnumValuesConsoleApp;

public enum EnumService
{
    Apple,
    Orange,
    Lime,
    GrapeFruit,
    Banana,
    StrawBerry
}
public enum Medals
{
    Gold = 1,
    Silver = 2,
    Bronze = 2
}

class Program
{
    static void Main()
    {
        var names = Enum.GetValues(typeof(EnumService));
        foreach (EnumService n in names)
        {
            Console.WriteLine(n);
        }

        var getNames = Enum.GetNames(typeof(EnumService)).Length;
        var getValues = Enum.GetValues(typeof(EnumService)).Length;
        Console.WriteLine("Total items by GetNames: " + getNames);
        Console.WriteLine("Total items by GetValues: " + getValues);

        var distinctValues = Enum.GetValues(typeof(Medals)).Cast<Medals>().Distinct().Count();
        Console.WriteLine("Total number of distinct values: " + distinctValues);
    }
}