partial class Program
{
    static void ShowNumericTypes()
    {
        int integer = 42;
        double doublelNumber = 3.1416d;
        float floatNumber = 274f;
        long longNumber = 12345678901234L;
        decimal monetaryNumber = 12345.67m;
        Console.WriteLine($"Integer: {integer}");
        Console.WriteLine($"Double: {doublelNumber}");
        Console.WriteLine($"Float: {floatNumber}");
        Console.WriteLine($"Long: {longNumber}");
        Console.WriteLine($"Decimal (monetary): {monetaryNumber}");   
    }
}